using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;

namespace TimeLapser
{
	public class Settings
	{
		public DateTime StartTime
		{
			get; set;
		}

		public DateTime EndTime
		{
			get; set; 
		}

		public string VideoDeviceMoniker { get; set; }

		public VideoCapabilities Resolution { get; set; }

		public int CaptureIntervalSeconds { get; set; }

		public string SavePath { get; set; }

		public int StartNumberingAt
		{
			get; set;
		}

		public VideoCaptureDevice CreateCaptureDevice()
		{
			var device = new VideoCaptureDevice(this.VideoDeviceMoniker) { VideoResolution = Resolution };

			int maxValue, minValue, step, defaultValue;
			CameraControlFlags ccFlags;

			device.GetCameraPropertyRange(CameraControlProperty.Focus, out minValue, out maxValue, out step, out defaultValue, out ccFlags);
			//System.Windows.Forms.MessageBox.Show($"{maxValue}, {minValue}");
            device.SetCameraProperty(CameraControlProperty.Focus, minValue, CameraControlFlags.Manual); //MinValue = furthest focus distance. 
			return device;
		}
	}
}
