using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AForge.Video.DirectShow;

namespace TimeLapser
{
	public class TimeLapse
	{

		public TimeLapse()
		{
			encoder = ImageCodecInfo.GetImageEncoders().First(e => e.MimeType == "image/jpeg");
			encoderParams = new EncoderParameters(1);
			encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 99L);
		}

		private ImageCodecInfo encoder = null;
		private EncoderParameters encoderParams = null;
		int currentFileNumber = 0;

		public Settings Config
		{
			get; set;
		}

		private AutoResetEvent stopEvent = new AutoResetEvent(false);
		private AutoResetEvent gotFrame = new AutoResetEvent(false);
		private Bitmap captured = null;
		Timer captureTimer;
		public void Start()
		{
			currentFileNumber = Config.StartNumberingAt;
			TimerCallback tcb = this.GetFrame;
			captureTimer = new Timer(tcb, null, 0, Timeout.Infinite);
		}

		private TimeSpan GetNextCaptureTime()
		{
			if (DateTime.Now.TimeOfDay >= this.Config.StartTime.TimeOfDay &&
				DateTime.Now.TimeOfDay <= this.Config.EndTime.TimeOfDay)
			{
				Debug.Write(new TimeSpan(0, 0, this.Config.CaptureIntervalSeconds).ToString());
				return new TimeSpan(0, 0, this.Config.CaptureIntervalSeconds);
			}
			else
			{
				//We're outside the desired window for today, dont capture until the next start interval.
				DateTime whenToStartNext = DateTime.Now.AddDays(1).Subtract(DateTime.Now.TimeOfDay).Add(this.Config.StartTime.TimeOfDay);
				Debug.Write((whenToStartNext - DateTime.Now).ToString());
				return whenToStartNext - DateTime.Now;
			}
		}

		public void GetFrame(object stateInfo)
		{
			try
			{
				var device = Config.CreateCaptureDevice();
				device.NewFrame += Device_NewFrame;
				device.Start();
				gotFrame.WaitOne();
				gotFrame.WaitOne(); //Take two frames, so it clears
				gotFrame.Reset();
				device.Stop();

				//Save image
				SaveImage(captured);
			}
			catch (Exception ex)
			{
				Debug.Write(ex.ToString());
			}
			finally
			{
				//Schedule next run
				var nextRunIn = GetNextCaptureTime();
				this.captureTimer.Change(nextRunIn, new TimeSpan(0, 0, 0, 0, -1));

				//Notify UI
				if (NewImage != null)
				{
					NewImage(captured, nextRunIn);
					captured.Dispose();
				}
			}
		}

		private void SaveImage(Image captured)
		{
			string saveFile = Path.Combine(Config.SavePath, this.currentFileNumber.ToString().PadLeft(10, '0') + ".jpg");
			captured.Save(saveFile, encoder, encoderParams);
			this.currentFileNumber++;
		}

		private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
		{
			if (captured != null)
			{
				captured.Dispose();
			}
			captured = AForge.Imaging.Image.Clone(eventArgs.Frame);
			gotFrame.Set();
		}

		public Action<Bitmap, TimeSpan> NewImage
		{
			get; set;
		}

		public void Stop()
		{
			if (captureTimer != null)
			{
				captureTimer.Change(Timeout.Infinite, 0);
			}
		}
	}
}
