namespace QL_KTX
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            labelDN = new Label();
            labelMK = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxTàiKhoản = new TextBox();
            textBoxMậtKhẩu = new TextBox();
            buttonĐăngNhập = new Button();
            buttonChuyểnQuaFormĐăngKý = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnThoát = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDN
            // 
            labelDN.AutoSize = true;
            labelDN.Location = new Point(55, 203);
            labelDN.Name = "labelDN";
            labelDN.Size = new Size(76, 20);
            labelDN.TabIndex = 0;
            labelDN.Text = "Tài Khoản:";
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.Location = new Point(55, 270);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(75, 20);
            labelMK.TabIndex = 1;
            labelMK.Text = "Mật Khẩu:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxTàiKhoản
            // 
            textBoxTàiKhoản.Location = new Point(152, 200);
            textBoxTàiKhoản.Name = "textBoxTàiKhoản";
            textBoxTàiKhoản.Size = new Size(281, 27);
            textBoxTàiKhoản.TabIndex = 3;
            // 
            // textBoxMậtKhẩu
            // 
            textBoxMậtKhẩu.Location = new Point(152, 267);
            textBoxMậtKhẩu.Name = "textBoxMậtKhẩu";
            textBoxMậtKhẩu.Size = new Size(281, 27);
            textBoxMậtKhẩu.TabIndex = 4;
            // 
            // buttonĐăngNhập
            // 
            buttonĐăngNhập.BackgroundImage = Properties.Resources.icons8_login_26;
            buttonĐăngNhập.BackgroundImageLayout = ImageLayout.None;
            buttonĐăngNhập.Location = new Point(304, 312);
            buttonĐăngNhập.Name = "buttonĐăngNhập";
            buttonĐăngNhập.Size = new Size(129, 47);
            buttonĐăngNhập.TabIndex = 6;
            buttonĐăngNhập.Text = "Đăng nhập";
            buttonĐăngNhập.UseVisualStyleBackColor = true;
            buttonĐăngNhập.Click += buttonĐăngNhập_Click;
            // 
            // buttonChuyểnQuaFormĐăngKý
            // 
            buttonChuyểnQuaFormĐăngKý.BackgroundImage = Properties.Resources.icons8_registration_26;
            buttonChuyểnQuaFormĐăngKý.BackgroundImageLayout = ImageLayout.None;
            buttonChuyểnQuaFormĐăngKý.Cursor = Cursors.Hand;
            buttonChuyểnQuaFormĐăngKý.Location = new Point(8, 374);
            buttonChuyểnQuaFormĐăngKý.Name = "buttonChuyểnQuaFormĐăngKý";
            buttonChuyểnQuaFormĐăngKý.Size = new Size(123, 40);
            buttonChuyểnQuaFormĐăngKý.TabIndex = 7;
            buttonChuyểnQuaFormĐăngKý.Text = "Đăng ký";
            buttonChuyểnQuaFormĐăngKý.UseVisualStyleBackColor = true;
            buttonChuyểnQuaFormĐăngKý.Click += buttonChuyểnQuaFormĐăngKý_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(171, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 153);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 155);
            panel1.TabIndex = 9;
            // 
            // btnThoát
            // 
            btnThoát.BackColor = Color.IndianRed;
            btnThoát.BackgroundImage = Properties.Resources.icons8_logout_26;
            btnThoát.BackgroundImageLayout = ImageLayout.None;
            btnThoát.Cursor = Cursors.Hand;
            btnThoát.FlatStyle = FlatStyle.Flat;
            btnThoát.Location = new Point(172, 312);
            btnThoát.Name = "btnThoát";
            btnThoát.Size = new Size(112, 47);
            btnThoát.TabIndex = 25;
            btnThoát.Text = "Thoát";
            btnThoát.UseVisualStyleBackColor = false;
            btnThoát.Click += btnThoát_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(524, 426);
            Controls.Add(btnThoát);
            Controls.Add(panel1);
            Controls.Add(buttonChuyểnQuaFormĐăngKý);
            Controls.Add(buttonĐăngNhập);
            Controls.Add(textBoxMậtKhẩu);
            Controls.Add(textBoxTàiKhoản);
            Controls.Add(labelMK);
            Controls.Add(labelDN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDN;
        private Label labelMK;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxTàiKhoản;
        private TextBox textBoxMậtKhẩu;
        private Button buttonĐăngNhập;
        private Button buttonChuyểnQuaFormĐăngKý;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnThoát;
    }
}