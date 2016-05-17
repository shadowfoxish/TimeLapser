using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace TimeLapser
{
	public partial class frmMain : Form
	{
		private TimeLapse timeLapser = null;
		private int FramesCaptured = 0;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			PopulateVideoDevices();
		}

		private void PopulateVideoDevices()
		{
			var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			ddVideoDevice.Items.Clear();
			for (int i = 0; i < videoDevices.Count; i++)
			{
				ddVideoDevice.Items.Add(new ListItem<string>() { Key = videoDevices[i].MonikerString, Value = videoDevices[i].Name });
			}
		}

		private void ddVideoDevice_SelectedValueChanged(object sender, EventArgs e)
		{
			PopulateResolutions(((ListItem<string>)ddVideoDevice.SelectedItem).Key);
		}

		private void PopulateResolutions(string deviceName)
		{
			VideoCaptureDevice device = new VideoCaptureDevice(deviceName);
			ddResolution.Items.Clear();
			foreach (var cap in device.VideoCapabilities)
			{
				ddResolution.Items.Add(new ListItem<VideoCapabilities>() { Key = cap, Value = $"{cap.FrameSize.Width}x{cap.FrameSize.Height}, {cap.MaximumFrameRate} FPS, {cap.BitCount} BPP" });
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = txtPath.Text;
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = fbd.SelectedPath;
			}
		}
		
		AutoResetEvent e = new AutoResetEvent(false);
		Image captured = null;

		private void GetFrame(string deviceName, VideoCapabilities cap)
		{
			VideoCaptureDevice device = new VideoCaptureDevice(deviceName);
			device.VideoResolution = cap;
			device.NewFrame += Device_NewFrame;
			device.Start();
			e.WaitOne();
			device.Stop();
			picPreview.Image = captured;
		}

		private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
		{
			captured = Image.FromHbitmap(eventArgs.Frame.GetHbitmap());
			e.Set();
		}

		private void ddResolution_SelectedValueChanged(object sender, EventArgs e)
		{
			if (ddVideoDevice.SelectedItem != null && ddResolution.SelectedItem != null)
			{
				GetFrame(((ListItem<string>)ddVideoDevice.SelectedItem).Key, ((ListItem<VideoCapabilities>)ddResolution.SelectedItem).Key);
			}
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{
			try
			{
				Settings s = ValidateAndRetrieveSettings();

				timeLapser = new TimeLapse();
				timeLapser.Config = s;
				timeLapser.NewImage = (img, nextRunIn) => UpdateImage(img, nextRunIn);
				
				timeLapser.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateImage(Bitmap img, TimeSpan nextRunIn)
		{
			if (picPreview.InvokeRequired)
			{
				picPreview.Invoke((MethodInvoker) delegate
				{
					var oldImage = this.picPreview.Image;
					this.picPreview.Image = AForge.Imaging.Image.Clone(img);
					oldImage.Dispose();
					this.FramesCaptured++;
					txtNumberingStart.Text = (int.Parse(txtNumberingStart.Text) + 1).ToString();
					tsslStatus.Text = $"Captured {this.FramesCaptured} frames";
					tsslRunning.Text = $"Running. Next capture at {DateTime.Now.Add(nextRunIn).ToString("yyyy-MM-dd HH:mm:ss")}";
                });
			}
		}

		private Settings ValidateAndRetrieveSettings()
		{
			Settings s = new Settings();
			s.StartTime = DateTime.ParseExact(txtStart.Text, "HH:mm", Thread.CurrentThread.CurrentCulture);
			s.EndTime = DateTime.ParseExact(txtEnd.Text, "HH:mm", Thread.CurrentThread.CurrentCulture);
			if (s.StartTime >= s.EndTime)
			{
				throw new Exception("Start time and end time overlap");
			}
			if (ddVideoDevice.Text == "")
			{
				throw new Exception("No video device selected");
			}
			s.VideoDeviceMoniker = ((ListItem<string>)ddVideoDevice.SelectedItem).Key;
			if (ddResolution.Text == "")
			{
				throw new Exception("No video resolution selected");
			}
			s.Resolution = ((ListItem<VideoCapabilities>)ddResolution.SelectedItem).Key;

			s.CaptureIntervalSeconds = int.Parse(txtCaptureInterval.Text);
			s.StartNumberingAt = int.Parse(txtNumberingStart.Text);

			s.SavePath = txtPath.Text;

			using (StreamWriter sw = File.CreateText(Path.Combine(s.SavePath, "test.txt")))
			{
				sw.Write("Test");
				sw.Close();
			}

			File.Delete(Path.Combine(s.SavePath, "test.txt"));

			return s;
		}

		private void cmdStop_Click(object sender, EventArgs e)
		{
			if (timeLapser != null)
			{
				timeLapser.Stop();
				tsslRunning.Text = "Idle";
			}
		}
	}
}
