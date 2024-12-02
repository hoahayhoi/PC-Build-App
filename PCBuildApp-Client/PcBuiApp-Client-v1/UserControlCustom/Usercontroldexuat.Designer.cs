namespace PcBuiApp_Client_v1.UserControlCustom
{
	partial class Usercontroldexuat
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
			labeldexuat = new MaterialSkin.Controls.MaterialLabel();
			labelgiatien = new MaterialSkin.Controls.MaterialLabel();
			SuspendLayout();
			// 
			// labeldexuat
			// 
			labeldexuat.AutoSize = true;
			labeldexuat.Depth = 0;
			labeldexuat.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
			labeldexuat.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			labeldexuat.Location = new Point(19, 35);
			labeldexuat.MouseState = MaterialSkin.MouseState.HOVER;
			labeldexuat.Name = "labeldexuat";
			labeldexuat.Size = new Size(200, 29);
			labeldexuat.TabIndex = 0;
			labeldexuat.Text = "Cấu Hình Đề Xuất: ";
			// 
			// labelgiatien
			// 
			labelgiatien.AutoSize = true;
			labelgiatien.Depth = 0;
			labelgiatien.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			labelgiatien.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
			labelgiatien.Location = new Point(19, 92);
			labelgiatien.MouseState = MaterialSkin.MouseState.HOVER;
			labelgiatien.Name = "labelgiatien";
			labelgiatien.Size = new Size(85, 24);
			labelgiatien.TabIndex = 1;
			labelgiatien.Text = "Giá Tiền: ";
			// 
			// Usercontroldexuat
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(224, 224, 224);
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(labelgiatien);
			Controls.Add(labeldexuat);
			Name = "Usercontroldexuat";
			Size = new Size(1427, 137);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel labeldexuat;
		private MaterialSkin.Controls.MaterialLabel labelgiatien;
	}
}
