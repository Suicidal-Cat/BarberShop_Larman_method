namespace Client.UserControls
{
	partial class UCIzmeniFrizera
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dgvFrizer = new System.Windows.Forms.DataGridView();
			this.IdFrizera = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFrizer)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unesite ime frizera za pretragu:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(397, 175);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(219, 34);
			this.txtSearch.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSearch.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.Sienna;
			this.btnSearch.Location = new System.Drawing.Point(655, 169);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(147, 48);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Pretrazi";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// dgvFrizer
			// 
			this.dgvFrizer.AllowUserToAddRows = false;
			this.dgvFrizer.AllowUserToDeleteRows = false;
			this.dgvFrizer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvFrizer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFrizer.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFrizer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFrizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFrizer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFrizera,
            this.Ime,
            this.Prezime,
            this.Status});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Sienna;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFrizer.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFrizer.GridColor = System.Drawing.Color.BlanchedAlmond;
			this.dgvFrizer.Location = new System.Drawing.Point(86, 232);
			this.dgvFrizer.MultiSelect = false;
			this.dgvFrizer.Name = "dgvFrizer";
			this.dgvFrizer.ReadOnly = true;
			this.dgvFrizer.RowHeadersWidth = 51;
			this.dgvFrizer.RowTemplate.Height = 24;
			this.dgvFrizer.Size = new System.Drawing.Size(716, 231);
			this.dgvFrizer.TabIndex = 3;
			// 
			// IdFrizera
			// 
			this.IdFrizera.HeaderText = "IdFrizera";
			this.IdFrizera.MinimumWidth = 6;
			this.IdFrizera.Name = "IdFrizera";
			this.IdFrizera.ReadOnly = true;
			this.IdFrizera.Visible = false;
			// 
			// Ime
			// 
			this.Ime.HeaderText = "Ime";
			this.Ime.MinimumWidth = 6;
			this.Ime.Name = "Ime";
			this.Ime.ReadOnly = true;
			// 
			// Prezime
			// 
			this.Prezime.HeaderText = "Prezime";
			this.Prezime.MinimumWidth = 6;
			this.Prezime.Name = "Prezime";
			this.Prezime.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Sienna;
			this.label2.Location = new System.Drawing.Point(15, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(241, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "Pretraga frizera";
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEdit.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.Sienna;
			this.btnEdit.Location = new System.Drawing.Point(561, 481);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(241, 60);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Izmeni frizera";
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.Sienna;
			this.btnBack.Location = new System.Drawing.Point(86, 481);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(172, 60);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// UCIzmeniFrizera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvFrizer);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Name = "UCIzmeniFrizera";
			this.Size = new System.Drawing.Size(875, 554);
			((System.ComponentModel.ISupportInitialize)(this.dgvFrizer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdFrizera;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtSearch;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.DataGridView dgvFrizer;
		internal System.Windows.Forms.Button btnEdit;
		internal System.Windows.Forms.Button btnBack;
	}
}
