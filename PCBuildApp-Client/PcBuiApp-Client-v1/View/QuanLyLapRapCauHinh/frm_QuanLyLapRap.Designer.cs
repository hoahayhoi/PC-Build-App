namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyLapRap
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
            dgv_DSLR = new DataGridView();
            Column_ListAccountSTT = new DataGridViewTextBoxColumn();
            Column_OrderId = new DataGridViewTextBoxColumn();
            Column_Deadline = new DataGridViewTextBoxColumn();
            Column_Status = new DataGridViewTextBoxColumn();
            Column_ListAccountAction = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            roundedUserControl2.SuspendLayout();
            roundedUserControl3.SuspendLayout();
            roundedUserControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSLR).BeginInit();
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
            label2.Size = new Size(136, 21);
            label2.TabIndex = 0;
            label2.Text = "Quản Lý Lắp Ráp";
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
            roundedUserControl4.Controls.Add(dgv_DSLR);
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
            label3.Size = new Size(220, 21);
            label3.TabIndex = 1;
            label3.Text = "Danh Sách Yêu Cầu Lắp Ráp";
            // 
            // dgv_DSLR
            // 
            dgv_DSLR.AllowUserToAddRows = false;
            dgv_DSLR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSLR.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_DSLR.BackgroundColor = Color.White;
            dgv_DSLR.BorderStyle = BorderStyle.None;
            dgv_DSLR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSLR.Columns.AddRange(new DataGridViewColumn[] { Column_ListAccountSTT, Column_OrderId, Column_Deadline, Column_Status, Column_ListAccountAction });
            dgv_DSLR.Dock = DockStyle.Bottom;
            dgv_DSLR.Location = new Point(0, 93);
            dgv_DSLR.Name = "dgv_DSLR";
            dgv_DSLR.RowTemplate.Height = 25;
            dgv_DSLR.Size = new Size(1181, 574);
            dgv_DSLR.TabIndex = 0;
            dgv_DSLR.CellContentClick += dgv_DSLR_CellContentClick;
            // 
            // Column_ListAccountSTT
            // 
            Column_ListAccountSTT.FillWeight = 20F;
            Column_ListAccountSTT.HeaderText = "STT";
            Column_ListAccountSTT.Name = "Column_ListAccountSTT";
            // 
            // Column_OrderId
            // 
            Column_OrderId.HeaderText = "Mã Đơn Hàng";
            Column_OrderId.Name = "Column_OrderId";
            // 
            // Column_Deadline
            // 
            Column_Deadline.HeaderText = "Deadline";
            Column_Deadline.Name = "Column_Deadline";
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
            // frm_QuanLyLapRap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1194, 788);
            Controls.Add(btn_CloseLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyLapRap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frm_QuanLyLapRap_Load;
            roundedUserControl2.ResumeLayout(false);
            roundedUserControl2.PerformLayout();
            roundedUserControl3.ResumeLayout(false);
            roundedUserControl3.PerformLayout();
            roundedUserControl4.ResumeLayout(false);
            roundedUserControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSLR).EndInit();
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
        private DataGridView dgv_DSLR;
        private Label label3;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column_ListAccountSTT;
        private DataGridViewTextBoxColumn Column_OrderId;
        private DataGridViewTextBoxColumn Column_Deadline;
        private DataGridViewTextBoxColumn Column_Status;
        private DataGridViewTextBoxColumn Column_ListAccountAction;
    }
}