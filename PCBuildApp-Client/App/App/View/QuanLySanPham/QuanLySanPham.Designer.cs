using System.Windows.Forms;

namespace App.View.QuanLySanPham
{
    partial class QuanLySanPham
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_XoaSanPham = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.btn_SuaSanPham = new System.Windows.Forms.Button();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.dataGridView_Components = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThemImage = new System.Windows.Forms.Button();
            this.textBox_ImagePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txt_IdProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_NameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Components)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1341, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Hello, Admin";
            // 
            // btn_XoaSanPham
            // 
            this.btn_XoaSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSanPham.Location = new System.Drawing.Point(1196, 640);
            this.btn_XoaSanPham.Name = "btn_XoaSanPham";
            this.btn_XoaSanPham.Size = new System.Drawing.Size(133, 26);
            this.btn_XoaSanPham.TabIndex = 42;
            this.btn_XoaSanPham.Text = "Xoá";
            this.btn_XoaSanPham.UseVisualStyleBackColor = true;
            this.btn_XoaSanPham.Click += new System.EventHandler(this.btn_XoaSanPham_Click);
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhap.Location = new System.Drawing.Point(273, 465);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(133, 26);
            this.btn_CapNhap.TabIndex = 41;
            this.btn_CapNhap.Text = "Làm mới";
            this.btn_CapNhap.UseVisualStyleBackColor = true;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // btn_SuaSanPham
            // 
            this.btn_SuaSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSanPham.Location = new System.Drawing.Point(133, 465);
            this.btn_SuaSanPham.Name = "btn_SuaSanPham";
            this.btn_SuaSanPham.Size = new System.Drawing.Size(133, 26);
            this.btn_SuaSanPham.TabIndex = 40;
            this.btn_SuaSanPham.Text = "Cập nhật";
            this.btn_SuaSanPham.UseVisualStyleBackColor = true;
            this.btn_SuaSanPham.Click += new System.EventHandler(this.btn_SuaSanPham_Click);
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSanPham.Location = new System.Drawing.Point(6, 465);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(121, 26);
            this.btn_ThemSanPham.TabIndex = 39;
            this.btn_ThemSanPham.Text = "Thêm";
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // dataGridView_Components
            // 
            this.dataGridView_Components.AllowUserToAddRows = false;
            this.dataGridView_Components.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Components.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Components.Location = new System.Drawing.Point(443, 110);
            this.dataGridView_Components.Name = "dataGridView_Components";
            this.dataGridView_Components.RowHeadersWidth = 51;
            this.dataGridView_Components.Size = new System.Drawing.Size(886, 512);
            this.dataGridView_Components.TabIndex = 38;
            this.dataGridView_Components.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Components_CellContentClick);
            this.dataGridView_Components.SelectionChanged += new System.EventHandler(this.dataGridView_Components_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThemImage);
            this.groupBox1.Controls.Add(this.textBox_ImagePath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_CapNhap);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.btn_SuaSanPham);
            this.groupBox1.Controls.Add(this.txt_IdProduct);
            this.groupBox1.Controls.Add(this.btn_ThemSanPham);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_NameProduct);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 519);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sản Phẩm";
            // 
            // btn_ThemImage
            // 
            this.btn_ThemImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemImage.Location = new System.Drawing.Point(359, 411);
            this.btn_ThemImage.Name = "btn_ThemImage";
            this.btn_ThemImage.Size = new System.Drawing.Size(35, 26);
            this.btn_ThemImage.TabIndex = 42;
            this.btn_ThemImage.Text = "...";
            this.btn_ThemImage.UseVisualStyleBackColor = true;
            this.btn_ThemImage.Click += new System.EventHandler(this.btn_ThemImage_Click);
            // 
            // textBox_ImagePath
            // 
            this.textBox_ImagePath.Location = new System.Drawing.Point(151, 410);
            this.textBox_ImagePath.Name = "textBox_ImagePath";
            this.textBox_ImagePath.Size = new System.Drawing.Size(200, 27);
            this.textBox_ImagePath.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hình Ảnh : ";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(151, 268);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(243, 27);
            this.cboCategory.TabIndex = 10;
            // 
            // txt_IdProduct
            // 
            this.txt_IdProduct.Location = new System.Drawing.Point(151, 50);
            this.txt_IdProduct.Name = "txt_IdProduct";
            this.txt_IdProduct.ReadOnly = true;
            this.txt_IdProduct.Size = new System.Drawing.Size(243, 27);
            this.txt_IdProduct.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id : ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(151, 342);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(243, 27);
            this.textBoxAddress.TabIndex = 7;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(151, 194);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(243, 27);
            this.txt_Price.TabIndex = 5;
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.Location = new System.Drawing.Point(151, 118);
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.Size = new System.Drawing.Size(243, 27);
            this.txt_NameProduct.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tồn Kho : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh Mục:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quản lý Sản Phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1045, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = true;
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(1161, 32);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(133, 26);
            this.btn_Thoat.TabIndex = 44;
            this.btn_Thoat.Text = "Thoát ";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 691);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_XoaSanPham);
            this.Controls.Add(this.dataGridView_Components);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "QuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Components)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_XoaSanPham;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Button btn_SuaSanPham;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.DataGridView dataGridView_Components;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_IdProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_NameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox txtSearch;
        private ComboBox cboCategory;
        private TextBox textBox_ImagePath;
        private Label label7;
        private Button btn_ThemImage;
        private Button btn_Thoat;
    }
}

