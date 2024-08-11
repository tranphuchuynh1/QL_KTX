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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonDangKy = new Button();
            btthoat = new Button();
            SuspendLayout();
            // 
            // labelHoTenDK
            // 
            labelHoTenDK.AutoSize = true;
            labelHoTenDK.Location = new Point(36, 28);
            labelHoTenDK.Name = "labelHoTenDK";
            labelHoTenDK.Size = new Size(46, 15);
            labelHoTenDK.TabIndex = 0;
            labelHoTenDK.Text = "Họ tên:";
            // 
            // labelMatKhauDK
            // 
            labelMatKhauDK.AutoSize = true;
            labelMatKhauDK.Location = new Point(36, 78);
            labelMatKhauDK.Name = "labelMatKhauDK";
            labelMatKhauDK.Size = new Size(57, 15);
            labelMatKhauDK.TabIndex = 1;
            labelMatKhauDK.Text = "Mật khẩu";
            // 
            // labelNhapLaiMK
            // 
            labelNhapLaiMK.AutoSize = true;
            labelNhapLaiMK.Location = new Point(36, 127);
            labelNhapLaiMK.Name = "labelNhapLaiMK";
            labelNhapLaiMK.Size = new Size(107, 15);
            labelNhapLaiMK.TabIndex = 2;
            labelNhapLaiMK.Text = "Nhập lại mật khẩu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 26);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 78);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 124);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 5;
            // 
            // buttonDangKy
            // 
            buttonDangKy.BackgroundImage = Properties.Resources.icons8_registration_26;
            buttonDangKy.BackgroundImageLayout = ImageLayout.None;
            buttonDangKy.Cursor = Cursors.Hand;
            buttonDangKy.Location = new Point(215, 184);
            buttonDangKy.Margin = new Padding(3, 2, 3, 2);
            buttonDangKy.Name = "buttonDangKy";
            buttonDangKy.Size = new Size(100, 38);
            buttonDangKy.TabIndex = 6;
            buttonDangKy.Text = "Đăng Ký";
            buttonDangKy.UseVisualStyleBackColor = true;
            buttonDangKy.Click += buttonDangKy_Click;
            // 
            // btthoat
            // 
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.Location = new Point(332, 184);
            btthoat.Margin = new Padding(3, 2, 3, 2);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(95, 38);
            btthoat.TabIndex = 7;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(471, 236);
            Controls.Add(btthoat);
            Controls.Add(buttonDangKy);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelNhapLaiMK);
            Controls.Add(labelMatKhauDK);
            Controls.Add(labelHoTenDK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHoTenDK;
        private Label labelMatKhauDK;
        private Label labelNhapLaiMK;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonDangKy;
        private Button btthoat;
    }
}