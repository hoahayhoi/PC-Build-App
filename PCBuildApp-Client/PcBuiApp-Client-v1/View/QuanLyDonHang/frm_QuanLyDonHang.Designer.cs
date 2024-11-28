namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyDonHang
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
            components = new System.ComponentModel.Container();
            btn_CloseLogin = new Button();
            panel3 = new Panel();
            roundedUserControl2 = new UserControlCustom.RoundedUserControl();
            label2 = new Label();
            roundedUserControl3 = new UserControlCustom.RoundedUserControl();
            textBox1 = new TextBox();
            roundedUserControl4 = new UserControlCustom.RoundedUserControl();
            label3 = new Label();
            dgv_DSDonHang = new DataGridView();
            Column_STT = new DataGridViewTextBoxColumn();
            Column_OrdersId = new DataGridViewTextBoxColumn();
            Column_Date = new DataGridViewTextBoxColumn();
            Column_TotalPrice = new DataGridViewTextBoxColumn();
            Column_Status = new DataGridViewTextBoxColumn();
            Column_ListAccountAction = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mn_ChiTiet = new ToolStripMenuItem();
            mn_Xoa = new ToolStripMenuItem();
            roundedUserControl2.SuspendLayout();
            roundedUserControl3.SuspendLayout();
            roundedUserControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSDonHang).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            label2.Size = new Size(153, 21);
            label2.TabIndex = 0;
            label2.Text = "Quản Lý Đơn Hàng";
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
            roundedUserControl4.Controls.Add(label3);
            roundedUserControl4.Controls.Add(dgv_DSDonHang);
            roundedUserControl4.CornerRadius = 50;
            roundedUserControl4.Location = new Point(1, 169);
            roundedUserControl4.Name = "roundedUserControl4";
            roundedUserControl4.Size = new Size(1181, 667);
            roundedUserControl4.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(172, 21);
            label3.TabIndex = 1;
            label3.Text = "Danh Sách Đơn Hàng";
            // 
            // dgv_DSDonHang
            // 
            dgv_DSDonHang.AllowUserToAddRows = false;
            dgv_DSDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_DSDonHang.BackgroundColor = Color.White;
            dgv_DSDonHang.BorderStyle = BorderStyle.None;
            dgv_DSDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSDonHang.Columns.AddRange(new DataGridViewColumn[] { Column_STT, Column_OrdersId, Column_Date, Column_TotalPrice, Column_Status, Column_ListAccountAction });
            dgv_DSDonHang.Dock = DockStyle.Bottom;
            dgv_DSDonHang.Location = new Point(0, 93);
            dgv_DSDonHang.Name = "dgv_DSDonHang";
            dgv_DSDonHang.RowTemplate.Height = 25;
            dgv_DSDonHang.Size = new Size(1181, 574);
            dgv_DSDonHang.TabIndex = 0;
            dgv_DSDonHang.CellContentClick += dgv_DSDonHang_CellContentClick;
            // 
            // Column_STT
            // 
            Column_STT.FillWeight = 20F;
            Column_STT.HeaderText = "STT";
            Column_STT.Name = "Column_STT";
            // 
            // Column_OrdersId
            // 
            Column_OrdersId.HeaderText = "Mã Đơn Hàng";
            Column_OrdersId.Name = "Column_OrdersId";
            // 
            // Column_Date
            // 
            Column_Date.HeaderText = "Ngày Tạo";
            Column_Date.Name = "Column_Date";
            // 
            // Column_TotalPrice
            // 
            Column_TotalPrice.HeaderText = "Tổng Tiền";
            Column_TotalPrice.Name = "Column_TotalPrice";
            // 
            // Column_Status
            // 
            Column_Status.HeaderText = "Trạng Thái";
            Column_Status.Name = "Column_Status";
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
            panel1.Size = new Size(1194, 788);
            panel1.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mn_ChiTiet, mn_Xoa });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // mn_ChiTiet
            // 
            mn_ChiTiet.Name = "mn_ChiTiet";
            mn_ChiTiet.Size = new Size(180, 22);
            mn_ChiTiet.Text = "Chi Tiết";
            // 
            // mn_Xoa
            // 
            mn_Xoa.Name = "mn_Xoa";
            mn_Xoa.Size = new Size(180, 22);
            mn_Xoa.Text = "Xóa";
            // 
            // frm_QuanLyDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1194, 788);
            Controls.Add(btn_CloseLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frm_QuanLyDonHang_Load;
            roundedUserControl2.ResumeLayout(false);
            roundedUserControl2.PerformLayout();
            roundedUserControl3.ResumeLayout(false);
            roundedUserControl3.PerformLayout();
            roundedUserControl4.ResumeLayout(false);
            roundedUserControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSDonHang).EndInit();
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
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
        private DataGridView dgv_DSDonHang;
        private Label label3;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column_STT;
        private DataGridViewTextBoxColumn Column_OrdersId;
        private DataGridViewTextBoxColumn Column_Date;
        private DataGridViewTextBoxColumn Column_TotalPrice;
        private DataGridViewTextBoxColumn Column_Status;
        private DataGridViewTextBoxColumn Column_ListAccountAction;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mn_ChiTiet;
        private ToolStripMenuItem mn_Xoa;
    }
}