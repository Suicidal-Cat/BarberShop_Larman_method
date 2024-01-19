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
			this.listbUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listbUsluge.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listbUsluge.FormattingEnabled = true;
			this.listbUsluge.ItemHeight = 28;
			this.listbUsluge.Location = new System.Drawing.Point(77, 181);
			this.listbUsluge.Name = "listbUsluge";
			this.listbUsluge.Size = new System.Drawing.Size(294, 312);
			this.listbUsluge.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Unesite ime usluge za pretragu:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(77, 133);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(294, 35);
			this.txtSearch.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(393, 130);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(148, 41);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Pretrazi";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnShow
			// 
			this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.Location = new System.Drawing.Point(393, 200);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(148, 65);
			this.btnShow.TabIndex = 4;
			this.btnShow.Text = "Prikazi detalje";
			this.btnShow.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(393, 301);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(148, 52);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Izmeni";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(393, 395);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(148, 52);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Izbrisi";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(77, 499);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(148, 52);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Nazad";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(71, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(237, 32);
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
			this.Size = new System.Drawing.Size(615, 569);
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
