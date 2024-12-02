namespace PcBuiApp_Client_v1.View.TrangChu
{
	partial class frm_Main
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
			panel1 = new Panel();
			label1 = new Label();
			panelMain = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.MenuHighlight;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1186, 87);
			panel1.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(14, 27);
			label1.Name = "label1";
			label1.Size = new Size(139, 33);
			label1.TabIndex = 14;
			label1.Text = "Trang Chủ";
			label1.Click += label1_Click;
			// 
			// panelMain
			// 
			panelMain.AutoScroll = true;
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(0, 87);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(1186, 510);
			panelMain.TabIndex = 16;
			// 
			// frm_Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1186, 597);
			Controls.Add(panelMain);
			Controls.Add(panel1);
			Name = "frm_Main";
			Text = "frm_Main";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panelMain;
	}
}