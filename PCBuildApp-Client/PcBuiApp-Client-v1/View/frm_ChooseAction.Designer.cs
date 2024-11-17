namespace PcBuiApp_Client_v1.View
{
    partial class frm_ChooseAction
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
            btn_Edit = new Button();
            btn_Delete = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(48, 34);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(123, 30);
            btn_Edit.TabIndex = 13;
            btn_Edit.Text = "Sửa";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click_1;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(251, 34);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(123, 30);
            btn_Delete.TabIndex = 14;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 46);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Hành Động";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Edit);
            panel2.Controls.Add(btn_Delete);
            panel2.Location = new Point(34, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 92);
            panel2.TabIndex = 16;
            // 
            // frm_ChooseAction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 170);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ChooseAction";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frm_ChooseAction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Edit;
        private Button btn_Delete;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}