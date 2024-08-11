namespace QL_KTX
{
    partial class Hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btthoat = new Button();
            btkiemtra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(146, 90);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(288, 23);
            comboBox4.TabIndex = 21;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "B1", "B3" });
            comboBox3.Location = new Point(146, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(288, 23);
            comboBox3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(36, 50);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 19;
            label6.Text = "Tòa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(38, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 20;
            label2.Text = "Số phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(482, 150);
            dataGridView1.TabIndex = 23;
            // 
            // btthoat
            // 
            btthoat.BackColor = Color.FromArgb(128, 255, 255);
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.Location = new Point(146, 135);
            btthoat.Margin = new Padding(3, 2, 3, 2);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(125, 38);
            btthoat.TabIndex = 24;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = false;
            btthoat.Click += btthoat_Click;
            // 
            // btkiemtra
            // 
            btkiemtra.BackColor = Color.FromArgb(128, 255, 255);
            btkiemtra.BackgroundImage = Properties.Resources.icons8_test_26;
            btkiemtra.BackgroundImageLayout = ImageLayout.None;
            btkiemtra.Cursor = Cursors.Hand;
            btkiemtra.FlatStyle = FlatStyle.Flat;
            btkiemtra.ForeColor = Color.Black;
            btkiemtra.Location = new Point(322, 135);
            btkiemtra.Name = "btkiemtra";
            btkiemtra.Size = new Size(112, 38);
            btkiemtra.TabIndex = 25;
            btkiemtra.Text = "Kiểm tra";
            btkiemtra.UseVisualStyleBackColor = false;
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(483, 327);
            Controls.Add(btkiemtra);
            Controls.Add(btthoat);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hoadon";
            Text = "Hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label6;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btthoat;
        private Button btkiemtra;
    }
}