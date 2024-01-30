namespace Client.UserControls
{
	partial class UCDefaultMain
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDefaultMain));
			this.btnRezervisi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRezervisi
			// 
			this.btnRezervisi.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRezervisi.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnRezervisi.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnRezervisi.FlatAppearance.BorderSize = 2;
			this.btnRezervisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnRezervisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnRezervisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRezervisi.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRezervisi.ForeColor = System.Drawing.Color.Sienna;
			this.btnRezervisi.Location = new System.Drawing.Point(265, 241);
			this.btnRezervisi.Name = "btnRezervisi";
			this.btnRezervisi.Size = new System.Drawing.Size(380, 120);
			this.btnRezervisi.TabIndex = 0;
			this.btnRezervisi.Text = "Rezervisi termin";
			this.btnRezervisi.UseVisualStyleBackColor = false;
			// 
			// UCDefaultMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.btnRezervisi);
			this.Name = "UCDefaultMain";
			this.Size = new System.Drawing.Size(910, 603);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnRezervisi;
	}
}
