namespace App
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txtTenDN = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMK = new MaterialSkin.Controls.MaterialTextBox();
            this.ckbNhoMK = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnDN = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDN
            // 
            this.txtTenDN.AnimateReadOnly = false;
            this.txtTenDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDN.Depth = 0;
            this.txtTenDN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenDN.Hint = "Tên đăng nhập";
            this.txtTenDN.LeadingIcon = null;
            this.txtTenDN.Location = new System.Drawing.Point(401, 129);
            this.txtTenDN.MaxLength = 50;
            this.txtTenDN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenDN.Multiline = false;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(342, 50);
            this.txtTenDN.TabIndex = 0;
            this.txtTenDN.Text = "";
            this.txtTenDN.TrailingIcon = null;
            // 
            // txtMK
            // 
            this.txtMK.AnimateReadOnly = false;
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMK.Depth = 0;
            this.txtMK.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMK.Hint = "Mật khẩu";
            this.txtMK.LeadingIcon = null;
            this.txtMK.Location = new System.Drawing.Point(401, 207);
            this.txtMK.MaxLength = 50;
            this.txtMK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMK.Multiline = false;
            this.txtMK.Name = "txtMK";
            this.txtMK.Password = true;
            this.txtMK.Size = new System.Drawing.Size(342, 50);
            this.txtMK.TabIndex = 1;
            this.txtMK.Text = "";
            this.txtMK.TrailingIcon = null;
            // 
            // ckbNhoMK
            // 
            this.ckbNhoMK.AutoSize = true;
            this.ckbNhoMK.Depth = 0;
            this.ckbNhoMK.Location = new System.Drawing.Point(401, 281);
            this.ckbNhoMK.Margin = new System.Windows.Forms.Padding(0);
            this.ckbNhoMK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbNhoMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbNhoMK.Name = "ckbNhoMK";
            this.ckbNhoMK.ReadOnly = false;
            this.ckbNhoMK.Ripple = true;
            this.ckbNhoMK.Size = new System.Drawing.Size(135, 37);
            this.ckbNhoMK.TabIndex = 2;
            this.ckbNhoMK.Text = "Nhớ mật khẩu";
            this.ckbNhoMK.UseVisualStyleBackColor = true;
            this.ckbNhoMK.CheckedChanged += new System.EventHandler(this.ckbNhoMK_CheckedChanged);
            // 
            // btnDN
            // 
            this.btnDN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDN.Depth = 0;
            this.btnDN.HighEmphasis = true;
            this.btnDN.Icon = null;
            this.btnDN.Location = new System.Drawing.Point(533, 324);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDN.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDN.Name = "btnDN";
            this.btnDN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDN.Size = new System.Drawing.Size(105, 36);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDN.UseAccentColor = false;
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.ckbNhoMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Name = "frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtTenDN;
        private MaterialSkin.Controls.MaterialTextBox txtMK;
        private MaterialSkin.Controls.MaterialCheckbox ckbNhoMK;
        private MaterialSkin.Controls.MaterialButton btnDN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}