namespace Client.UserControls.UCUsluga
{
	partial class UCSearchUsluga
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
			this.listbUsluge = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listbUsluge
			// 
			this.listbUsluge.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.listbUsluge.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.listbUsluge.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listbUsluge.ForeColor = System.Drawing.Color.Sienna;
			this.listbUsluge.FormattingEnabled = true;
			this.listbUsluge.ItemHeight = 31;
			this.listbUsluge.Location = new System.Drawing.Point(82, 241);
			this.listbUsluge.Name = "listbUsluge";
			this.listbUsluge.Size = new System.Drawing.Size(376, 283);
			this.listbUsluge.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Unesite ime usluge za pretragu:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(82, 193);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(376, 34);
			this.txtSearch.TabIndex = 2;
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
			this.btnSearch.Location = new System.Drawing.Point(489, 193);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(266, 41);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Pretrazi";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// btnShow
			// 
			this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnShow.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.ForeColor = System.Drawing.Color.Sienna;
			this.btnShow.Location = new System.Drawing.Point(489, 269);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(266, 53);
			this.btnShow.TabIndex = 4;
			this.btnShow.Text = "Prikazi detalje";
			this.btnShow.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEdit.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.Sienna;
			this.btnEdit.Location = new System.Drawing.Point(489, 361);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(266, 52);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Izmeni";
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.Sienna;
			this.btnDelete.Location = new System.Drawing.Point(489, 455);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(266, 52);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Izbrisi";
			this.btnDelete.UseVisualStyleBackColor = false;
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
			this.btnBack.Location = new System.Drawing.Point(98, 542);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(148, 52);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Sienna;
			this.label2.Location = new System.Drawing.Point(15, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(293, 40);
			this.label2.TabIndex = 8;
			this.label2.Text = "Pretrazivanje usluga";
			// 
			// UCSearchUsluga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listbUsluge);
			this.Name = "UCSearchUsluga";
			this.Size = new System.Drawing.Size(808, 620);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.ListBox listbUsluge;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox txtSearch;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Button btnShow;
		internal System.Windows.Forms.Button btnEdit;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnBack;
		internal System.Windows.Forms.Label label2;
	}
}
