namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyChinh
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
            panelMain = new Panel();
            navbar_Left1 = new UserControlCustom.Navbar_Left();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1156, 3);
            btn_CloseLogin.Margin = new Padding(4, 3, 4, 3);
            btn_CloseLogin.Name = "btn_CloseLogin";
            btn_CloseLogin.Size = new Size(34, 27);
            btn_CloseLogin.TabIndex = 12;
            btn_CloseLogin.Text = "X";
            btn_CloseLogin.UseVisualStyleBackColor = true;
            btn_CloseLogin.Click += btn_CloseLogin_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btn_CloseLogin);
            panelMain.Location = new Point(383, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1194, 836);
            panelMain.TabIndex = 20;
            // 
            // navbar_Left1
            // 
            navbar_Left1.AutoScroll = true;
            navbar_Left1.Location = new Point(12, 12);
            navbar_Left1.Name = "navbar_Left1";
            navbar_Left1.Size = new Size(344, 836);
            navbar_Left1.TabIndex = 21;
            navbar_Left1.Load += navbar_Left1_Load;
            // 
            // frm_QuanLyChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1589, 869);
            Controls.Add(navbar_Left1);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_CloseLogin;
        private Panel panelMain;
        private UserControlCustom.Navbar_Left navbar_Left1;

    }
}