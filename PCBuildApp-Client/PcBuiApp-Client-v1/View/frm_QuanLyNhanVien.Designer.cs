using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyNhanVien
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
            dataGridView_QLNV = new DataGridView();
            Column_ListAccountSTT = new DataGridViewTextBoxColumn();
            Column_ListAccountName = new DataGridViewTextBoxColumn();
            // Thay đổi cột Column_ListAccountAction thành DataGridViewButtonColumn
            // Khởi tạo Column_ListAccountAction
            Column_ListAccountAction = new DataGridViewButtonColumn();
            Column_ListAccountAction.Name = "Column_ListAccountAction";
            Column_ListAccountAction.HeaderText = "Hành Động";
            Column_ListAccountAction.Text = "Sửa/Xóa";
            Column_ListAccountAction.UseColumnTextForButtonValue = true;
            panel1 = new Panel();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Sua.Text = "Sửa";
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa = new Button();
            btn_Xoa.Text = "Xóa";
            btn_Xoa.Click += btn_Xoa_Click;
            this.Controls.Add(btn_Sua);
            this.Controls.Add(btn_Xoa);
            roundedUserControl2.SuspendLayout();
            roundedUserControl3.SuspendLayout();
            roundedUserControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_QLNV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1367, 12);
            btn_CloseLogin.Margin = new Padding(4, 3, 4, 3);
            btn_CloseLogin.Name = "btn_CloseLogin";
            btn_CloseLogin.Size = new Size(34, 27);
            btn_CloseLogin.TabIndex = 12;
            btn_CloseLogin.Text = "X";
            btn_CloseLogin.UseVisualStyleBackColor = true;
            btn_CloseLogin.Click += btn_CloseLogin_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 64);
            panel3.TabIndex = 17;
            // 
            // roundedUserControl2
            // 
            roundedUserControl2.BackColor = Color.White;
            roundedUserControl2.Controls.Add(label2);
            roundedUserControl2.CornerRadius = 20;
            roundedUserControl2.Location = new Point(0, 76);
            roundedUserControl2.Name = "roundedUserControl2";
            roundedUserControl2.Size = new Size(1182, 66);
            roundedUserControl2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(332, 21);
            label2.TabIndex = 0;
            label2.Text = "Quản Lý Tài Khoản \\ Danh Sách Nhân Viên";
            // 
            // roundedUserControl3
            // 
            roundedUserControl3.BackColor = Color.White;
            roundedUserControl3.Controls.Add(textBox1);
            roundedUserControl3.CornerRadius = 20;
            roundedUserControl3.Location = new Point(3, 12);
            roundedUserControl3.Name = "roundedUserControl3";
            roundedUserControl3.Size = new Size(344, 50);
            roundedUserControl3.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 14);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm...";
            textBox1.Size = new Size(334, 22);
            textBox1.TabIndex = 0;
            // 
            // roundedUserControl4
            // 
            roundedUserControl4.BackColor = Color.White;
            roundedUserControl4.Controls.Add(btn_Them);
            roundedUserControl4.Controls.Add(label3);
            roundedUserControl4.Controls.Add(dataGridView_QLNV);
            roundedUserControl4.CornerRadius = 50;
            roundedUserControl4.Location = new Point(1, 169);
            roundedUserControl4.Name = "roundedUserControl4";
            roundedUserControl4.Size = new Size(1181, 667);
            roundedUserControl4.TabIndex = 19;
            // Trong InitializeComponent()

            // Khởi tạo btn_Sua
            btn_Sua = new Button();
            btn_Sua.Text = "Sửa";
            btn_Sua.Size = new Size(75, 30);
            btn_Sua.Location = new Point(850, 21);
            btn_Sua.Click += btn_Sua_Click;

            // Khởi tạo btn_Xoa
            btn_Xoa = new Button();
            btn_Xoa.Text = "Xóa";
            btn_Xoa.Size = new Size(75, 30);
            btn_Xoa.Location = new Point(950, 21);
            btn_Xoa.Click += btn_Xoa_Click;

            // Thêm các nút vào roundedUserControl4 hoặc panel chứa chúng
            roundedUserControl4.Controls.Add(btn_Sua);
            roundedUserControl4.Controls.Add(btn_Xoa);

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 1;
            label3.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView_QLNV
            // 
            dataGridView_QLNV.AllowUserToAddRows = false;
            dataGridView_QLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_QLNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_QLNV.BackgroundColor = Color.White;
            dataGridView_QLNV.BorderStyle = BorderStyle.None;
            dataGridView_QLNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_QLNV.Columns.AddRange(new DataGridViewColumn[] { Column_ListAccountSTT, Column_ListAccountName, Column_ListAccountAction });
            dataGridView_QLNV.Dock = DockStyle.Bottom;
            dataGridView_QLNV.Location = new Point(0, 93);
            dataGridView_QLNV.Name = "dataGridView_QLNV";
            dataGridView_QLNV.RowTemplate.Height = 25;
            dataGridView_QLNV.Size = new Size(1181, 574);
            dataGridView_QLNV.TabIndex = 0;
            dataGridView_QLNV.CellContentClick += dataGridView_QLNV_CellContentClick;
            // 
            // Column_ListAccountSTT
            // 
            Column_ListAccountSTT.FillWeight = 20F;
            Column_ListAccountSTT.HeaderText = "STT";
            Column_ListAccountSTT.Name = "Column_ListAccountSTT";
            // 
            // Column_ListAccountName
            // 
            Column_ListAccountName.HeaderText = "Tên Tài Khoản";
            Column_ListAccountName.Name = "Column_ListAccountName";
            // 
            // Column_ListAccountAction
            // 
            Column_ListAccountAction.HeaderText = "Hành Động";
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 836);
            panel1.TabIndex = 20;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(1047, 21);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(118, 51);
            btn_Them.TabIndex = 2;
            btn_Them.Text = "Thêm Nhân Viên";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // frm_QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1194, 836);
            Controls.Add(btn_CloseLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            roundedUserControl2.ResumeLayout(false);
            roundedUserControl2.PerformLayout();
            roundedUserControl3.ResumeLayout(false);
            roundedUserControl3.PerformLayout();
            roundedUserControl4.ResumeLayout(false);
            roundedUserControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_QLNV).EndInit();
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
        private DataGridView dataGridView_QLNV;
        private DataGridViewTextBoxColumn Column_ListAccountSTT;
        private DataGridViewTextBoxColumn Column_ListAccountName;
        private DataGridViewButtonColumn Column_ListAccountAction;
        private Label label3;
        private Panel panel1;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
    }
}