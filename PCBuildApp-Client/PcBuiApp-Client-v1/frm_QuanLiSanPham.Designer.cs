namespace PcBuiApp_Client_v1
{
	partial class frm_QuanLiSanPham
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			navBarLeft1 = new NavBarLeft();
			panelProductShow = new Panel();
			panel2 = new Panel();
			txtSearch = new TextBox();
			btnSearch = new Button();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// navBarLeft1
			// 
			navBarLeft1.Dock = DockStyle.Left;
			navBarLeft1.Location = new Point(0, 0);
			navBarLeft1.Name = "navBarLeft1";
			navBarLeft1.Size = new Size(355, 791);
			navBarLeft1.TabIndex = 0;
			// 
			// panelProductShow
			// 
			panelProductShow.Dock = DockStyle.Bottom;
			panelProductShow.Location = new Point(355, 145);
			panelProductShow.Name = "panelProductShow";
			panelProductShow.Size = new Size(1054, 646);
			panelProductShow.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnSearch);
			panel2.Controls.Add(txtSearch);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(355, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1054, 125);
			panel2.TabIndex = 2;
			// 
			// txtSearch
			// 
			txtSearch.BorderStyle = BorderStyle.None;
			txtSearch.Location = new Point(166, 12);
			txtSearch.Multiline = true;
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(611, 59);
			txtSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(800, 12);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(122, 59);
			btnSearch.TabIndex = 1;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// frm_QuanLiSanPham
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1409, 791);
			Controls.Add(panel2);
			Controls.Add(panelProductShow);
			Controls.Add(navBarLeft1);
			Name = "frm_QuanLiSanPham";
			Text = "Form1";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private NavBarLeft navBarLeft1;
		private Panel panelProductShow;
		private Panel panel2;
		private Button btnSearch;
		private TextBox txtSearch;
	}
}