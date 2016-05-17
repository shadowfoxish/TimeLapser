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
			return new VideoCaptureDevice(this.VideoDeviceMoniker) { VideoResolution = Resolution };
		}
	}
}
