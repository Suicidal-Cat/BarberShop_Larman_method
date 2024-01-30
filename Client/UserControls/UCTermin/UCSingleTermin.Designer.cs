namespace Client.UserControls.UCTermin
{
	partial class UCSingleTermin
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.hoursCounter = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.minutesCounter = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNapomena = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvUsluge = new System.Windows.Forms.DataGridView();
			this.IdUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnDodajUslugu = new System.Windows.Forms.Button();
			this.cbUsluge = new System.Windows.Forms.ComboBox();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCena = new System.Windows.Forms.TextBox();
			this.txtVreme = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbMusterije = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtIdTermina = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.hoursCounter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Sienna;
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rezervacija termina";
			// 
			// monthCalendar
			// 
			this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.monthCalendar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthCalendar.Location = new System.Drawing.Point(69, 112);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Datum termina:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(735, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "min";
			// 
			// hoursCounter
			// 
			this.hoursCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.hoursCounter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hoursCounter.Location = new System.Drawing.Point(578, 163);
			this.hoursCounter.Name = "hoursCounter";
			this.hoursCounter.Size = new System.Drawing.Size(67, 34);
			this.hoursCounter.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(641, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "h";
			// 
			// minutesCounter
			// 
			this.minutesCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.minutesCounter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesCounter.Location = new System.Drawing.Point(667, 163);
			this.minutesCounter.Name = "minutesCounter";
			this.minutesCounter.Size = new System.Drawing.Size(69, 34);
			this.minutesCounter.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.txtNapomena);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dgvUsluge);
			this.groupBox1.Controls.Add(this.btnDodajUslugu);
			this.groupBox1.Controls.Add(this.cbUsluge);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(40, 331);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(910, 340);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Izbor usluga";
			// 
			// txtNapomena
			// 
			this.txtNapomena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNapomena.Location = new System.Drawing.Point(10, 94);
			this.txtNapomena.MaxLength = 255;
			this.txtNapomena.Multiline = true;
			this.txtNapomena.Name = "txtNapomena";
			this.txtNapomena.Size = new System.Drawing.Size(445, 58);
			this.txtNapomena.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Napomena:";
			// 
			// dgvUsluge
			// 
			this.dgvUsluge.AllowUserToAddRows = false;
			this.dgvUsluge.AllowUserToDeleteRows = false;
			this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsluge.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsluge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsluge,
            this.NazivUsluge,
            this.Cena,
            this.Trajanje,
            this.Napomena,
            this.Status,
            this.Izbrisi});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUsluge.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvUsluge.Location = new System.Drawing.Point(6, 156);
			this.dgvUsluge.MultiSelect = false;
			this.dgvUsluge.Name = "dgvUsluge";
			this.dgvUsluge.ReadOnly = true;
			this.dgvUsluge.RowHeadersWidth = 51;
			this.dgvUsluge.RowTemplate.Height = 24;
			this.dgvUsluge.Size = new System.Drawing.Size(898, 178);
			this.dgvUsluge.TabIndex = 2;
			// 
			// IdUsluge
			// 
			this.IdUsluge.HeaderText = "IdUsluge";
			this.IdUsluge.MinimumWidth = 6;
			this.IdUsluge.Name = "IdUsluge";
			this.IdUsluge.ReadOnly = true;
			this.IdUsluge.Visible = false;
			// 
			// NazivUsluge
			// 
			this.NazivUsluge.HeaderText = "Naziv";
			this.NazivUsluge.MinimumWidth = 6;
			this.NazivUsluge.Name = "NazivUsluge";
			this.NazivUsluge.ReadOnly = true;
			// 
			// Cena
			// 
			this.Cena.FillWeight = 60F;
			this.Cena.HeaderText = "Cena";
			this.Cena.MinimumWidth = 6;
			this.Cena.Name = "Cena";
			this.Cena.ReadOnly = true;
			// 
			// Trajanje
			// 
			this.Trajanje.FillWeight = 90F;
			this.Trajanje.HeaderText = "Trajanje(min)";
			this.Trajanje.MinimumWidth = 6;
			this.Trajanje.Name = "Trajanje";
			this.Trajanje.ReadOnly = true;
			// 
			// Napomena
			// 
			this.Napomena.FillWeight = 140F;
			this.Napomena.HeaderText = "Napomena";
			this.Napomena.MinimumWidth = 6;
			this.Napomena.Name = "Napomena";
			this.Napomena.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.FillWeight = 70F;
			this.Status.HeaderText = "Status";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// Izbrisi
			// 
			this.Izbrisi.FillWeight = 70F;
			this.Izbrisi.HeaderText = "";
			this.Izbrisi.MinimumWidth = 6;
			this.Izbrisi.Name = "Izbrisi";
			this.Izbrisi.ReadOnly = true;
			this.Izbrisi.Text = "Izbrisi";
			// 
			// btnDodajUslugu
			// 
			this.btnDodajUslugu.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnDodajUslugu.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnDodajUslugu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDodajUslugu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDodajUslugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDodajUslugu.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajUslugu.ForeColor = System.Drawing.Color.Sienna;
			this.btnDodajUslugu.Location = new System.Drawing.Point(637, 94);
			this.btnDodajUslugu.Name = "btnDodajUslugu";
			this.btnDodajUslugu.Size = new System.Drawing.Size(263, 58);
			this.btnDodajUslugu.TabIndex = 1;
			this.btnDodajUslugu.Text = "Dodaj uslugu";
			this.btnDodajUslugu.UseVisualStyleBackColor = false;
			// 
			// cbUsluge
			// 
			this.cbUsluge.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUsluge.FormattingEnabled = true;
			this.cbUsluge.Location = new System.Drawing.Point(10, 32);
			this.cbUsluge.Name = "cbUsluge";
			this.cbUsluge.Size = new System.Drawing.Size(252, 32);
			this.cbUsluge.TabIndex = 0;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSacuvaj.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnSacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnSacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSacuvaj.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSacuvaj.ForeColor = System.Drawing.Color.Sienna;
			this.btnSacuvaj.Location = new System.Drawing.Point(595, 679);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(345, 50);
			this.btnSacuvaj.TabIndex = 11;
			this.btnSacuvaj.Text = "Sacuvaj termin";
			this.btnSacuvaj.UseVisualStyleBackColor = false;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.Sienna;
			this.btnBack.Location = new System.Drawing.Point(50, 681);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(176, 48);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(448, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 26);
			this.label6.TabIndex = 13;
			this.label6.Text = "Vreme:";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(447, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 26);
			this.label7.TabIndex = 14;
			this.label7.Text = "Ukupna cena:";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(447, 274);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(153, 26);
			this.label8.TabIndex = 15;
			this.label8.Text = "Vreme trajanja:";
			// 
			// txtCena
			// 
			this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCena.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCena.Location = new System.Drawing.Point(655, 221);
			this.txtCena.Name = "txtCena";
			this.txtCena.Size = new System.Drawing.Size(117, 34);
			this.txtCena.TabIndex = 16;
			// 
			// txtVreme
			// 
			this.txtVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtVreme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVreme.Location = new System.Drawing.Point(655, 271);
			this.txtVreme.Name = "txtVreme";
			this.txtVreme.Size = new System.Drawing.Size(117, 34);
			this.txtVreme.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(778, 224);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 26);
			this.label9.TabIndex = 18;
			this.label9.Text = "RSD";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(448, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 26);
			this.label10.TabIndex = 19;
			this.label10.Text = "Musterija:";
			// 
			// cbMusterije
			// 
			this.cbMusterije.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbMusterije.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMusterije.FormattingEnabled = true;
			this.cbMusterije.Location = new System.Drawing.Point(579, 110);
			this.cbMusterije.Name = "cbMusterije";
			this.cbMusterije.Size = new System.Drawing.Size(247, 34);
			this.cbMusterije.TabIndex = 20;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(778, 274);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 26);
			this.label11.TabIndex = 21;
			this.label11.Text = "min";
			// 
			// txtIdTermina
			// 
			this.txtIdTermina.AutoSize = true;
			this.txtIdTermina.Location = new System.Drawing.Point(4, 122);
			this.txtIdTermina.Name = "txtIdTermina";
			this.txtIdTermina.Size = new System.Drawing.Size(0, 16);
			this.txtIdTermina.TabIndex = 22;
			this.txtIdTermina.Visible = false;
			// 
			// UCSingleTermin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtIdTermina);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbMusterije);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtVreme);
			this.Controls.Add(this.txtCena);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSacuvaj);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.minutesCounter);
			this.Controls.Add(this.hoursCounter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.label1);
			this.Name = "UCSingleTermin";
			this.Size = new System.Drawing.Size(981, 743);
			((System.ComponentModel.ISupportInitialize)(this.hoursCounter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.MonthCalendar monthCalendar;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.NumericUpDown hoursCounter;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.NumericUpDown minutesCounter;
		internal System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.Button btnSacuvaj;
		internal System.Windows.Forms.Button btnBack;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox txtCena;
		internal System.Windows.Forms.TextBox txtVreme;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.Label label10;
		internal System.Windows.Forms.ComboBox cbMusterije;
		internal System.Windows.Forms.Label label11;
		internal System.Windows.Forms.ComboBox cbUsluge;
		internal System.Windows.Forms.DataGridView dgvUsluge;
		internal System.Windows.Forms.Button btnDodajUslugu;
		internal System.Windows.Forms.TextBox txtNapomena;
		internal System.Windows.Forms.Label txtIdTermina;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdUsluge;
		private System.Windows.Forms.DataGridViewTextBoxColumn NazivUsluge;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
		private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
	}
}
