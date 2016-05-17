using System;

namespace TimeLapser
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNumberingStart = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ddResolution = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCaptureInterval = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtEnd = new System.Windows.Forms.MaskedTextBox();
			this.txtStart = new System.Windows.Forms.MaskedTextBox();
			this.ddVideoDevice = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.picPreview = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmdStart = new System.Windows.Forms.Button();
			this.cmdStop = new System.Windows.Forms.Button();
			this.tsslRunning = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNumberingStart);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.ddResolution);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCaptureInterval);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPath);
			this.groupBox1.Controls.Add(this.txtEnd);
			this.groupBox1.Controls.Add(this.txtStart);
			this.groupBox1.Controls.Add(this.ddVideoDevice);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 410);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// txtNumberingStart
			// 
			this.txtNumberingStart.Location = new System.Drawing.Point(122, 151);
			this.txtNumberingStart.Name = "txtNumberingStart";
			this.txtNumberingStart.Size = new System.Drawing.Size(144, 20);
			this.txtNumberingStart.TabIndex = 14;
			this.txtNumberingStart.Text = "1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Start numbering at:";
			// 
			// ddResolution
			// 
			this.ddResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddResolution.FormattingEnabled = true;
			this.ddResolution.Location = new System.Drawing.Point(122, 98);
			this.ddResolution.Name = "ddResolution";
			this.ddResolution.Size = new System.Drawing.Size(144, 21);
			this.ddResolution.TabIndex = 12;
			this.ddResolution.SelectedValueChanged += new System.EventHandler(this.ddResolution_SelectedValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Resolution:";
			// 
			// txtCaptureInterval
			// 
			this.txtCaptureInterval.Location = new System.Drawing.Point(122, 125);
			this.txtCaptureInterval.Name = "txtCaptureInterval";
			this.txtCaptureInterval.Size = new System.Drawing.Size(144, 20);
			this.txtCaptureInterval.TabIndex = 10;
			this.txtCaptureInterval.Text = "15";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Capture interval (s):";
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(20, 206);
			this.txtPath.Multiline = true;
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(232, 189);
			this.txtPath.TabIndex = 8;
			// 
			// txtEnd
			// 
			this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEnd.Location = new System.Drawing.Point(122, 45);
			this.txtEnd.Mask = "00:00";
			this.txtEnd.Name = "txtEnd";
			this.txtEnd.Size = new System.Drawing.Size(144, 20);
			this.txtEnd.TabIndex = 7;
			this.txtEnd.Text = "2000";
			this.txtEnd.ValidatingType = typeof(System.DateTime);
			// 
			// txtStart
			// 
			this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStart.Location = new System.Drawing.Point(122, 19);
			this.txtStart.Mask = "00:00";
			this.txtStart.Name = "txtStart";
			this.txtStart.Size = new System.Drawing.Size(144, 20);
			this.txtStart.TabIndex = 6;
			this.txtStart.Text = "0500";
			this.txtStart.ValidatingType = typeof(System.DateTime);
			// 
			// ddVideoDevice
			// 
			this.ddVideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddVideoDevice.FormattingEnabled = true;
			this.ddVideoDevice.Location = new System.Drawing.Point(122, 71);
			this.ddVideoDevice.Name = "ddVideoDevice";
			this.ddVideoDevice.Size = new System.Drawing.Size(144, 21);
			this.ddVideoDevice.TabIndex = 5;
			this.ddVideoDevice.SelectedValueChanged += new System.EventHandler(this.ddVideoDevice_SelectedValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Select Project Save Folder";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Video Device:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Capture hours end:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Capture hours start:";
			// 
			// picPreview
			// 
			this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picPreview.Image = global::TimeLapser.Properties.Resources._34279834_big_p1;
			this.picPreview.Location = new System.Drawing.Point(290, 13);
			this.picPreview.Name = "picPreview";
			this.picPreview.Size = new System.Drawing.Size(737, 458);
			this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPreview.TabIndex = 1;
			this.picPreview.TabStop = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslRunning});
			this.statusStrip1.Location = new System.Drawing.Point(0, 482);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslStatus
			// 
			this.tsslStatus.Name = "tsslStatus";
			this.tsslStatus.Size = new System.Drawing.Size(63, 17);
			this.tsslStatus.Text = "Status Text";
			// 
			// cmdStart
			// 
			this.cmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdStart.Location = new System.Drawing.Point(18, 428);
			this.cmdStart.Name = "cmdStart";
			this.cmdStart.Size = new System.Drawing.Size(75, 42);
			this.cmdStart.TabIndex = 3;
			this.cmdStart.Text = "Start";
			this.cmdStart.UseVisualStyleBackColor = true;
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			// 
			// cmdStop
			// 
			this.cmdStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdStop.Location = new System.Drawing.Point(96, 428);
			this.cmdStop.Name = "cmdStop";
			this.cmdStop.Size = new System.Drawing.Size(75, 42);
			this.cmdStop.TabIndex = 4;
			this.cmdStop.Text = "Stop";
			this.cmdStop.UseVisualStyleBackColor = true;
			this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
			// 
			// tsslRunning
			// 
			this.tsslRunning.Name = "tsslRunning";
			this.tsslRunning.Size = new System.Drawing.Size(26, 17);
			this.tsslRunning.Text = "Idle";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1039, 504);
			this.Controls.Add(this.cmdStop);
			this.Controls.Add(this.cmdStart);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.picPreview);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "H-TimeLapser";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox ddVideoDevice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtEnd;
		private System.Windows.Forms.MaskedTextBox txtStart;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox picPreview;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
		private System.Windows.Forms.Button cmdStart;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.TextBox txtCaptureInterval;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox ddResolution;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNumberingStart;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripStatusLabel tsslRunning;
	}
}

