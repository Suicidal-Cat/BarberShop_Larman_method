﻿namespace Client.UserControls
{
	partial class UCSingleFrizer
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
			this.txtNaslov = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSacuvajFrizera = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDatumZaposlenja = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIme.Location = new System.Drawing.Point(228, 107);
			this.txtIme.MaxLength = 30;
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(222, 28);
			this.txtIme.TabIndex = 0;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrezime.Location = new System.Drawing.Point(228, 172);
			this.txtPrezime.MaxLength = 30;
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(222, 28);
			this.txtPrezime.TabIndex = 1;
			// 
			// cbPol
			// 
			this.cbPol.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPol.FormattingEnabled = true;
			this.cbPol.Location = new System.Drawing.Point(228, 240);
			this.cbPol.Name = "cbPol";
			this.cbPol.Size = new System.Drawing.Size(222, 30);
			this.cbPol.TabIndex = 2;
			// 
			// txtBrTelfona
			// 
			this.txtBrTelfona.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBrTelfona.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBrTelfona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBrTelfona.ForeColor = System.Drawing.Color.DarkGray;
			this.txtBrTelfona.Location = new System.Drawing.Point(228, 302);
			this.txtBrTelfona.MaxLength = 15;
			this.txtBrTelfona.Name = "txtBrTelfona";
			this.txtBrTelfona.Size = new System.Drawing.Size(222, 28);
			this.txtBrTelfona.TabIndex = 3;
			this.txtBrTelfona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBrTelfona_MouseClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ime:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(63, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = " Prezime:";
			// 
			// txtNaslov
			// 
			this.txtNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNaslov.AutoSize = true;
			this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNaslov.Location = new System.Drawing.Point(36, 36);
			this.txtNaslov.Name = "txtNaslov";
			this.txtNaslov.Size = new System.Drawing.Size(141, 25);
			this.txtNaslov.TabIndex = 6;
			this.txtNaslov.Text = "Dodaj Frizera";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(63, 243);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = " Pol:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(63, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = " Broj telefona";
			// 
			// btnSacuvajFrizera
			// 
			this.btnSacuvajFrizera.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSacuvajFrizera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvajFrizera.Location = new System.Drawing.Point(228, 484);
			this.btnSacuvajFrizera.Name = "btnSacuvajFrizera";
			this.btnSacuvajFrizera.Size = new System.Drawing.Size(222, 52);
			this.btnSacuvajFrizera.TabIndex = 9;
			this.btnSacuvajFrizera.Text = "Sacuvaj";
			this.btnSacuvajFrizera.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(63, 364);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = " Status";
			// 
			// cbStatus
			// 
			this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(228, 364);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(222, 30);
			this.cbStatus.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(66, 426);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 22);
			this.label7.TabIndex = 12;
			this.label7.Text = "Datum zaposlenja";
			// 
			// txtDatumZaposlenja
			// 
			this.txtDatumZaposlenja.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDatumZaposlenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDatumZaposlenja.Location = new System.Drawing.Point(228, 423);
			this.txtDatumZaposlenja.Name = "txtDatumZaposlenja";
			this.txtDatumZaposlenja.Size = new System.Drawing.Size(222, 28);
			this.txtDatumZaposlenja.TabIndex = 13;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(41, 484);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(138, 52);
			this.btnBack.TabIndex = 14;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// UCFrizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtDatumZaposlenja);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSacuvajFrizera);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNaslov);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBrTelfona);
			this.Controls.Add(this.cbPol);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.txtIme);
			this.Name = "UCFrizer";
			this.Size = new System.Drawing.Size(513, 569);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtNaslov;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Button btnSacuvajFrizera;
		internal System.Windows.Forms.TextBox txtIme;
		internal System.Windows.Forms.TextBox txtPrezime;
		internal System.Windows.Forms.ComboBox cbPol;
		internal System.Windows.Forms.TextBox txtBrTelfona;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.ComboBox cbStatus;
		internal System.Windows.Forms.TextBox txtDatumZaposlenja;
		internal System.Windows.Forms.Button btnBack;
	}
}
