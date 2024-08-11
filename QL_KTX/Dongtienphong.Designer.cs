namespace QL_KTX
{
    partial class Dongtienphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dongtienphong));
            btthoat = new Button();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox8 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btthoat
            // 
            btthoat.BackColor = Color.FromArgb(128, 255, 128);
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.Location = new Point(292, 210);
            btthoat.Margin = new Padding(3, 2, 3, 2);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(125, 38);
            btthoat.TabIndex = 20;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = false;
            btthoat.Click += btthoat_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.BackgroundImage = Properties.Resources.icons8_money_26;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(67, 210);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 19;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(266, 66);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(210, 23);
            comboBox4.TabIndex = 17;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "B1", "B3" });
            comboBox3.Location = new Point(266, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(210, 23);
            comboBox3.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(266, 107);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(210, 23);
            textBox8.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(45, 27);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 13;
            label6.Text = "Tòa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(45, 105);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 14;
            label4.Text = "Tiền đóng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 15;
            label2.Text = "Số phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 143);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 14;
            label1.Text = "Ngày đóng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(266, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // Dongtienphong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(488, 282);
            Controls.Add(dateTimePicker1);
            Controls.Add(btthoat);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(textBox8);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dongtienphong";
            Text = "Đóng tiền";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btthoat;
        private Button button1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TextBox textBox8;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}