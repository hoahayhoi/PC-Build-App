// View/QuanLySanPham/frm_QuanLySanPham.Designer.cs


namespace PcBuiApp_Client_v1.View.QuanLySanPham
{
    partial class frm_QuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Các Control
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panelMain;

        // Các cột cho DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DanhMucSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuongTon;
        private System.Windows.Forms.DataGridViewButtonColumn Column_HanhDongSanPham;

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
            btn_Close = new Button();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panelActions = new Panel();
            btn_Add = new Button();
            dataGridViewProducts = new DataGridView();
            Column_STT = new DataGridViewTextBoxColumn();
            Column_TenSanPham = new DataGridViewTextBoxColumn();
            Column_GiaSanPham = new DataGridViewTextBoxColumn();
            Column_DanhMucSanPham = new DataGridViewTextBoxColumn();
            Column_SoLuongTon = new DataGridViewTextBoxColumn();
            Column_HanhDongSanPham = new DataGridViewButtonColumn();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.Red;
            btn_Close.Location = new Point(1178, 12);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(34, 27);
            btn_Close.TabIndex = 0;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.MenuHighlight;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1222, 65);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(191, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Sản Phẩm";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Location = new Point(0, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(389, 50);
            panelSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(10, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new Size(279, 22);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(300, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btn_Add);
            panelActions.Location = new Point(410, 80);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(200, 50);
            panelActions.TabIndex = 3;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(0, 10);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(200, 30);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Thêm Sản Phẩm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column_STT, Column_TenSanPham, Column_GiaSanPham, Column_DanhMucSanPham, Column_SoLuongTon, Column_HanhDongSanPham });
            dataGridViewProducts.Dock = DockStyle.Left;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(1222, 672);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // Column_STT
            // 
            Column_STT.FillWeight = 20F;
            Column_STT.HeaderText = "STT";
            Column_STT.Name = "Column_STT";
            Column_STT.ReadOnly = true;
            // 
            // Column_TenSanPham
            // 
            Column_TenSanPham.HeaderText = "Tên Sản Phẩm";
            Column_TenSanPham.Name = "Column_TenSanPham";
            Column_TenSanPham.ReadOnly = true;
            // 
            // Column_GiaSanPham
            // 
            Column_GiaSanPham.HeaderText = "Giá Tiền";
            Column_GiaSanPham.Name = "Column_GiaSanPham";
            Column_GiaSanPham.ReadOnly = true;
            // 
            // Column_DanhMucSanPham
            // 
            Column_DanhMucSanPham.HeaderText = "Danh Mục";
            Column_DanhMucSanPham.Name = "Column_DanhMucSanPham";
            Column_DanhMucSanPham.ReadOnly = true;
            // 
            // Column_SoLuongTon
            // 
            Column_SoLuongTon.HeaderText = "Số Lượng Tồn";
            Column_SoLuongTon.Name = "Column_SoLuongTon";
            Column_SoLuongTon.ReadOnly = true;
            // 
            // Column_HanhDongSanPham
            // 
            Column_HanhDongSanPham.HeaderText = "Xóa";
            Column_HanhDongSanPham.Name = "Column_HanhDongSanPham";
            Column_HanhDongSanPham.ReadOnly = true;
            Column_HanhDongSanPham.Text = "Xóa";
            Column_HanhDongSanPham.UseColumnTextForButtonValue = true;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridViewProducts);
            panelMain.Location = new Point(0, 154);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1242, 672);
            panelMain.TabIndex = 4;
            // 
            // frm_QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1222, 836);
            Controls.Add(btn_Close);
            Controls.Add(panelHeader);
            Controls.Add(panelSearch);
            Controls.Add(panelActions);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_QuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sản Phẩm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
