namespace PcBuiApp_Client_v1
{
	partial class NavBarLeft
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
			panel1 = new Panel();
			panel2 = new Panel();
			btnDashboard = new Button();
			btn_dexuatcauhinh = new Button();
			btnQuanliDonHang = new Button();
			panel3 = new Panel();
			lbl_hiname = new Label();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackgroundImage = Properties.Resources.maxresdefault;
			panel1.BackgroundImageLayout = ImageLayout.Stretch;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(349, 126);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(lbl_hiname);
			panel2.Controls.Add(panel3);
			panel2.Location = new Point(3, 132);
			panel2.Name = "panel2";
			panel2.Size = new Size(346, 79);
			panel2.TabIndex = 1;
			// 
			// btnDashboard
			// 
			btnDashboard.Location = new Point(2, 211);
			btnDashboard.Name = "btnDashboard";
			btnDashboard.Size = new Size(347, 89);
			btnDashboard.TabIndex = 2;
			btnDashboard.Text = "Dashboard";
			btnDashboard.UseVisualStyleBackColor = true;
			// 
			// btn_dexuatcauhinh
			// 
			btn_dexuatcauhinh.Location = new Point(3, 302);
			btn_dexuatcauhinh.Name = "btn_dexuatcauhinh";
			btn_dexuatcauhinh.Size = new Size(346, 87);
			btn_dexuatcauhinh.TabIndex = 3;
			btn_dexuatcauhinh.Text = "Đề Xuất Cấu Hình";
			btn_dexuatcauhinh.UseVisualStyleBackColor = true;
			// 
			// btnQuanliDonHang
			// 
			btnQuanliDonHang.Location = new Point(2, 390);
			btnQuanliDonHang.Name = "btnQuanliDonHang";
			btnQuanliDonHang.Size = new Size(347, 93);
			btnQuanliDonHang.TabIndex = 4;
			btnQuanliDonHang.Text = "Quản Lí Đơn Hang";
			btnQuanliDonHang.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.BackgroundImage = Properties.Resources._68e1522f2efb26b61a39b1cae39be208__stress_cats;
			panel3.BackgroundImageLayout = ImageLayout.Stretch;
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(86, 79);
			panel3.TabIndex = 0;
			// 
			// lbl_hiname
			// 
			lbl_hiname.AutoSize = true;
			lbl_hiname.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_hiname.Location = new Point(101, 32);
			lbl_hiname.Name = "lbl_hiname";
			lbl_hiname.Size = new Size(46, 21);
			lbl_hiname.TabIndex = 1;
			lbl_hiname.Text = "Hi, ";
			// 
			// NavBarLeft
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnQuanliDonHang);
			Controls.Add(btn_dexuatcauhinh);
			Controls.Add(btnDashboard);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "NavBarLeft";
			Size = new Size(349, 727);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label lbl_hiname;
		private Panel panel3;
		private Button btnDashboard;
		private Button btn_dexuatcauhinh;
		private Button btnQuanliDonHang;
	}
}
