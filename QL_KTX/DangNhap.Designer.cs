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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonDN = new Button();
            buttonDK = new Button();
            btthoat = new Button();
            SuspendLayout();
            // 
            // labelDN
            // 
            labelDN.AutoSize = true;
            labelDN.Location = new Point(48, 36);
            labelDN.Name = "labelDN";
            labelDN.Size = new Size(47, 15);
            labelDN.TabIndex = 0;
            labelDN.Text = "Họ Tên:";
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.Location = new Point(48, 86);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(61, 15);
            labelMK.TabIndex = 1;
            labelMK.Text = "Mật Khẩu:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 37);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 86);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 4;
            // 
            // buttonDN
            // 
            buttonDN.BackgroundImage = Properties.Resources.icons8_login_26;
            buttonDN.BackgroundImageLayout = ImageLayout.None;
            buttonDN.Location = new Point(183, 127);
            buttonDN.Margin = new Padding(3, 2, 3, 2);
            buttonDN.Name = "buttonDN";
            buttonDN.Size = new Size(113, 35);
            buttonDN.TabIndex = 6;
            buttonDN.Text = "Đăng nhập";
            buttonDN.UseVisualStyleBackColor = true;
            buttonDN.Click += buttonDN_Click;
            // 
            // buttonDK
            // 
            buttonDK.BackgroundImage = Properties.Resources.icons8_registration_26;
            buttonDK.BackgroundImageLayout = ImageLayout.None;
            buttonDK.Cursor = Cursors.Hand;
            buttonDK.Location = new Point(101, 179);
            buttonDK.Margin = new Padding(3, 2, 3, 2);
            buttonDK.Name = "buttonDK";
            buttonDK.Size = new Size(107, 35);
            buttonDK.TabIndex = 7;
            buttonDK.Text = "Đăng ký";
            buttonDK.UseVisualStyleBackColor = true;
            buttonDK.Click += buttonDK_Click;
            // 
            // btthoat
            // 
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.Location = new Point(284, 179);
            btthoat.Margin = new Padding(3, 2, 3, 2);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(95, 38);
            btthoat.TabIndex = 8;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(460, 228);
            Controls.Add(btthoat);
            Controls.Add(buttonDK);
            Controls.Add(buttonDN);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelMK);
            Controls.Add(labelDN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDN;
        private Label labelMK;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonDN;
        private Button buttonDK;
        private Button btthoat;
    }
}