namespace PcBuiApp_Client_v1.UserControlCustom
{
	partial class PCconfig
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
			labelid = new MaterialSkin.Controls.MaterialLabel();
			labelcauhinh = new MaterialSkin.Controls.MaterialLabel();
			SuspendLayout();
			// 
			// labelid
			// 
			labelid.AutoSize = true;
			labelid.Depth = 0;
			labelid.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
			labelid.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			labelid.Location = new Point(3, 32);
			labelid.MouseState = MaterialSkin.MouseState.HOVER;
			labelid.Name = "labelid";
			labelid.Size = new Size(36, 29);
			labelid.TabIndex = 0;
			labelid.Text = "ID: ";
			// 
			// labelcauhinh
			// 
			labelcauhinh.AutoSize = true;
			labelcauhinh.Depth = 0;
			labelcauhinh.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
			labelcauhinh.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			labelcauhinh.Location = new Point(178, 32);
			labelcauhinh.MouseState = MaterialSkin.MouseState.HOVER;
			labelcauhinh.Name = "labelcauhinh";
			labelcauhinh.Size = new Size(104, 29);
			labelcauhinh.TabIndex = 1;
			labelcauhinh.Text = "Cấu Hình:";
			// 
			// PCconfig
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			BackgroundImageLayout = ImageLayout.Stretch;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(labelcauhinh);
			Controls.Add(labelid);
			Name = "PCconfig";
			Size = new Size(1175, 93);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel labelid;
		private MaterialSkin.Controls.MaterialLabel labelcauhinh;
	}
}
