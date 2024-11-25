// View/QuanLyKho/frm_ThemSanPham.Designer.cs
namespace PcBuiApp_Client_v1.View.QuanLyKho
{
    partial class frm_ThemSanPham
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(975, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Kho \\ Thêm Sản Phẩm Mới Vào Kho";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.btn_Cancel);
            this.panelContent.Controls.Add(this.btn_Save);
            this.panelContent.Controls.Add(this.txtSupplier);
            this.panelContent.Controls.Add(this.lblSupplier);
            this.panelContent.Controls.Add(this.txtStock);
            this.panelContent.Controls.Add(this.lblStock);
            this.panelContent.Controls.Add(this.txtPrice);
            this.panelContent.Controls.Add(this.lblPrice);
            this.panelContent.Controls.Add(this.cmbCategory);
            this.panelContent.Controls.Add(this.lblCategory);
            this.panelContent.Controls.Add(this.txtName);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Location = new System.Drawing.Point(12, 83);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(940, 310);
            this.panelContent.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên Sản Phẩm:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 84);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 15);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Danh Mục:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "RAM",
            "Mainboard",
            "Storage",
            "Laptop"});
            this.cmbCategory.Location = new System.Drawing.Point(182, 81);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(273, 23);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(507, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá Tiền:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(627, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(273, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(507, 89);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(83, 15);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Số Lượng Tồn:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(627, 86);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(273, 23);
            this.txtStock.TabIndex = 7;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(62, 130);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(114, 15);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "ID Nhà Cung Cấp:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(182, 127);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(273, 23);
            this.txtSupplier.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(296, 161);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 30);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(529, 161);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 30);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 417);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sản Phẩm Mới";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
