namespace PcBuiApp_Client_v1.View.QuanLyBaoCaoThongKe
{
    partial class frm_BaoCaoThongKe
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
            roundedUserControl2 = new UserControlCustom.RoundedUserControl();
            label2 = new Label();
            roundedUserControl3 = new UserControlCustom.RoundedUserControl();
            textBox_Search = new TextBox();
            panel1 = new Panel();
            roundedUserControl4 = new UserControlCustom.RoundedUserControl();
            label3 = new Label();
            dataGridView_Report = new DataGridView();
            btn_DoanhThuThang = new Button();
            btn_TonKhoSanPham = new Button();
            btn_DonHangTrangThai = new Button();
            btn_BaoCaoBaoHanhThang = new Button();
            btn_NhapHangNhaCungCap = new Button();
            roundedUserControl2.SuspendLayout();
            roundedUserControl3.SuspendLayout();
            panel1.SuspendLayout();
            roundedUserControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Report).BeginInit();
            SuspendLayout();
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1150, 12);
            btn_CloseLogin.Margin = new Padding(4, 3, 4, 3);
            btn_CloseLogin.Name = "btn_CloseLogin";
            btn_CloseLogin.Size = new Size(34, 27);
            btn_CloseLogin.TabIndex = 21;
            btn_CloseLogin.Text = "X";
            btn_CloseLogin.UseVisualStyleBackColor = true;
            // 
            // roundedUserControl2
            // 
            roundedUserControl2.BackColor = Color.White;
            roundedUserControl2.Controls.Add(label2);
            roundedUserControl2.CornerRadius = 20;
            roundedUserControl2.Location = new Point(0, 76);
            roundedUserControl2.Name = "roundedUserControl2";
            roundedUserControl2.Size = new Size(1194, 66);
            roundedUserControl2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(20, 22);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 0;
            label2.Text = "Báo Cáo Thống Kê";
            // 
            // roundedUserControl3
            // 
            roundedUserControl3.BackColor = Color.White;
            roundedUserControl3.Controls.Add(textBox_Search);
            roundedUserControl3.CornerRadius = 20;
            roundedUserControl3.Location = new Point(20, 20);
            roundedUserControl3.Name = "roundedUserControl3";
            roundedUserControl3.Size = new Size(389, 50);
            roundedUserControl3.TabIndex = 1;
            // 
            // textBox_Search
            // 
            textBox_Search.BackColor = Color.White;
            textBox_Search.BorderStyle = BorderStyle.None;
            textBox_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Search.Location = new Point(10, 14);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.PlaceholderText = "Tìm kiếm...";
            textBox_Search.Size = new Size(379, 22);
            textBox_Search.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedUserControl4);
            panel1.Controls.Add(roundedUserControl2);
            panel1.Controls.Add(roundedUserControl3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 836);
            panel1.TabIndex = 22;
            // 
            // roundedUserControl4
            // 
            roundedUserControl4.BackColor = Color.White;
            roundedUserControl4.Controls.Add(label3);
            roundedUserControl4.Controls.Add(dataGridView_Report);
            roundedUserControl4.Controls.Add(btn_DoanhThuThang);
            roundedUserControl4.Controls.Add(btn_TonKhoSanPham);
            roundedUserControl4.Controls.Add(btn_DonHangTrangThai);
            roundedUserControl4.Controls.Add(btn_BaoCaoBaoHanhThang);
            roundedUserControl4.Controls.Add(btn_NhapHangNhaCungCap);
            roundedUserControl4.CornerRadius = 50;
            roundedUserControl4.Location = new Point(0, 161);
            roundedUserControl4.Name = "roundedUserControl4";
            roundedUserControl4.Size = new Size(1174, 655);
            roundedUserControl4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 1;
            label3.Text = "Báo Cáo Thống Kê";
            // 
            // dataGridView_Report
            // 
            dataGridView_Report.AllowUserToAddRows = false;
            dataGridView_Report.AllowUserToDeleteRows = false;
            dataGridView_Report.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Report.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_Report.BackgroundColor = Color.White;
            dataGridView_Report.BorderStyle = BorderStyle.None;
            dataGridView_Report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Report.Location = new Point(20, 80);
            dataGridView_Report.Name = "dataGridView_Report";
            dataGridView_Report.ReadOnly = true;
            dataGridView_Report.RowTemplate.Height = 25;
            dataGridView_Report.Size = new Size(1114, 600);
            dataGridView_Report.TabIndex = 0;
            // 
            // btn_DoanhThuThang
            // 
            btn_DoanhThuThang.Location = new Point(20, 700);
            btn_DoanhThuThang.Name = "btn_DoanhThuThang";
            btn_DoanhThuThang.Size = new Size(150, 40);
            btn_DoanhThuThang.TabIndex = 2;
            btn_DoanhThuThang.Text = "Doanh Thu Tháng";
            btn_DoanhThuThang.UseVisualStyleBackColor = true;
            btn_DoanhThuThang.Click += Btn_DoanhThuThang_Click;
            // 
            // btn_TonKhoSanPham
            // 
            btn_TonKhoSanPham.Location = new Point(200, 700);
            btn_TonKhoSanPham.Name = "btn_TonKhoSanPham";
            btn_TonKhoSanPham.Size = new Size(150, 40);
            btn_TonKhoSanPham.TabIndex = 3;
            btn_TonKhoSanPham.Text = "Tồn Kho Sản Phẩm";
            btn_TonKhoSanPham.UseVisualStyleBackColor = true;
            btn_TonKhoSanPham.Click += Btn_TonKhoSanPham_Click;
            // 
            // btn_DonHangTrangThai
            // 
            btn_DonHangTrangThai.Location = new Point(380, 700);
            btn_DonHangTrangThai.Name = "btn_DonHangTrangThai";
            btn_DonHangTrangThai.Size = new Size(150, 40);
            btn_DonHangTrangThai.TabIndex = 4;
            btn_DonHangTrangThai.Text = "Đơn Hàng Trạng Thái";
            btn_DonHangTrangThai.UseVisualStyleBackColor = true;
            btn_DonHangTrangThai.Click += Btn_DonHangTrangThai_Click;
            // 
            // btn_BaoCaoBaoHanhThang
            // 
            btn_BaoCaoBaoHanhThang.Location = new Point(560, 700);
            btn_BaoCaoBaoHanhThang.Name = "btn_BaoCaoBaoHanhThang";
            btn_BaoCaoBaoHanhThang.Size = new Size(200, 40);
            btn_BaoCaoBaoHanhThang.TabIndex = 5;
            btn_BaoCaoBaoHanhThang.Text = "Báo Cáo Bảo Hành Tháng";
            btn_BaoCaoBaoHanhThang.UseVisualStyleBackColor = true;
            btn_BaoCaoBaoHanhThang.Click += Btn_BaoCaoBaoHanhThang_Click;
            // 
            // btn_NhapHangNhaCungCap
            // 
            btn_NhapHangNhaCungCap.Location = new Point(780, 700);
            btn_NhapHangNhaCungCap.Name = "btn_NhapHangNhaCungCap";
            btn_NhapHangNhaCungCap.Size = new Size(200, 40);
            btn_NhapHangNhaCungCap.TabIndex = 6;
            btn_NhapHangNhaCungCap.Text = "Nhập Hàng Nhà Cung Cấp";
            btn_NhapHangNhaCungCap.UseVisualStyleBackColor = true;
            btn_NhapHangNhaCungCap.Click += Btn_NhapHangNhaCungCap_Click;
            // 
            // frm_BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 836);
            Controls.Add(btn_CloseLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_BaoCaoThongKe";
            Text = "frm_BaoCaoThongKe";
            roundedUserControl2.ResumeLayout(false);
            roundedUserControl2.PerformLayout();
            roundedUserControl3.ResumeLayout(false);
            roundedUserControl3.PerformLayout();
            panel1.ResumeLayout(false);
            roundedUserControl4.ResumeLayout(false);
            roundedUserControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Report).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_CloseLogin;
        private UserControlCustom.RoundedUserControl roundedUserControl2;
        private System.Windows.Forms.Label label2;
        private UserControlCustom.RoundedUserControl roundedUserControl3;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel1;
        private UserControlCustom.RoundedUserControl roundedUserControl4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Report;
        private System.Windows.Forms.Button btn_DoanhThuThang;
        private System.Windows.Forms.Button btn_TonKhoSanPham;
        private System.Windows.Forms.Button btn_DonHangTrangThai;
        private System.Windows.Forms.Button btn_BaoCaoBaoHanhThang;
        private System.Windows.Forms.Button btn_NhapHangNhaCungCap;
    }
}
