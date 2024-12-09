namespace App.View.QuanLyBaoCaoThongKe
{
    partial class BaoCaoThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.groupBoxDoanhThu = new System.Windows.Forms.GroupBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.btnXuatExcelDoanhThu = new System.Windows.Forms.Button();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.groupBoxSanPham = new System.Windows.Forms.GroupBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnXemSanPham = new System.Windows.Forms.Button();
            this.btnXuatExcelSanPham = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.panelTonKho = new System.Windows.Forms.Panel();
            this.groupBoxTonKho = new System.Windows.Forms.GroupBox();
            this.btnCapNhatTonKho = new System.Windows.Forms.Button();
            this.btnXuatExcelTonKho = new System.Windows.Forms.Button();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.panelDoanhThu.SuspendLayout();
            this.groupBoxDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabSanPham.SuspendLayout();
            this.panelSanPham.SuspendLayout();
            this.groupBoxSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabTonKho.SuspendLayout();
            this.panelTonKho.SuspendLayout();
            this.groupBoxTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabDoanhThu);
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabTonKho);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 628);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.panelDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tabDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(2);
            this.tabDoanhThu.Size = new System.Drawing.Size(1221, 595);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.Controls.Add(this.groupBoxDoanhThu);
            this.panelDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.panelDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoanhThu.Location = new System.Drawing.Point(2, 2);
            this.panelDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(1217, 591);
            this.panelDoanhThu.TabIndex = 0;
            // 
            // groupBoxDoanhThu
            // 
            this.groupBoxDoanhThu.Controls.Add(this.lblNam);
            this.groupBoxDoanhThu.Controls.Add(this.cboNam);
            this.groupBoxDoanhThu.Controls.Add(this.btnXemDoanhThu);
            this.groupBoxDoanhThu.Controls.Add(this.btnXuatExcelDoanhThu);
            this.groupBoxDoanhThu.Location = new System.Drawing.Point(8, 8);
            this.groupBoxDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDoanhThu.Name = "groupBoxDoanhThu";
            this.groupBoxDoanhThu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDoanhThu.Size = new System.Drawing.Size(900, 81);
            this.groupBoxDoanhThu.TabIndex = 0;
            this.groupBoxDoanhThu.TabStop = false;
            this.groupBoxDoanhThu.Text = "Thông tin doanh thu";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(15, 24);
            this.lblNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(41, 19);
            this.lblNam.TabIndex = 0;
            this.lblNam.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.Location = new System.Drawing.Point(75, 23);
            this.cboNam.Margin = new System.Windows.Forms.Padding(2);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(114, 25);
            this.cboNam.TabIndex = 1;
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(202, 20);
            this.btnXemDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(90, 28);
            this.btnXemDoanhThu.TabIndex = 2;
            this.btnXemDoanhThu.Text = "Xem báo cáo";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcelDoanhThu
            // 
            this.btnXuatExcelDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXuatExcelDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelDoanhThu.Location = new System.Drawing.Point(300, 20);
            this.btnXuatExcelDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcelDoanhThu.Name = "btnXuatExcelDoanhThu";
            this.btnXuatExcelDoanhThu.Size = new System.Drawing.Size(90, 28);
            this.btnXuatExcelDoanhThu.TabIndex = 3;
            this.btnXuatExcelDoanhThu.Text = "Xuất Excel";
            this.btnXuatExcelDoanhThu.UseVisualStyleBackColor = false;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 93);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1217, 498);
            this.dgvDoanhThu.TabIndex = 1;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.panelSanPham);
            this.tabSanPham.Location = new System.Drawing.Point(4, 29);
            this.tabSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.tabSanPham.Size = new System.Drawing.Size(1221, 595);
            this.tabSanPham.TabIndex = 1;
            this.tabSanPham.Text = "Sản Phẩm Bán Chạy";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.groupBoxSanPham);
            this.panelSanPham.Controls.Add(this.dgvSanPham);
            this.panelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSanPham.Location = new System.Drawing.Point(2, 2);
            this.panelSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(1217, 591);
            this.panelSanPham.TabIndex = 0;
            // 
            // groupBoxSanPham
            // 
            this.groupBoxSanPham.Controls.Add(this.lblTuNgay);
            this.groupBoxSanPham.Controls.Add(this.dtpStartDate);
            this.groupBoxSanPham.Controls.Add(this.lblDenNgay);
            this.groupBoxSanPham.Controls.Add(this.dtpEndDate);
            this.groupBoxSanPham.Controls.Add(this.btnXemSanPham);
            this.groupBoxSanPham.Controls.Add(this.btnXuatExcelSanPham);
            this.groupBoxSanPham.Location = new System.Drawing.Point(8, 8);
            this.groupBoxSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSanPham.Name = "groupBoxSanPham";
            this.groupBoxSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSanPham.Size = new System.Drawing.Size(900, 81);
            this.groupBoxSanPham.TabIndex = 0;
            this.groupBoxSanPham.TabStop = false;
            this.groupBoxSanPham.Text = "Thông tin sản phẩm";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(15, 24);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(61, 19);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(75, 23);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(114, 25);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(202, 24);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(71, 19);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(262, 23);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(114, 25);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btnXemSanPham
            // 
            this.btnXemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXemSanPham.Location = new System.Drawing.Point(390, 20);
            this.btnXemSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemSanPham.Name = "btnXemSanPham";
            this.btnXemSanPham.Size = new System.Drawing.Size(90, 28);
            this.btnXemSanPham.TabIndex = 4;
            this.btnXemSanPham.Text = "Xem báo cáo";
            this.btnXemSanPham.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcelSanPham
            // 
            this.btnXuatExcelSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXuatExcelSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelSanPham.Location = new System.Drawing.Point(488, 20);
            this.btnXuatExcelSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcelSanPham.Name = "btnXuatExcelSanPham";
            this.btnXuatExcelSanPham.Size = new System.Drawing.Size(90, 28);
            this.btnXuatExcelSanPham.TabIndex = 5;
            this.btnXuatExcelSanPham.Text = "Xuất Excel";
            this.btnXuatExcelSanPham.UseVisualStyleBackColor = false;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSanPham.Location = new System.Drawing.Point(8, 98);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1217, 591);
            this.dgvSanPham.TabIndex = 1;
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.panelTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 29);
            this.tabTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(2);
            this.tabTonKho.Size = new System.Drawing.Size(1221, 595);
            this.tabTonKho.TabIndex = 2;
            this.tabTonKho.Text = "Tồn Kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // panelTonKho
            // 
            this.panelTonKho.Controls.Add(this.groupBoxTonKho);
            this.panelTonKho.Controls.Add(this.dgvTonKho);
            this.panelTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTonKho.Location = new System.Drawing.Point(2, 2);
            this.panelTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.panelTonKho.Name = "panelTonKho";
            this.panelTonKho.Size = new System.Drawing.Size(1217, 591);
            this.panelTonKho.TabIndex = 0;
            // 
            // groupBoxTonKho
            // 
            this.groupBoxTonKho.Controls.Add(this.btnCapNhatTonKho);
            this.groupBoxTonKho.Controls.Add(this.btnXuatExcelTonKho);
            this.groupBoxTonKho.Location = new System.Drawing.Point(8, 8);
            this.groupBoxTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTonKho.Name = "groupBoxTonKho";
            this.groupBoxTonKho.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTonKho.Size = new System.Drawing.Size(900, 81);
            this.groupBoxTonKho.TabIndex = 0;
            this.groupBoxTonKho.TabStop = false;
            this.groupBoxTonKho.Text = "Thông tin tồn kho";
            // 
            // btnCapNhatTonKho
            // 
            this.btnCapNhatTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCapNhatTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatTonKho.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTonKho.Location = new System.Drawing.Point(15, 20);
            this.btnCapNhatTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatTonKho.Name = "btnCapNhatTonKho";
            this.btnCapNhatTonKho.Size = new System.Drawing.Size(90, 28);
            this.btnCapNhatTonKho.TabIndex = 0;
            this.btnCapNhatTonKho.Text = "Xem báo cáo";
            this.btnCapNhatTonKho.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcelTonKho
            // 
            this.btnXuatExcelTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXuatExcelTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelTonKho.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelTonKho.Location = new System.Drawing.Point(112, 20);
            this.btnXuatExcelTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcelTonKho.Name = "btnXuatExcelTonKho";
            this.btnXuatExcelTonKho.Size = new System.Drawing.Size(90, 28);
            this.btnXuatExcelTonKho.TabIndex = 1;
            this.btnXuatExcelTonKho.Text = "Xuất Excel";
            this.btnXuatExcelTonKho.UseVisualStyleBackColor = false;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTonKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTonKho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTonKho.EnableHeadersVisualStyles = false;
            this.dgvTonKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTonKho.Location = new System.Drawing.Point(8, 98);
            this.dgvTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.RowHeadersVisible = false;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.Size = new System.Drawing.Size(1217, 591);
            this.dgvTonKho.TabIndex = 1;
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 628);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaoCaoThongKe";
            this.Text = "Báo Cáo Thống Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.panelDoanhThu.ResumeLayout(false);
            this.groupBoxDoanhThu.ResumeLayout(false);
            this.groupBoxDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabSanPham.ResumeLayout(false);
            this.panelSanPham.ResumeLayout(false);
            this.groupBoxSanPham.ResumeLayout(false);
            this.groupBoxSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            this.panelTonKho.ResumeLayout(false);
            this.groupBoxTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.Panel panelDoanhThu;
        private System.Windows.Forms.Panel panelSanPham;
        private System.Windows.Forms.Panel panelTonKho;
        private System.Windows.Forms.GroupBox groupBoxDoanhThu;
        private System.Windows.Forms.GroupBox groupBoxSanPham;
        private System.Windows.Forms.GroupBox groupBoxTonKho;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Button btnXuatExcelDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Button btnXemSanPham;
        private System.Windows.Forms.Button btnXuatExcelSanPham;
        private System.Windows.Forms.Button btnCapNhatTonKho;
        private System.Windows.Forms.Button btnXuatExcelTonKho;
    }
}