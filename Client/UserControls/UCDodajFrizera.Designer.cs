namespace Client.UserControls
{
	partial class UCDodajFrizera
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
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.cbPol = new System.Windows.Forms.ComboBox();
			this.txtBrTelfona = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDodajFrizera = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIme.Location = new System.Drawing.Point(250, 123);
			this.txtIme.MaxLength = 30;
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(178, 28);
			this.txtIme.TabIndex = 0;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezime.Location = new System.Drawing.Point(250, 194);
			this.txtPrezime.MaxLength = 30;
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(178, 28);
			this.txtPrezime.TabIndex = 1;
			// 
			// cbPol
			// 
			this.cbPol.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPol.FormattingEnabled = true;
			this.cbPol.Location = new System.Drawing.Point(250, 259);
			this.cbPol.Name = "cbPol";
			this.cbPol.Size = new System.Drawing.Size(178, 30);
			this.cbPol.TabIndex = 2;
			// 
			// txtBrTelfona
			// 
			this.txtBrTelfona.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBrTelfona.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBrTelfona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrTelfona.ForeColor = System.Drawing.Color.DarkGray;
			this.txtBrTelfona.Location = new System.Drawing.Point(250, 324);
			this.txtBrTelfona.MaxLength = 15;
			this.txtBrTelfona.Name = "txtBrTelfona";
			this.txtBrTelfona.Size = new System.Drawing.Size(178, 28);
			this.txtBrTelfona.TabIndex = 3;
			this.txtBrTelfona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBrTelfona_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Unesite ime:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = " Unesite prezime:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Dodaj Frizera";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(65, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "Izaberite pol:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(65, 325);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Unesite broj telefona:";
			// 
			// btnDodajFrizera
			// 
			this.btnDodajFrizera.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDodajFrizera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajFrizera.Location = new System.Drawing.Point(250, 392);
			this.btnDodajFrizera.Name = "btnDodajFrizera";
			this.btnDodajFrizera.Size = new System.Drawing.Size(178, 52);
			this.btnDodajFrizera.TabIndex = 9;
			this.btnDodajFrizera.Text = "Dodaj frizera";
			this.btnDodajFrizera.UseVisualStyleBackColor = true;
			// 
			// UCDodajFrizera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDodajFrizera);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBrTelfona);
			this.Controls.Add(this.cbPol);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.txtIme);
			this.Name = "UCDodajFrizera";
			this.Size = new System.Drawing.Size(521, 529);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Button btnDodajFrizera;
		internal System.Windows.Forms.TextBox txtIme;
		internal System.Windows.Forms.TextBox txtPrezime;
		internal System.Windows.Forms.ComboBox cbPol;
		internal System.Windows.Forms.TextBox txtBrTelfona;
	}
}
