namespace PcBuiApp_Client_v1.View
{
	partial class frm_DeXuatCauHinh
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
			btn_CloseLogin = new Button();
			panel3 = new Panel();
			roundedUserControl2 = new UserControlCustom.RoundedUserControl();
			label2 = new Label();
			roundedUserControl3 = new UserControlCustom.RoundedUserControl();
			textBox1 = new TextBox();
			roundedUserControl4 = new UserControlCustom.RoundedUserControl();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			Column_ListAccountSTT = new DataGridViewTextBoxColumn();
			Column_ListAccountName = new DataGridViewTextBoxColumn();
			Column_ListAccountAction = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			roundedUserControl2.SuspendLayout();
			roundedUserControl3.SuspendLayout();
			roundedUserControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// btn_CloseLogin
			// 
			btn_CloseLogin.Location = new Point(1562, 16);
			btn_CloseLogin.Margin = new Padding(5, 4, 5, 4);
			btn_CloseLogin.Name = "btn_CloseLogin";
			btn_CloseLogin.Size = new Size(39, 36);
			btn_CloseLogin.TabIndex = 12;
			btn_CloseLogin.Text = "X";
			btn_CloseLogin.UseVisualStyleBackColor = true;
			btn_CloseLogin.Click += btn_CloseLogin_Click;
			// 
			// panel3
			// 
			panel3.Location = new Point(3, 101);
			panel3.Margin = new Padding(3, 4, 3, 4);
			panel3.Name = "panel3";
			panel3.Size = new Size(1161, 85);
			panel3.TabIndex = 17;
			// 
			// roundedUserControl2
			// 
			roundedUserControl2.BackColor = Color.White;
			roundedUserControl2.Controls.Add(label2);
			roundedUserControl2.CornerRadius = 20;
			roundedUserControl2.Location = new Point(0, 101);
			roundedUserControl2.Margin = new Padding(3, 4, 3, 4);
			roundedUserControl2.Name = "roundedUserControl2";
			roundedUserControl2.Size = new Size(1351, 88);
			roundedUserControl2.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(7, 28);
			label2.Name = "label2";
			label2.Size = new Size(180, 28);
			label2.TabIndex = 0;
			label2.Text = "Đề Xuất Cấu Hình";
			// 
			// roundedUserControl3
			// 
			roundedUserControl3.BackColor = Color.White;
			roundedUserControl3.Controls.Add(textBox1);
			roundedUserControl3.CornerRadius = 20;
			roundedUserControl3.Location = new Point(3, 16);
			roundedUserControl3.Margin = new Padding(3, 4, 3, 4);
			roundedUserControl3.Name = "roundedUserControl3";
			roundedUserControl3.Size = new Size(445, 67);
			roundedUserControl3.TabIndex = 18;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.White;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(11, 19);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Tìm kiếm...";
			textBox1.Size = new Size(433, 27);
			textBox1.TabIndex = 0;
			// 
			// roundedUserControl4
			// 
			roundedUserControl4.BackColor = Color.White;
			roundedUserControl4.Controls.Add(label3);
			roundedUserControl4.Controls.Add(dataGridView1);
			roundedUserControl4.CornerRadius = 50;
			roundedUserControl4.Location = new Point(1, 225);
			roundedUserControl4.Margin = new Padding(3, 4, 3, 4);
			roundedUserControl4.Name = "roundedUserControl4";
			roundedUserControl4.Size = new Size(1350, 889);
			roundedUserControl4.TabIndex = 19;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaption;
			label3.Location = new Point(14, 45);
			label3.Name = "label3";
			label3.Size = new Size(180, 28);
			label3.TabIndex = 1;
			label3.Text = "Cấu Hình Đề Xuất";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_ListAccountSTT, Column_ListAccountName, Column_ListAccountAction });
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 116);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1350, 773);
			dataGridView1.TabIndex = 0;
			// 
			// Column_ListAccountSTT
			// 
			Column_ListAccountSTT.FillWeight = 20F;
			Column_ListAccountSTT.HeaderText = "STT";
			Column_ListAccountSTT.MinimumWidth = 6;
			Column_ListAccountSTT.Name = "Column_ListAccountSTT";
			// 
			// Column_ListAccountName
			// 
			Column_ListAccountName.HeaderText = "Tên Hàng Hóa";
			Column_ListAccountName.MinimumWidth = 6;
			Column_ListAccountName.Name = "Column_ListAccountName";
			// 
			// Column_ListAccountAction
			// 
			Column_ListAccountAction.HeaderText = "Hành Động";
			Column_ListAccountAction.MinimumWidth = 6;
			Column_ListAccountAction.Name = "Column_ListAccountAction";
			// 
			// panel1
			// 
			panel1.Controls.Add(roundedUserControl4);
			panel1.Controls.Add(roundedUserControl2);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(roundedUserControl3);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1365, 1102);
			panel1.TabIndex = 20;
			// 
			// frm_DeXuatCauHinh
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(1365, 1102);
			Controls.Add(btn_CloseLogin);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(5, 4, 5, 4);
			Name = "frm_DeXuatCauHinh";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			roundedUserControl2.ResumeLayout(false);
			roundedUserControl2.PerformLayout();
			roundedUserControl3.ResumeLayout(false);
			roundedUserControl3.PerformLayout();
			roundedUserControl4.ResumeLayout(false);
			roundedUserControl4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Button btn_CloseLogin;
		private Panel panel3;
		private UserControlCustom.RoundedUserControl roundedUserControl2;
		private UserControlCustom.RoundedUserControl roundedUserControl3;
		private Label label2;
		private TextBox textBox1;
		private UserControlCustom.RoundedUserControl roundedUserControl4;
		private DataGridView dataGridView1;
		private Label label3;
		private Panel panel1;
		private DataGridViewTextBoxColumn Column_ListAccountSTT;
		private DataGridViewTextBoxColumn Column_ListAccountName;
		private DataGridViewTextBoxColumn Column_ListAccountAction;
	}
}