using System;
using System.Windows.Forms;

namespace App.View.QuanLyKho
{
    partial class QuanLyKho
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvInventory;
        private Button btnLoadInventory;
        private Button btnImport;
        private Button btnExport;
        private TextBox txtQuantity;
        private TextBox txtNote;
        private ComboBox cbComponent;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label lblQuantity;
        private Label lblNote;
        private Label lblComponent;
        private Label lblFromDate;
        private Label lblToDate;
        private GroupBox groupBoxInventory;
        private GroupBox groupBoxActions;
        private GroupBox groupBoxFilters;

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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnLoadInventory = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cbComponent = new System.Windows.Forms.ComboBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblComponent = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngLắpRápToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SearchKho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.groupBoxInventory.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(3, 16);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(850, 452);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick_1);
            // 
            // btnLoadInventory
            // 
            this.btnLoadInventory.Location = new System.Drawing.Point(30, 35);
            this.btnLoadInventory.Name = "btnLoadInventory";
            this.btnLoadInventory.Size = new System.Drawing.Size(100, 30);
            this.btnLoadInventory.TabIndex = 2;
            this.btnLoadInventory.Text = "Load Inventory";
            this.btnLoadInventory.UseVisualStyleBackColor = true;
            this.btnLoadInventory.Click += new System.EventHandler(this.btnLoadInventory_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(160, 35);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 30);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(290, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 76);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(120, 120);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 20);
            this.txtNote.TabIndex = 8;
            // 
            // cbComponent
            // 
            this.cbComponent.FormattingEnabled = true;
            this.cbComponent.Location = new System.Drawing.Point(120, 30);
            this.cbComponent.Name = "cbComponent";
            this.cbComponent.Size = new System.Drawing.Size(200, 21);
            this.cbComponent.TabIndex = 10;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(120, 162);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 12;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(120, 192);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 14;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 76);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(20, 120);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Note:";
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Location = new System.Drawing.Point(20, 30);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(64, 13);
            this.lblComponent.TabIndex = 11;
            this.lblComponent.Text = "Component:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(20, 162);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 13;
            this.lblFromDate.Text = "From Date:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(20, 192);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 13);
            this.lblToDate.TabIndex = 15;
            this.lblToDate.Text = "To Date:";
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Controls.Add(this.dgvInventory);
            this.groupBoxInventory.Location = new System.Drawing.Point(431, 121);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(856, 471);
            this.groupBoxInventory.TabIndex = 1;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Inventory List";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnLoadInventory);
            this.groupBoxActions.Controls.Add(this.btnImport);
            this.groupBoxActions.Controls.Add(this.btnExport);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 436);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(413, 80);
            this.groupBoxActions.TabIndex = 5;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.lblQuantity);
            this.groupBoxFilters.Controls.Add(this.txtQuantity);
            this.groupBoxFilters.Controls.Add(this.lblComponent);
            this.groupBoxFilters.Controls.Add(this.cbComponent);
            this.groupBoxFilters.Controls.Add(this.lblFromDate);
            this.groupBoxFilters.Controls.Add(this.dtpFromDate);
            this.groupBoxFilters.Controls.Add(this.lblToDate);
            this.groupBoxFilters.Controls.Add(this.dtpToDate);
            this.groupBoxFilters.Controls.Add(this.lblNote);
            this.groupBoxFilters.Controls.Add(this.txtNote);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 121);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(413, 297);
            this.groupBoxFilters.TabIndex = 16;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            this.groupBoxFilters.Enter += new System.EventHandler(this.groupBoxFilters_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.đơnHàngtoolStripMenuItem,
            this.phânCôngLắpRápToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.nhàCungCấptoolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(921, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1299, 35);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(96, 31);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(158, 31);
            this.sảnPhẩmToolStripMenuItem.Text = "Quản lý Sản phẩm";
            // 
            // đơnHàngtoolStripMenuItem
            // 
            this.đơnHàngtoolStripMenuItem.Name = "đơnHàngtoolStripMenuItem";
            this.đơnHàngtoolStripMenuItem.Size = new System.Drawing.Size(154, 31);
            this.đơnHàngtoolStripMenuItem.Text = "Quản lý Đơn hàng";
            // 
            // phânCôngLắpRápToolStripMenuItem
            // 
            this.phânCôngLắpRápToolStripMenuItem.Name = "phânCôngLắpRápToolStripMenuItem";
            this.phânCôngLắpRápToolStripMenuItem.Size = new System.Drawing.Size(162, 31);
            this.phânCôngLắpRápToolStripMenuItem.Text = "Phân công Lắp ráp";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(157, 31);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân viên";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(171, 31);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách hàng";
            // 
            // nhàCungCấptoolStripMenuItem
            // 
            this.nhàCungCấptoolStripMenuItem.Name = "nhàCungCấptoolStripMenuItem";
            this.nhàCungCấptoolStripMenuItem.Size = new System.Drawing.Size(186, 31);
            this.nhàCungCấptoolStripMenuItem.Text = "Quản lý Nhà cung cấp";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(93, 31);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(89, 31);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quản lý Kho";
            // 
            // textBox_SearchKho
            // 
            this.textBox_SearchKho.Location = new System.Drawing.Point(1129, 95);
            this.textBox_SearchKho.Name = "textBox_SearchKho";
            this.textBox_SearchKho.Size = new System.Drawing.Size(155, 20);
            this.textBox_SearchKho.TabIndex = 16;
            this.textBox_SearchKho.TextChanged += new System.EventHandler(this.textBox_SearchKho_TextChanged);
            // 
            // QuanLyKho
            // 
            this.ClientSize = new System.Drawing.Size(1299, 611);
            this.Controls.Add(this.textBox_SearchKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInventory);
            this.Name = "QuanLyKho";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem đơnHàngtoolStripMenuItem;
        private ToolStripMenuItem phânCôngLắpRápToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấptoolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Label label1;
        private TextBox textBox_SearchKho;
    }
}
