namespace QL_KTX
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            labelHoTenDK = new Label();
            labelMatKhauDK = new Label();
            labelNhapLaiMK = new Label();
            textBoxTàiKhoản = new TextBox();
            textBoxMậtKhẩu = new TextBox();
            textBoxNhậpLạiMậtKhẩu = new TextBox();
            buttonĐăngKý = new Button();
            btthoat = new Button();
            SuspendLayout();
            // 
            // labelHoTenDK
            // 
            labelHoTenDK.AutoSize = true;
            labelHoTenDK.Location = new Point(41, 37);
            labelHoTenDK.Name = "labelHoTenDK";
            labelHoTenDK.Size = new Size(57, 20);
            labelHoTenDK.TabIndex = 0;
            labelHoTenDK.Text = "Họ tên:";
            // 
            // labelMatKhauDK
            // 
            labelMatKhauDK.AutoSize = true;
            labelMatKhauDK.Location = new Point(41, 104);
            labelMatKhauDK.Name = "labelMatKhauDK";
            labelMatKhauDK.Size = new Size(70, 20);
            labelMatKhauDK.TabIndex = 1;
            labelMatKhauDK.Text = "Mật khẩu";
            // 
            // labelNhapLaiMK
            // 
            labelNhapLaiMK.AutoSize = true;
            labelNhapLaiMK.Location = new Point(41, 169);
            labelNhapLaiMK.Name = "labelNhapLaiMK";
            labelNhapLaiMK.Size = new Size(133, 20);
            labelNhapLaiMK.TabIndex = 2;
            labelNhapLaiMK.Text = "Nhập lại mật khẩu:";
            // 
            // textBoxTàiKhoản
            // 
            textBoxTàiKhoản.Location = new Point(183, 35);
            textBoxTàiKhoản.Name = "textBoxTàiKhoản";
            textBoxTàiKhoản.Size = new Size(281, 27);
            textBoxTàiKhoản.TabIndex = 3;
            // 
            // textBoxMậtKhẩu
            // 
            textBoxMậtKhẩu.Location = new Point(183, 104);
            textBoxMậtKhẩu.Name = "textBoxMậtKhẩu";
            textBoxMậtKhẩu.Size = new Size(281, 27);
            textBoxMậtKhẩu.TabIndex = 4;
            // 
            // textBoxNhậpLạiMậtKhẩu
            // 
            textBoxNhậpLạiMậtKhẩu.Location = new Point(183, 165);
            textBoxNhậpLạiMậtKhẩu.Name = "textBoxNhậpLạiMậtKhẩu";
            textBoxNhậpLạiMậtKhẩu.Size = new Size(281, 27);
            textBoxNhậpLạiMậtKhẩu.TabIndex = 5;
            // 
            // buttonĐăngKý
            // 
            buttonĐăngKý.BackgroundImage = Properties.Resources.icons8_registration_26;
            buttonĐăngKý.BackgroundImageLayout = ImageLayout.None;
            buttonĐăngKý.Cursor = Cursors.Hand;
            buttonĐăngKý.Location = new Point(246, 245);
            buttonĐăngKý.Name = "buttonĐăngKý";
            buttonĐăngKý.Size = new Size(114, 51);
            buttonĐăngKý.TabIndex = 6;
            buttonĐăngKý.Text = "Đăng Ký";
            buttonĐăngKý.UseVisualStyleBackColor = true;
            buttonĐăngKý.Click += buttonĐăngKý_Click;
            // 
            // btthoat
            // 
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.Location = new Point(379, 245);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(109, 51);
            btthoat.TabIndex = 7;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(538, 315);
            Controls.Add(btthoat);
            Controls.Add(buttonĐăngKý);
            Controls.Add(textBoxNhậpLạiMậtKhẩu);
            Controls.Add(textBoxMậtKhẩu);
            Controls.Add(textBoxTàiKhoản);
            Controls.Add(labelNhapLaiMK);
            Controls.Add(labelMatKhauDK);
            Controls.Add(labelHoTenDK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHoTenDK;
        private Label labelMatKhauDK;
        private Label labelNhapLaiMK;
        private TextBox textBoxTàiKhoản;
        private TextBox textBoxMậtKhẩu;
        private TextBox textBoxNhậpLạiMậtKhẩu;
        private Button buttonĐăngKý;
        private Button btthoat;
    }
}