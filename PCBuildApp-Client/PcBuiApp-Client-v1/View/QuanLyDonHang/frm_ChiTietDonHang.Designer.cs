// View/QuanLyKho/frm_ThemSanPham.Designer.cs
namespace PcBuiApp_Client_v1.View.QuanLyDonHang
{
    partial class frm_ChiTietDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Các Control
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true nếu managed resources cần được dispose; false nếu không.</param>
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            btn_Thoat = new Button();
            dtpNgayTao = new DateTimePicker();
            dtpNgayHT = new DateTimePicker();
            label4 = new Label();
            cbKTV = new ComboBox();
            cbNVBH = new ComboBox();
            dgv_DSSP = new DataGridView();
            btn_Sua = new Button();
            label2 = new Label();
            txtTongTien = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btn_Cancel = new Button();
            btn_Save = new Button();
            lblSupplier = new Label();
            lblStock = new Label();
            txtKH = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            txtMaDH = new TextBox();
            lblName = new Label();
            txtStatus = new TextBox();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSSP).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.MenuHighlight;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(975, 65);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Đơn Hàng \\ Chi Tiết Đơn Hàng";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(txtStatus);
            panelContent.Controls.Add(btn_Thoat);
            panelContent.Controls.Add(dtpNgayTao);
            panelContent.Controls.Add(dtpNgayHT);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(cbKTV);
            panelContent.Controls.Add(cbNVBH);
            panelContent.Controls.Add(dgv_DSSP);
            panelContent.Controls.Add(btn_Sua);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(txtTongTien);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(btn_Cancel);
            panelContent.Controls.Add(btn_Save);
            panelContent.Controls.Add(lblSupplier);
            panelContent.Controls.Add(lblStock);
            panelContent.Controls.Add(txtKH);
            panelContent.Controls.Add(lblPrice);
            panelContent.Controls.Add(lblCategory);
            panelContent.Controls.Add(txtMaDH);
            panelContent.Controls.Add(lblName);
            panelContent.Location = new Point(12, 83);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(940, 575);
            panelContent.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(765, 183);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(123, 30);
            btn_Thoat.TabIndex = 28;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(170, 57);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(273, 23);
            dtpNgayTao.TabIndex = 27;
            // 
            // dtpNgayHT
            // 
            dtpNgayHT.Location = new Point(170, 98);
            dtpNgayHT.Name = "dtpNgayHT";
            dtpNgayHT.Size = new Size(273, 23);
            dtpNgayHT.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 227);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 25;
            label4.Text = "Danh Sách Sản Phẩm:";
            // 
            // cbKTV
            // 
            cbKTV.FormattingEnabled = true;
            cbKTV.Location = new Point(615, 98);
            cbKTV.Name = "cbKTV";
            cbKTV.Size = new Size(273, 23);
            cbKTV.TabIndex = 22;
            // 
            // cbNVBH
            // 
            cbNVBH.FormattingEnabled = true;
            cbNVBH.Location = new Point(615, 57);
            cbNVBH.Name = "cbNVBH";
            cbNVBH.Size = new Size(273, 23);
            cbNVBH.TabIndex = 21;
            // 
            // dgv_DSSP
            // 
            dgv_DSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSSP.Location = new Point(50, 254);
            dgv_DSSP.Name = "dgv_DSSP";
            dgv_DSSP.RowTemplate.Height = 25;
            dgv_DSSP.Size = new Size(838, 318);
            dgv_DSSP.TabIndex = 20;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(230, 183);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(123, 30);
            btn_Sua.TabIndex = 19;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "Trạng Thái:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(170, 138);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(273, 23);
            txtTongTien.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 141);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 15;
            label3.Text = "Tổng Tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 101);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 12;
            label1.Text = "Kỹ Thuật Viên:";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(592, 183);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(123, 30);
            btn_Cancel.TabIndex = 11;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(412, 183);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(123, 30);
            btn_Save.TabIndex = 10;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(50, 101);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(106, 15);
            lblSupplier.TabIndex = 8;
            lblSupplier.Text = "Ngày Hoàn Thành:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(495, 60);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(89, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Nhân Viên Sale:";
            // 
            // txtKH
            // 
            txtKH.Location = new Point(615, 17);
            txtKH.Name = "txtKH";
            txtKH.Size = new Size(273, 23);
            txtKH.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(495, 20);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(75, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Khách Hàng:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(50, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Ngày Tạo:";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(170, 17);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(273, 23);
            txtMaDH.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Mã Đơn Hàng:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(615, 138);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(273, 23);
            txtStatus.TabIndex = 29;
            // 
            // frm_ChiTietDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 670);
            Controls.Add(panelHeader);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ChiTietDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Sản Phẩm Mới";
            Load += frm_ChiTietDonHang_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSSP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btn_Sua;
        private Label label2;
        private TextBox txtTongTien;
        private Label label3;
        private DataGridView dgv_DSSP;
        private ComboBox cbKTV;
        private ComboBox cbNVBH;
        private Label label4;
        private DateTimePicker dtpNgayTao;
        private DateTimePicker dtpNgayHT;
        private Button btn_Thoat;
        private TextBox txtStatus;
    }
}
