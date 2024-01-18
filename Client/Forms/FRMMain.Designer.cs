namespace Client
{
	partial class FRMMain
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FrizerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dodajFrizeraItem = new System.Windows.Forms.ToolStripMenuItem();
			this.izmeniFrizeraItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UslugaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dodajUsluguItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pretraziUslugeItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrizerMenuItem,
            this.UslugaMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(758, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FrizerMenuItem
			// 
			this.FrizerMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFrizeraItem,
            this.izmeniFrizeraItem});
			this.FrizerMenuItem.Name = "FrizerMenuItem";
			this.FrizerMenuItem.Size = new System.Drawing.Size(59, 24);
			this.FrizerMenuItem.Text = "Frizer";
			// 
			// dodajFrizeraItem
			// 
			this.dodajFrizeraItem.Name = "dodajFrizeraItem";
			this.dodajFrizeraItem.Size = new System.Drawing.Size(182, 26);
			this.dodajFrizeraItem.Text = "Dodaj frizera";
			// 
			// izmeniFrizeraItem
			// 
			this.izmeniFrizeraItem.Name = "izmeniFrizeraItem";
			this.izmeniFrizeraItem.Size = new System.Drawing.Size(182, 26);
			this.izmeniFrizeraItem.Text = "Izmeni frizera";
			// 
			// UslugaMenuItem
			// 
			this.UslugaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsluguItem,
            this.pretraziUslugeItem});
			this.UslugaMenuItem.Name = "UslugaMenuItem";
			this.UslugaMenuItem.Size = new System.Drawing.Size(68, 24);
			this.UslugaMenuItem.Text = "Usluga";
			// 
			// dodajUsluguItem
			// 
			this.dodajUsluguItem.Name = "dodajUsluguItem";
			this.dodajUsluguItem.Size = new System.Drawing.Size(224, 26);
			this.dodajUsluguItem.Text = "Dodaj uslugu";
			// 
			// pnlMain
			// 
			this.pnlMain.AutoSize = true;
			this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 28);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(758, 488);
			this.pnlMain.TabIndex = 1;
			// 
			// pretraziUslugeItem
			// 
			this.pretraziUslugeItem.Name = "pretraziUslugeItem";
			this.pretraziUslugeItem.Size = new System.Drawing.Size(224, 26);
			this.pretraziUslugeItem.Text = "Pretrazi usluge";
			// 
			// FRMMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 516);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FRMMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FrizerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dodajFrizeraItem;
		private System.Windows.Forms.ToolStripMenuItem izmeniFrizeraItem;
		internal System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ToolStripMenuItem UslugaMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dodajUsluguItem;
		private System.Windows.Forms.ToolStripMenuItem pretraziUslugeItem;
	}
}

