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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMServer));
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblServerStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStop
			// 
			this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStop.BackColor = System.Drawing.Color.White;
			this.btnStop.Enabled = false;
			this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.ForeColor = System.Drawing.Color.Sienna;
			this.btnStop.Location = new System.Drawing.Point(45, 171);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(127, 58);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = " Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStart.BackColor = System.Drawing.Color.White;
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.Sienna;
			this.btnStart.Location = new System.Drawing.Point(45, 89);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(127, 58);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblServerStatus
			// 
			this.lblServerStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblServerStatus.AutoSize = true;
			this.lblServerStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServerStatus.ForeColor = System.Drawing.Color.Crimson;
			this.lblServerStatus.Location = new System.Drawing.Point(230, 144);
			this.lblServerStatus.Name = "lblServerStatus";
			this.lblServerStatus.Size = new System.Drawing.Size(160, 29);
			this.lblServerStatus.TabIndex = 3;
			this.lblServerStatus.Text = "Server is down";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Sienna;
			this.label1.Location = new System.Drawing.Point(40, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Darko Kolaric 2020/0125";
			// 
			// FRMServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 262);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblServerStatus);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnStop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FRMServer";
			this.Text = "Server";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMServer_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblServerStatus;
		private System.Windows.Forms.Label label1;
	}
}

