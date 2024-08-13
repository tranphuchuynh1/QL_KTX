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
            comboBoxTòa = new ComboBox();
            buttonKiểmTra = new Button();
            buttonThoát = new Button();
            comboBoxSốPhòng = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            dataGridViewTìnhTrạngPhòng = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTìnhTrạngPhòng).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(427, 285);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(201, 27);
            textBox6.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(427, 236);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(427, 187);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(337, 12);
            label3.Name = "label3";
            label3.Size = new Size(208, 48);
            label3.TabIndex = 13;
            label3.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBoxTòa);
            groupBox1.Controls.Add(buttonKiểmTra);
            groupBox1.Controls.Add(buttonThoát);
            groupBox1.Controls.Add(comboBoxSốPhòng);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 101);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(806, 215);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // comboBoxTòa
            // 
            comboBoxTòa.FormattingEnabled = true;
            comboBoxTòa.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxTòa.Location = new Point(326, 53);
            comboBoxTòa.Margin = new Padding(3, 4, 3, 4);
            comboBoxTòa.Name = "comboBoxTòa";
            comboBoxTòa.Size = new Size(203, 28);
            comboBoxTòa.TabIndex = 13;
            comboBoxTòa.SelectedIndexChanged += comboBoxTòa_SelectedIndexChanged;
            // 
            // buttonKiểmTra
            // 
            buttonKiểmTra.BackColor = Color.FromArgb(255, 255, 128);
            buttonKiểmTra.BackgroundImage = Properties.Resources.icons8_test_26;
            buttonKiểmTra.BackgroundImageLayout = ImageLayout.None;
            buttonKiểmTra.Cursor = Cursors.Hand;
            buttonKiểmTra.FlatStyle = FlatStyle.Flat;
            buttonKiểmTra.ForeColor = Color.Black;
            buttonKiểmTra.Location = new Point(599, 151);
            buttonKiểmTra.Margin = new Padding(3, 4, 3, 4);
            buttonKiểmTra.Name = "buttonKiểmTra";
            buttonKiểmTra.Size = new Size(113, 51);
            buttonKiểmTra.TabIndex = 12;
            buttonKiểmTra.Text = "Kiểm tra";
            buttonKiểmTra.UseVisualStyleBackColor = false;
            buttonKiểmTra.Click += buttonKiểmTra_Click;
            // 
            // buttonThoát
            // 
            buttonThoát.BackColor = Color.FromArgb(255, 255, 128);
            buttonThoát.BackgroundImage = Properties.Resources.icons8_logout_26;
            buttonThoát.BackgroundImageLayout = ImageLayout.None;
            buttonThoát.Cursor = Cursors.Hand;
            buttonThoát.FlatStyle = FlatStyle.Flat;
            buttonThoát.ForeColor = Color.Black;
            buttonThoát.Location = new Point(599, 53);
            buttonThoát.Margin = new Padding(3, 4, 3, 4);
            buttonThoát.Name = "buttonThoát";
            buttonThoát.Size = new Size(113, 51);
            buttonThoát.TabIndex = 12;
            buttonThoát.Text = "Thoát";
            buttonThoát.UseVisualStyleBackColor = false;
            buttonThoát.Click += buttonThoát_Click;
            // 
            // comboBoxSốPhòng
            // 
            comboBoxSốPhòng.FormattingEnabled = true;
            comboBoxSốPhòng.Location = new Point(326, 151);
            comboBoxSốPhòng.Margin = new Padding(3, 4, 3, 4);
            comboBoxSốPhòng.Name = "comboBoxSốPhòng";
            comboBoxSốPhòng.Size = new Size(202, 28);
            comboBoxSốPhòng.TabIndex = 10;
            comboBoxSốPhòng.SelectedIndexChanged += comboBoxSốPhòng_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(82, 57);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 8;
            label6.Text = "Tòa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(82, 151);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 8;
            label2.Text = "Số phòng";
            // 
            // dataGridViewTìnhTrạngPhòng
            // 
            dataGridViewTìnhTrạngPhòng.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridViewTìnhTrạngPhòng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTìnhTrạngPhòng.Location = new Point(3, 311);
            dataGridViewTìnhTrạngPhòng.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTìnhTrạngPhòng.Name = "dataGridViewTìnhTrạngPhòng";
            dataGridViewTìnhTrạngPhòng.RowHeadersWidth = 51;
            dataGridViewTìnhTrạngPhòng.Size = new Size(806, 324);
            dataGridViewTìnhTrạngPhòng.TabIndex = 15;
            dataGridViewTìnhTrạngPhòng.CellContentClick += dataGridViewTìnhTrạngPhòng_CellContentClick;
            // 
            // TinhTrangPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_01671;
            ClientSize = new Size(809, 632);
            Controls.Add(dataGridViewTìnhTrạngPhòng);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TinhTrangPhong";
            Text = "Tình Trạng";
            Load += TinhTrangPhong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTìnhTrạngPhòng).EndInit();
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
        private ComboBox comboBoxSốPhòng;
        private DataGridView dataGridViewTìnhTrạngPhòng;
        private Button buttonThoát;
        private ComboBox comboBoxTòa;
        private Button buttonKiểmTra;
    }
}