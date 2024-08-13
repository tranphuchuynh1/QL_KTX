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
            buttonThoát = new Button();
            SuspendLayout();
            // 
            // labelDN
            // 
            labelDN.AutoSize = true;
            labelDN.Location = new Point(55, 48);
            labelDN.Name = "labelDN";
            labelDN.Size = new Size(59, 20);
            labelDN.TabIndex = 0;
            labelDN.Text = "Họ Tên:";
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.Location = new Point(55, 115);
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
            textBoxTàiKhoản.Location = new Point(152, 49);
            textBoxTàiKhoản.Name = "textBoxTàiKhoản";
            textBoxTàiKhoản.Size = new Size(281, 27);
            textBoxTàiKhoản.TabIndex = 3;
            // 
            // textBoxMậtKhẩu
            // 
            textBoxMậtKhẩu.Location = new Point(152, 115);
            textBoxMậtKhẩu.Name = "textBoxMậtKhẩu";
            textBoxMậtKhẩu.Size = new Size(281, 27);
            textBoxMậtKhẩu.TabIndex = 4;
            // 
            // buttonĐăngNhập
            // 
            buttonĐăngNhập.BackgroundImage = Properties.Resources.icons8_login_26;
            buttonĐăngNhập.BackgroundImageLayout = ImageLayout.None;
            buttonĐăngNhập.Location = new Point(209, 169);
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
            buttonChuyểnQuaFormĐăngKý.Location = new Point(115, 239);
            buttonChuyểnQuaFormĐăngKý.Name = "buttonChuyểnQuaFormĐăngKý";
            buttonChuyểnQuaFormĐăngKý.Size = new Size(122, 47);
            buttonChuyểnQuaFormĐăngKý.TabIndex = 7;
            buttonChuyểnQuaFormĐăngKý.Text = "Đăng ký";
            buttonChuyểnQuaFormĐăngKý.UseVisualStyleBackColor = true;
            buttonChuyểnQuaFormĐăngKý.Click += buttonChuyểnQuaFormĐăngKý_Click;
            // 
            // buttonThoát
            // 
            buttonThoát.BackgroundImage = Properties.Resources.icons8_logout_26;
            buttonThoát.BackgroundImageLayout = ImageLayout.None;
            buttonThoát.Cursor = Cursors.Hand;
            buttonThoát.Location = new Point(325, 239);
            buttonThoát.Name = "buttonThoát";
            buttonThoát.Size = new Size(109, 51);
            buttonThoát.TabIndex = 8;
            buttonThoát.Text = "Thoát";
            buttonThoát.UseVisualStyleBackColor = true;
            buttonThoát.Click += buttonThoát_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(526, 304);
            Controls.Add(buttonThoát);
            Controls.Add(buttonChuyểnQuaFormĐăngKý);
            Controls.Add(buttonĐăngNhập);
            Controls.Add(textBoxMậtKhẩu);
            Controls.Add(textBoxTàiKhoản);
            Controls.Add(labelMK);
            Controls.Add(labelDN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            Text = "DangNhap";
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
        private Button buttonThoát;
    }
}