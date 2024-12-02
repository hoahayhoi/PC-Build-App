namespace PcBuiApp_Client_v1.View.DeXuatCauHinh
{
	partial class frm_dexuatcauhinh
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
			panelHeader = new Panel();
			lblTitle = new Label();
			txtGiatien = new TextBox();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			cmbmucdich = new MaterialSkin.Controls.MaterialComboBox();
			btn_dexuat = new MaterialSkin.Controls.MaterialButton();
			roundedUserControl2 = new UserControlCustom.RoundedUserControl();
			label2 = new Label();
			paneldexuat = new Panel();
			panel1 = new Panel();
			paneldexuat1 = new Panel();
			panelHeader.SuspendLayout();
			roundedUserControl2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = SystemColors.MenuHighlight;
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(1075, 87);
			panelHeader.TabIndex = 1;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.ForeColor = Color.White;
			lblTitle.Location = new Point(14, 27);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(225, 33);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Đề Xuất Cấu Hình";
			// 
			// txtGiatien
			// 
			txtGiatien.BackColor = Color.White;
			txtGiatien.BorderStyle = BorderStyle.None;
			txtGiatien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtGiatien.Location = new Point(103, 24);
			txtGiatien.Margin = new Padding(3, 4, 3, 4);
			txtGiatien.Multiline = true;
			txtGiatien.Name = "txtGiatien";
			txtGiatien.PlaceholderText = "Giá Tiền...(đ)";
			txtGiatien.Size = new Size(301, 38);
			txtGiatien.TabIndex = 2;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			materialLabel1.Location = new Point(12, 28);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(85, 24);
			materialLabel1.TabIndex = 3;
			materialLabel1.Text = "Giá Tiền: ";
			// 
			// materialLabel2
			// 
			materialLabel2.AutoSize = true;
			materialLabel2.Depth = 0;
			materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			materialLabel2.Location = new Point(425, 28);
			materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel2.Name = "materialLabel2";
			materialLabel2.Size = new Size(89, 24);
			materialLabel2.TabIndex = 4;
			materialLabel2.Text = "Mục Đích:";
			// 
			// cmbmucdich
			// 
			cmbmucdich.AutoResize = false;
			cmbmucdich.BackColor = Color.FromArgb(255, 255, 255);
			cmbmucdich.Depth = 0;
			cmbmucdich.DisplayMember = " ";
			cmbmucdich.DrawMode = DrawMode.OwnerDrawVariable;
			cmbmucdich.DropDownHeight = 174;
			cmbmucdich.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbmucdich.DropDownWidth = 121;
			cmbmucdich.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
			cmbmucdich.ForeColor = Color.FromArgb(222, 0, 0, 0);
			cmbmucdich.FormattingEnabled = true;
			cmbmucdich.IntegralHeight = false;
			cmbmucdich.ItemHeight = 43;
			cmbmucdich.Items.AddRange(new object[] { "Chơi Game", "Làm Đồ Họa", "Văn Phòng" });
			cmbmucdich.Location = new Point(547, 13);
			cmbmucdich.MaxDropDownItems = 4;
			cmbmucdich.MouseState = MaterialSkin.MouseState.OUT;
			cmbmucdich.Name = "cmbmucdich";
			cmbmucdich.Size = new Size(406, 49);
			cmbmucdich.StartIndex = 0;
			cmbmucdich.TabIndex = 5;
			// 
			// btn_dexuat
			// 
			btn_dexuat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btn_dexuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			btn_dexuat.Depth = 0;
			btn_dexuat.HighEmphasis = true;
			btn_dexuat.Icon = null;
			btn_dexuat.Location = new Point(4, 98);
			btn_dexuat.Margin = new Padding(4, 6, 4, 6);
			btn_dexuat.MouseState = MaterialSkin.MouseState.HOVER;
			btn_dexuat.Name = "btn_dexuat";
			btn_dexuat.NoAccentTextColor = Color.Empty;
			btn_dexuat.Size = new Size(153, 36);
			btn_dexuat.TabIndex = 6;
			btn_dexuat.Text = "Đề Xuất Cấu Hình";
			btn_dexuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			btn_dexuat.UseAccentColor = false;
			btn_dexuat.UseVisualStyleBackColor = true;
			btn_dexuat.Click += btn_dexuat_Click;
			// 
			// roundedUserControl2
			// 
			roundedUserControl2.BackColor = Color.White;
			roundedUserControl2.Controls.Add(label2);
			roundedUserControl2.Controls.Add(paneldexuat);
			roundedUserControl2.CornerRadius = 20;
			roundedUserControl2.Location = new Point(-214, 223);
			roundedUserControl2.Margin = new Padding(3, 4, 3, 4);
			roundedUserControl2.Name = "roundedUserControl2";
			roundedUserControl2.Size = new Size(1351, 38);
			roundedUserControl2.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(228, 4);
			label2.Name = "label2";
			label2.Size = new Size(237, 28);
			label2.TabIndex = 0;
			label2.Text = "Cấu Hình Được Đề Xuất";
			// 
			// paneldexuat
			// 
			paneldexuat.Location = new Point(166, 357);
			paneldexuat.Name = "paneldexuat";
			paneldexuat.Size = new Size(923, 284);
			paneldexuat.TabIndex = 8;
			// 
			// panel1
			// 
			panel1.Controls.Add(cmbmucdich);
			panel1.Controls.Add(materialLabel1);
			panel1.Controls.Add(materialLabel2);
			panel1.Controls.Add(txtGiatien);
			panel1.Controls.Add(btn_dexuat);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 87);
			panel1.Name = "panel1";
			panel1.Size = new Size(1075, 137);
			panel1.TabIndex = 9;
			panel1.Paint += panel1_Paint;
			// 
			// paneldexuat1
			// 
			paneldexuat1.Location = new Point(0, 290);
			paneldexuat1.Name = "paneldexuat1";
			paneldexuat1.Size = new Size(1441, 700);
			paneldexuat1.TabIndex = 10;
			// 
			// frm_dexuatcauhinh
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1075, 555);
			Controls.Add(paneldexuat1);
			Controls.Add(panel1);
			Controls.Add(roundedUserControl2);
			Controls.Add(panelHeader);
			Name = "frm_dexuatcauhinh";
			Text = "frm_dexuatcauhinh";
			Load += frm_dexuatcauhinh_Load;
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			roundedUserControl2.ResumeLayout(false);
			roundedUserControl2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelHeader;
		private Label lblTitle;
		private TextBox txtGiatien;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialComboBox cmbmucdich;
		private MaterialSkin.Controls.MaterialButton btn_dexuat;
		private UserControlCustom.RoundedUserControl roundedUserControl2;
		private Label label2;
		private Panel paneldexuat;
		private Panel panel1;
		private Panel paneldexuat1;
	}
}