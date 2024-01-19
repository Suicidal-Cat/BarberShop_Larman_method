namespace ProSoft_projekat_2020_0125
{
	partial class FRMServer
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
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblServerStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStop
			// 
			this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStop.Enabled = false;
			this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Location = new System.Drawing.Point(39, 140);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(127, 58);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = " Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(39, 58);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(127, 58);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = " Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblServerStatus
			// 
			this.lblServerStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblServerStatus.AutoSize = true;
			this.lblServerStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServerStatus.ForeColor = System.Drawing.Color.Crimson;
			this.lblServerStatus.Location = new System.Drawing.Point(224, 113);
			this.lblServerStatus.Name = "lblServerStatus";
			this.lblServerStatus.Size = new System.Drawing.Size(160, 29);
			this.lblServerStatus.TabIndex = 3;
			this.lblServerStatus.Text = "Server is down";
			// 
			// FRMServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 262);
			this.Controls.Add(this.lblServerStatus);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnStop);
			this.Name = "FRMServer";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMServer_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblServerStatus;
	}
}

