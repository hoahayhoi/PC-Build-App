namespace PcBuiApp_Client_v1.View
{
    partial class frm_DSLapRap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DSLapRap));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mCBB_PhanLoai = new MaterialSkin.Controls.MaterialComboBox();
            mLV_DSDHCLR = new MaterialSkin.Controls.MaterialListView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabPage2 = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            tabPage6 = new TabPage();
            tabPage8 = new TabPage();
            tabPage10 = new TabPage();
            imageList1 = new ImageList(components);
            label10 = new Label();
            label1 = new Label();
            materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label11 = new Label();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage8);
            materialTabControl1.Controls.Add(tabPage10);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(4, 74);
            materialTabControl1.Margin = new Padding(4, 3, 4, 3);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1074, 615);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Controls.Add(materialLabel1);
            tabPage1.Controls.Add(mCBB_PhanLoai);
            tabPage1.Controls.Add(mLV_DSDHCLR);
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.ImageKey = "icons8-home-48.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1066, 580);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel2.Location = new Point(50, 88);
            materialLabel2.Margin = new Padding(4, 0, 4, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(72, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Phân loại:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(13, 15);
            materialLabel1.Margin = new Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(348, 24);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "DANH SÁCH ĐƠN HÀNG CẦN LẮP RÁP";
            // 
            // mCBB_PhanLoai
            // 
            mCBB_PhanLoai.AutoResize = false;
            mCBB_PhanLoai.BackColor = Color.FromArgb(255, 255, 255);
            mCBB_PhanLoai.Depth = 0;
            mCBB_PhanLoai.DrawMode = DrawMode.OwnerDrawVariable;
            mCBB_PhanLoai.DropDownHeight = 118;
            mCBB_PhanLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            mCBB_PhanLoai.DropDownWidth = 121;
            mCBB_PhanLoai.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mCBB_PhanLoai.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mCBB_PhanLoai.FormattingEnabled = true;
            mCBB_PhanLoai.IntegralHeight = false;
            mCBB_PhanLoai.ItemHeight = 29;
            mCBB_PhanLoai.Location = new Point(164, 69);
            mCBB_PhanLoai.Margin = new Padding(4, 3, 4, 3);
            mCBB_PhanLoai.MaxDropDownItems = 4;
            mCBB_PhanLoai.MouseState = MaterialSkin.MouseState.OUT;
            mCBB_PhanLoai.Name = "mCBB_PhanLoai";
            mCBB_PhanLoai.Size = new Size(209, 35);
            mCBB_PhanLoai.StartIndex = 0;
            mCBB_PhanLoai.TabIndex = 10;
            mCBB_PhanLoai.UseTallSize = false;
            // 
            // mLV_DSDHCLR
            // 
            mLV_DSDHCLR.AutoSizeTable = false;
            mLV_DSDHCLR.BackColor = Color.FromArgb(255, 255, 255);
            mLV_DSDHCLR.BorderStyle = BorderStyle.None;
            mLV_DSDHCLR.Depth = 0;
            mLV_DSDHCLR.FullRowSelect = true;
            mLV_DSDHCLR.Location = new Point(17, 139);
            mLV_DSDHCLR.Margin = new Padding(4, 3, 4, 3);
            mLV_DSDHCLR.MinimumSize = new Size(233, 115);
            mLV_DSDHCLR.MouseLocation = new Point(-1, -1);
            mLV_DSDHCLR.MouseState = MaterialSkin.MouseState.OUT;
            mLV_DSDHCLR.Name = "mLV_DSDHCLR";
            mLV_DSDHCLR.OwnerDraw = true;
            mLV_DSDHCLR.Size = new Size(958, 395);
            mLV_DSDHCLR.TabIndex = 9;
            mLV_DSDHCLR.UseCompatibleStateImageBehavior = false;
            //mLV_DSDHCLR.View = View.Details;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(4, 555);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1058, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(89, 17);
            toolStripStatusLabel1.Text = "Hello, Admin";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialButton1);
            tabPage2.Controls.Add(materialRadioButton3);
            tabPage2.Controls.Add(materialRadioButton2);
            tabPage2.Controls.Add(materialRadioButton1);
            tabPage2.Controls.Add(materialSwitch1);
            tabPage2.Controls.Add(materialMultiLineTextBox1);
            tabPage2.Controls.Add(materialTextBox5);
            tabPage2.Controls.Add(materialTextBox4);
            tabPage2.Controls.Add(materialTextBox3);
            tabPage2.Controls.Add(materialTextBox2);
            tabPage2.Controls.Add(materialTextBox1);
            tabPage2.ImageKey = "icons8-goal-48.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(1066, 580);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Forms";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(26, 455);
            materialButton1.Margin = new Padding(5, 7, 5, 7);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(75, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Submit";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(259, 335);
            materialRadioButton3.Margin = new Padding(0);
            materialRadioButton3.MouseLocation = new Point(-1, -1);
            materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton3.Name = "materialRadioButton3";
            materialRadioButton3.Ripple = true;
            materialRadioButton3.Size = new Size(81, 37);
            materialRadioButton3.TabIndex = 9;
            materialRadioButton3.TabStop = true;
            materialRadioButton3.Text = "Others";
            materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(133, 335);
            materialRadioButton2.Margin = new Padding(0);
            materialRadioButton2.MouseLocation = new Point(-1, -1);
            materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton2.Name = "materialRadioButton2";
            materialRadioButton2.Ripple = true;
            materialRadioButton2.Size = new Size(87, 37);
            materialRadioButton2.TabIndex = 8;
            materialRadioButton2.TabStop = true;
            materialRadioButton2.Text = "Female";
            materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(26, 335);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(70, 37);
            materialRadioButton1.TabIndex = 7;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Male";
            materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(26, 393);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(226, 37);
            materialSwitch1.TabIndex = 6;
            materialSwitch1.Text = "Subscribe to new letters";
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(567, 27);
            materialMultiLineTextBox1.Margin = new Padding(4, 3, 4, 3);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(418, 252);
            materialMultiLineTextBox1.TabIndex = 5;
            materialMultiLineTextBox1.Text = "";
            // 
            // materialTextBox5
            // 
            materialTextBox5.AnimateReadOnly = false;
            materialTextBox5.BorderStyle = BorderStyle.None;
            materialTextBox5.Depth = 0;
            materialTextBox5.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox5.Hint = "Password";
            materialTextBox5.LeadingIcon = null;
            materialTextBox5.Location = new Point(26, 182);
            materialTextBox5.Margin = new Padding(4, 3, 4, 3);
            materialTextBox5.MaxLength = 50;
            materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox5.Multiline = false;
            materialTextBox5.Name = "materialTextBox5";
            materialTextBox5.Password = true;
            materialTextBox5.Size = new Size(504, 50);
            materialTextBox5.TabIndex = 4;
            materialTextBox5.Text = "";
            materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            materialTextBox4.AnimateReadOnly = false;
            materialTextBox4.BorderStyle = BorderStyle.None;
            materialTextBox4.Depth = 0;
            materialTextBox4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox4.Hint = "Email";
            materialTextBox4.LeadingIcon = null;
            materialTextBox4.Location = new Point(26, 261);
            materialTextBox4.Margin = new Padding(4, 3, 4, 3);
            materialTextBox4.MaxLength = 50;
            materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox4.Multiline = false;
            materialTextBox4.Name = "materialTextBox4";
            materialTextBox4.Size = new Size(504, 50);
            materialTextBox4.TabIndex = 3;
            materialTextBox4.Text = "";
            materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.Hint = "Username";
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(26, 105);
            materialTextBox3.Margin = new Padding(4, 3, 4, 3);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(504, 50);
            materialTextBox3.TabIndex = 2;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Last Name";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(287, 27);
            materialTextBox2.Margin = new Padding(4, 3, 4, 3);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(243, 50);
            materialTextBox2.TabIndex = 1;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "First Name";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(26, 27);
            materialTextBox1.Margin = new Padding(4, 3, 4, 3);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(243, 50);
            materialTextBox1.TabIndex = 0;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // tabPage6
            // 
            tabPage6.ImageKey = "icons8-notification-48.png";
            tabPage6.Location = new Point(4, 31);
            tabPage6.Margin = new Padding(4, 3, 4, 3);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1066, 580);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Notification";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.ImageKey = "icons8-analytics-32.png";
            tabPage8.Location = new Point(4, 31);
            tabPage8.Margin = new Padding(4, 3, 4, 3);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1066, 580);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Charts";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(4, 31);
            tabPage10.Margin = new Padding(4, 3, 4, 3);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1066, 580);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "Settings | Logout";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-borrow-book-32.png");
            imageList1.Images.SetKeyName(1, "icons8-analytics-32.png");
            imageList1.Images.SetKeyName(2, "icons8-email-48.png");
            imageList1.Images.SetKeyName(3, "icons8-notification-48.png");
            imageList1.Images.SetKeyName(4, "icons8-typing-48.png");
            imageList1.Images.SetKeyName(5, "icons8-table-32.png");
            imageList1.Images.SetKeyName(6, "icons8-goal-48.png");
            imageList1.Images.SetKeyName(7, "icons8-line-chart-48.png");
            imageList1.Images.SetKeyName(8, "icons8-us-dollar-52.png");
            imageList1.Images.SetKeyName(9, "icons8-home-48.png");
            imageList1.Images.SetKeyName(10, "icons8-dashboard-48.png");
            imageList1.Images.SetKeyName(11, "icons8-document-48.png");
            // 
            // label10
            // 
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // materialProgressBar3
            // 
            materialProgressBar3.Depth = 0;
            materialProgressBar3.Location = new Point(0, 0);
            materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar3.Name = "materialProgressBar3";
            materialProgressBar3.Size = new Size(100, 23);
            materialProgressBar3.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 0;
            // 
            // materialProgressBar2
            // 
            materialProgressBar2.Depth = 0;
            materialProgressBar2.Location = new Point(0, 0);
            materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar2.Name = "materialProgressBar2";
            materialProgressBar2.Size = new Size(100, 23);
            materialProgressBar2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 0;
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(0, 0);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(100, 23);
            materialProgressBar1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "icons8-dashboard-48.png";
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1066, 580);
            tabPage3.TabIndex = 10;
            tabPage3.Text = "Products";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // frm_DSLapRap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 692);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_DSLapRap";
            Padding = new Padding(4, 74, 4, 3);
            Text = "PC Build App";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox mCBB_PhanLoai;
        private MaterialSkin.Controls.MaterialListView mLV_DSDHCLR;
        private TabPage tabPage3;
    }
}

