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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.monthCalendar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendar.Location = new System.Drawing.Point(68, 148);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Sienna;
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Izbor frizera za termin";
			// 
			// dgvTermini
			// 
			this.dgvTermini.AllowUserToAddRows = false;
			this.dgvTermini.AllowUserToDeleteRows = false;
			this.dgvTermini.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTermini.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTermini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTermina,
            this.DatumTermina,
            this.VremePocetka,
            this.Trajanje,
            this.Musterija,
            this.Frizer});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTermini.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTermini.GridColor = System.Drawing.Color.BlanchedAlmond;
			this.dgvTermini.Location = new System.Drawing.Point(68, 367);
			this.dgvTermini.MultiSelect = false;
			this.dgvTermini.Name = "dgvTermini";
			this.dgvTermini.ReadOnly = true;
			this.dgvTermini.RowHeadersWidth = 51;
			this.dgvTermini.RowTemplate.Height = 24;
			this.dgvTermini.Size = new System.Drawing.Size(741, 207);
			this.dgvTermini.TabIndex = 2;
			// 
			// IdTermina
			// 
			this.IdTermina.HeaderText = "IdTermina";
			this.IdTermina.MinimumWidth = 6;
			this.IdTermina.Name = "IdTermina";
			this.IdTermina.ReadOnly = true;
			this.IdTermina.Visible = false;
			this.IdTermina.Width = 97;
			// 
			// DatumTermina
			// 
			this.DatumTermina.HeaderText = "DatumTermina";
			this.DatumTermina.MinimumWidth = 6;
			this.DatumTermina.Name = "DatumTermina";
			this.DatumTermina.ReadOnly = true;
			this.DatumTermina.Width = 138;
			// 
			// VremePocetka
			// 
			this.VremePocetka.HeaderText = "VremePocetka";
			this.VremePocetka.MinimumWidth = 6;
			this.VremePocetka.Name = "VremePocetka";
			this.VremePocetka.ReadOnly = true;
			this.VremePocetka.Width = 138;
			// 
			// Trajanje
			// 
			this.Trajanje.HeaderText = "Trajanje";
			this.Trajanje.MinimumWidth = 6;
			this.Trajanje.Name = "Trajanje";
			this.Trajanje.ReadOnly = true;
			this.Trajanje.Width = 92;
			// 
			// Musterija
			// 
			this.Musterija.HeaderText = "Musterija";
			this.Musterija.MinimumWidth = 6;
			this.Musterija.Name = "Musterija";
			this.Musterija.ReadOnly = true;
			this.Musterija.Width = 104;
			// 
			// Frizer
			// 
			this.Frizer.HeaderText = "Frizer";
			this.Frizer.MinimumWidth = 6;
			this.Frizer.Name = "Frizer";
			this.Frizer.ReadOnly = true;
			this.Frizer.Width = 79;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(426, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Frizer:";
			// 
			// btnDodeliFrizera
			// 
			this.btnDodeliFrizera.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDodeliFrizera.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnDodeliFrizera.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnDodeliFrizera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDodeliFrizera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDodeliFrizera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDodeliFrizera.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodeliFrizera.ForeColor = System.Drawing.Color.Sienna;
			this.btnDodeliFrizera.Location = new System.Drawing.Point(431, 298);
			this.btnDodeliFrizera.Name = "btnDodeliFrizera";
			this.btnDodeliFrizera.Size = new System.Drawing.Size(378, 45);
			this.btnDodeliFrizera.TabIndex = 4;
			this.btnDodeliFrizera.Text = "Dodeli termin frizeru";
			this.btnDodeliFrizera.UseVisualStyleBackColor = false;
			// 
			// btnDostupnost
			// 
			this.btnDostupnost.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDostupnost.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnDostupnost.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnDostupnost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDostupnost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDostupnost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDostupnost.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDostupnost.ForeColor = System.Drawing.Color.Sienna;
			this.btnDostupnost.Location = new System.Drawing.Point(431, 232);
			this.btnDostupnost.Name = "btnDostupnost";
			this.btnDostupnost.Size = new System.Drawing.Size(378, 45);
			this.btnDostupnost.TabIndex = 5;
			this.btnDostupnost.Text = "Proveri dostupnost";
			this.btnDostupnost.UseVisualStyleBackColor = false;
			// 
			// cbFrizeri
			// 
			this.cbFrizeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbFrizeri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFrizeri.FormattingEnabled = true;
			this.cbFrizeri.Location = new System.Drawing.Point(431, 179);
			this.cbFrizeri.Name = "cbFrizeri";
			this.cbFrizeri.Size = new System.Drawing.Size(378, 34);
			this.cbFrizeri.TabIndex = 6;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.Sienna;
			this.btnBack.Location = new System.Drawing.Point(68, 596);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(182, 50);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// btnIzmeniTermin
			// 
			this.btnIzmeniTermin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnIzmeniTermin.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnIzmeniTermin.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnIzmeniTermin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnIzmeniTermin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnIzmeniTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIzmeniTermin.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIzmeniTermin.ForeColor = System.Drawing.Color.Sienna;
			this.btnIzmeniTermin.Location = new System.Drawing.Point(526, 596);
			this.btnIzmeniTermin.Name = "btnIzmeniTermin";
			this.btnIzmeniTermin.Size = new System.Drawing.Size(283, 50);
			this.btnIzmeniTermin.TabIndex = 8;
			this.btnIzmeniTermin.Text = "Izmeni termin";
			this.btnIzmeniTermin.UseVisualStyleBackColor = false;
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
			this.Size = new System.Drawing.Size(865, 660);
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
