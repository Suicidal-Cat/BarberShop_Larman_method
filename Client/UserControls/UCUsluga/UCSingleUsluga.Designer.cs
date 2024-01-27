namespace Client.UserControls.UCUsluga
{
	partial class UCSingleUsluga
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
			this.lblUsluga = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.txtCena = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTrajanje = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.lblIdUsluge = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUsluga
			// 
			this.lblUsluga.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUsluga.AutoSize = true;
			this.lblUsluga.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsluga.Location = new System.Drawing.Point(51, 29);
			this.lblUsluga.Name = "lblUsluga";
			this.lblUsluga.Size = new System.Drawing.Size(85, 32);
			this.lblUsluga.TabIndex = 0;
			this.lblUsluga.Text = "Usluga";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = " Naziv usluge";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(377, 327);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(197, 45);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Sacuvaj";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// txtNaziv
			// 
			this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNaziv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNaziv.Location = new System.Drawing.Point(271, 101);
			this.txtNaziv.MaxLength = 30;
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(303, 35);
			this.txtNaziv.TabIndex = 3;
			// 
			// txtCena
			// 
			this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCena.Location = new System.Drawing.Point(271, 175);
			this.txtCena.Name = "txtCena";
			this.txtCena.Size = new System.Drawing.Size(303, 35);
			this.txtCena.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = " Cena usluge(RSD)";
			// 
			// txtTrajanje
			// 
			this.txtTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTrajanje.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTrajanje.Location = new System.Drawing.Point(271, 250);
			this.txtTrajanje.Name = "txtTrajanje";
			this.txtTrajanje.Size = new System.Drawing.Size(303, 35);
			this.txtTrajanje.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(52, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = " Trajanje usluge (min)";
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(56, 327);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(158, 45);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// lblIdUsluge
			// 
			this.lblIdUsluge.AutoSize = true;
			this.lblIdUsluge.Location = new System.Drawing.Point(534, 44);
			this.lblIdUsluge.Name = "lblIdUsluge";
			this.lblIdUsluge.Size = new System.Drawing.Size(0, 16);
			this.lblIdUsluge.TabIndex = 10;
			this.lblIdUsluge.Visible = false;
			// 
			// UCSingleUsluga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblIdUsluge);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtTrajanje);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCena);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNaziv);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblUsluga);
			this.Name = "UCSingleUsluga";
			this.Size = new System.Drawing.Size(617, 417);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblUsluga;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.TextBox txtNaziv;
		internal System.Windows.Forms.TextBox txtCena;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtTrajanje;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Button btnBack;
		internal System.Windows.Forms.Label lblIdUsluge;
	}
}
