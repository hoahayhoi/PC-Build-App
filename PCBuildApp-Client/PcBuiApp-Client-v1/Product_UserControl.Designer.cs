namespace PcBuiApp_Client_v1
{
	partial class Product_UserControl
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
			lbl_id = new Label();
			panel2 = new Panel();
			lblTenSp = new Label();
			panel3 = new Panel();
			lblloaiSp = new Label();
			panel4 = new Panel();
			lblGia = new Label();
			panel5 = new Panel();
			btn_xoa = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(192, 192, 255);
			panel1.BorderStyle = BorderStyle.Fixed3D;
			panel1.Controls.Add(lbl_id);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(132, 136);
			panel1.TabIndex = 0;
			// 
			// lbl_id
			// 
			lbl_id.AutoSize = true;
			lbl_id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_id.Location = new Point(-2, 61);
			lbl_id.Name = "lbl_id";
			lbl_id.Size = new Size(25, 20);
			lbl_id.TabIndex = 0;
			lbl_id.Text = "ID";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(192, 192, 255);
			panel2.BorderStyle = BorderStyle.Fixed3D;
			panel2.Controls.Add(lblTenSp);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(132, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(334, 136);
			panel2.TabIndex = 1;
			// 
			// lblTenSp
			// 
			lblTenSp.AutoSize = true;
			lblTenSp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblTenSp.Location = new Point(0, 61);
			lblTenSp.Name = "lblTenSp";
			lblTenSp.Size = new Size(55, 20);
			lblTenSp.TabIndex = 0;
			lblTenSp.Text = "Tên SP";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(192, 192, 255);
			panel3.BorderStyle = BorderStyle.Fixed3D;
			panel3.Controls.Add(lblloaiSp);
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(466, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(244, 136);
			panel3.TabIndex = 2;
			// 
			// lblloaiSp
			// 
			lblloaiSp.AutoSize = true;
			lblloaiSp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblloaiSp.Location = new Point(0, 61);
			lblloaiSp.Name = "lblloaiSp";
			lblloaiSp.Size = new Size(59, 20);
			lblloaiSp.TabIndex = 0;
			lblloaiSp.Text = "Loại SP";
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb(192, 192, 255);
			panel4.BorderStyle = BorderStyle.Fixed3D;
			panel4.Controls.Add(lblGia);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(710, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(172, 136);
			panel4.TabIndex = 3;
			// 
			// lblGia
			// 
			lblGia.AutoSize = true;
			lblGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblGia.Location = new Point(0, 61);
			lblGia.Name = "lblGia";
			lblGia.Size = new Size(32, 20);
			lblGia.TabIndex = 0;
			lblGia.Text = "Giá";
			// 
			// panel5
			// 
			panel5.Controls.Add(btn_xoa);
			panel5.Dock = DockStyle.Left;
			panel5.Location = new Point(882, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(59, 136);
			panel5.TabIndex = 4;
			// 
			// btn_xoa
			// 
			btn_xoa.BackgroundImage = Properties.Resources._1000_F_272554194_9bJhYSJkUcLbTjXfDlDANV2RyQYGO06N;
			btn_xoa.BackgroundImageLayout = ImageLayout.Zoom;
			btn_xoa.Dock = DockStyle.Right;
			btn_xoa.Location = new Point(0, 0);
			btn_xoa.Name = "btn_xoa";
			btn_xoa.Size = new Size(59, 136);
			btn_xoa.TabIndex = 0;
			btn_xoa.UseVisualStyleBackColor = true;
			btn_xoa.Click += btn_xoa_Click;
			// 
			// Product_UserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(panel5);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Product_UserControl";
			Size = new Size(880, 136);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel5.ResumeLayout(false);
			ResumeLayout(false);
		}

		

		#endregion

		private Panel panel1;
		private Label lbl_id;
		private Panel panel2;
		private Label lblTenSp;
		private Panel panel3;
		private Label lblloaiSp;
		private Panel panel4;
		private Label lblGia;
		private Panel panel5;
		private Button btn_xoa;
	}
}
