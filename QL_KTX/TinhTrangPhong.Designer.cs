namespace QL_KTX
{
    partial class TinhTrangPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTrangPhong));
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            comboBox4 = new ComboBox();
            btkiemtra = new Button();
            btthoat = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(374, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(295, 9);
            label3.Name = "label3";
            label3.Size = new Size(170, 39);
            label3.TabIndex = 13;
            label3.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(btkiemtra);
            groupBox1.Controls.Add(btthoat);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 161);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "B1", "B3" });
            comboBox4.Location = new Point(285, 40);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(178, 23);
            comboBox4.TabIndex = 13;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // btkiemtra
            // 
            btkiemtra.BackColor = Color.FromArgb(255, 255, 128);
            btkiemtra.BackgroundImage = Properties.Resources.icons8_test_26;
            btkiemtra.BackgroundImageLayout = ImageLayout.None;
            btkiemtra.Cursor = Cursors.Hand;
            btkiemtra.FlatStyle = FlatStyle.Flat;
            btkiemtra.ForeColor = Color.Black;
            btkiemtra.Location = new Point(524, 113);
            btkiemtra.Name = "btkiemtra";
            btkiemtra.Size = new Size(99, 38);
            btkiemtra.TabIndex = 12;
            btkiemtra.Text = "Kiểm tra";
            btkiemtra.UseVisualStyleBackColor = false;
            btkiemtra.Click += btthoat_Click;
            // 
            // btthoat
            // 
            btthoat.BackColor = Color.FromArgb(255, 255, 128);
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.ForeColor = Color.Black;
            btthoat.Location = new Point(524, 40);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(99, 38);
            btthoat.TabIndex = 12;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = false;
            btthoat.Click += btthoat_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(72, 43);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 8;
            label6.Text = "Tòa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Số phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(705, 243);
            dataGridView1.TabIndex = 15;
            // 
            // TinhTrangPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_01671;
            ClientSize = new Size(708, 474);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TinhTrangPhong";
            Text = "Tình Trạng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btthoat;
        private ComboBox comboBox4;
        private Button btkiemtra;
    }
}