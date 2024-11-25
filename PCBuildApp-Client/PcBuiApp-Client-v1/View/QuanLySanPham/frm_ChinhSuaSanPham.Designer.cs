// View/QuanLySanPham/frm_ChinhSuaSanPham.Designer.cs
namespace PcBuiApp_Client_v1.View.QuanLySanPham
{
    partial class frm_ChinhSuaSanPham
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 65);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(412, 25);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý Sản Phẩm \\ Chỉnh Sửa Sản Phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStock);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(btn_Cancel);
            panel2.Controls.Add(btn_Save);
            panel2.Location = new Point(14, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 310);
            panel2.TabIndex = 17;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(503, 87);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(83, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Số Lượng Tồn:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(623, 84);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(273, 23);
            txtStock.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(503, 47);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Giá Tiền:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(623, 44);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 23);
            txtPrice.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(62, 84);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Danh Mục:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "CPU", "GPU", "RAM", "Mainboard", "Storage", "Laptop" });
            cmbCategory.Location = new Point(182, 81);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(273, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(62, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Tên Sản Phẩm:";
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 23);
            txtName.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(587, 171);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(123, 30);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click_1;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(267, 171);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(123, 30);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click_1;
            // 
            // frm_ChinhSuaSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 423);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ChinhSuaSanPham";
            Text = "frm_ChinhSuaSanPham";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}
