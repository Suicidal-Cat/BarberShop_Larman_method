namespace Client.UserControls.UCTermin
{
	partial class UCDodajFrizeraTerminu
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
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvTermini = new System.Windows.Forms.DataGridView();
			this.IdTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VremePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Musterija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Frizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDodeliFrizera = new System.Windows.Forms.Button();
			this.btnDostupnost = new System.Windows.Forms.Button();
			this.cbFrizeri = new System.Windows.Forms.ComboBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnIzmeniTermin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
			this.SuspendLayout();
			// 
			// monthCalendar
			// 
			this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.monthCalendar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendar.Location = new System.Drawing.Point(67, 81);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Izbor frizera za termin";
			// 
			// dgvTermini
			// 
			this.dgvTermini.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTermina,
            this.DatumTermina,
            this.VremePocetka,
            this.Trajanje,
            this.Musterija,
            this.Frizer});
			this.dgvTermini.Location = new System.Drawing.Point(67, 300);
			this.dgvTermini.MultiSelect = false;
			this.dgvTermini.Name = "dgvTermini";
			this.dgvTermini.RowHeadersWidth = 51;
			this.dgvTermini.RowTemplate.Height = 24;
			this.dgvTermini.Size = new System.Drawing.Size(623, 207);
			this.dgvTermini.TabIndex = 2;
			// 
			// IdTermina
			// 
			this.IdTermina.HeaderText = "IdTermina";
			this.IdTermina.MinimumWidth = 6;
			this.IdTermina.Name = "IdTermina";
			this.IdTermina.Visible = false;
			this.IdTermina.Width = 97;
			// 
			// DatumTermina
			// 
			this.DatumTermina.HeaderText = "DatumTermina";
			this.DatumTermina.MinimumWidth = 6;
			this.DatumTermina.Name = "DatumTermina";
			this.DatumTermina.Width = 125;
			// 
			// VremePocetka
			// 
			this.VremePocetka.HeaderText = "VremePocetka";
			this.VremePocetka.MinimumWidth = 6;
			this.VremePocetka.Name = "VremePocetka";
			this.VremePocetka.Width = 126;
			// 
			// Trajanje
			// 
			this.Trajanje.HeaderText = "Trajanje";
			this.Trajanje.MinimumWidth = 6;
			this.Trajanje.Name = "Trajanje";
			this.Trajanje.Width = 86;
			// 
			// Musterija
			// 
			this.Musterija.HeaderText = "Musterija";
			this.Musterija.MinimumWidth = 6;
			this.Musterija.Name = "Musterija";
			this.Musterija.Width = 90;
			// 
			// Frizer
			// 
			this.Frizer.HeaderText = "Frizer";
			this.Frizer.MinimumWidth = 6;
			this.Frizer.Name = "Frizer";
			this.Frizer.Width = 69;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(382, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 28);
			this.label2.TabIndex = 3;
			this.label2.Text = "Frizer:";
			// 
			// btnDodeliFrizera
			// 
			this.btnDodeliFrizera.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDodeliFrizera.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodeliFrizera.Location = new System.Drawing.Point(387, 233);
			this.btnDodeliFrizera.Name = "btnDodeliFrizera";
			this.btnDodeliFrizera.Size = new System.Drawing.Size(303, 45);
			this.btnDodeliFrizera.TabIndex = 4;
			this.btnDodeliFrizera.Text = "Dodeli termin frizeru";
			this.btnDodeliFrizera.UseVisualStyleBackColor = true;
			// 
			// btnDostupnost
			// 
			this.btnDostupnost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDostupnost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDostupnost.Location = new System.Drawing.Point(387, 167);
			this.btnDostupnost.Name = "btnDostupnost";
			this.btnDostupnost.Size = new System.Drawing.Size(303, 45);
			this.btnDostupnost.TabIndex = 5;
			this.btnDostupnost.Text = "Proveri dostupnost";
			this.btnDostupnost.UseVisualStyleBackColor = true;
			// 
			// cbFrizeri
			// 
			this.cbFrizeri.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFrizeri.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFrizeri.FormattingEnabled = true;
			this.cbFrizeri.Location = new System.Drawing.Point(387, 114);
			this.cbFrizeri.Name = "cbFrizeri";
			this.cbFrizeri.Size = new System.Drawing.Size(303, 36);
			this.cbFrizeri.TabIndex = 6;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(67, 523);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(151, 40);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// btnIzmeniTermin
			// 
			this.btnIzmeniTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIzmeniTermin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIzmeniTermin.Location = new System.Drawing.Point(470, 523);
			this.btnIzmeniTermin.Name = "btnIzmeniTermin";
			this.btnIzmeniTermin.Size = new System.Drawing.Size(220, 40);
			this.btnIzmeniTermin.TabIndex = 8;
			this.btnIzmeniTermin.Text = "Izmeni termin";
			this.btnIzmeniTermin.UseVisualStyleBackColor = true;
			// 
			// UCDodajFrizeraTerminu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnIzmeniTermin);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.cbFrizeri);
			this.Controls.Add(this.btnDostupnost);
			this.Controls.Add(this.btnDodeliFrizera);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvTermini);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.monthCalendar);
			this.Name = "UCDodajFrizeraTerminu";
			this.Size = new System.Drawing.Size(752, 580);
			((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnDodeliFrizera;
		internal System.Windows.Forms.Button btnDostupnost;
		internal System.Windows.Forms.ComboBox cbFrizeri;
		internal System.Windows.Forms.MonthCalendar monthCalendar;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.DataGridView dgvTermini;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdTermina;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumTermina;
		private System.Windows.Forms.DataGridViewTextBoxColumn VremePocetka;
		private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
		private System.Windows.Forms.DataGridViewTextBoxColumn Musterija;
		private System.Windows.Forms.DataGridViewTextBoxColumn Frizer;
		internal System.Windows.Forms.Button btnIzmeniTermin;
	}
}
