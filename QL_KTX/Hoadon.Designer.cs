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
            comboBoxSốPhòng = new ComboBox();
            comboBoxTòa = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            dataGridViewHóaĐơn = new DataGridView();
            btnThoát = new Button();
            buttonKiểmTra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHóaĐơn).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSốPhòng
            // 
            comboBoxSốPhòng.FormattingEnabled = true;
            comboBoxSốPhòng.Location = new Point(167, 120);
            comboBoxSốPhòng.Margin = new Padding(3, 4, 3, 4);
            comboBoxSốPhòng.Name = "comboBoxSốPhòng";
            comboBoxSốPhòng.Size = new Size(329, 28);
            comboBoxSốPhòng.TabIndex = 21;
            comboBoxSốPhòng.SelectedIndexChanged += comboBoxSốPhòng_SelectedIndexChanged;
            // 
            // comboBoxTòa
            // 
            comboBoxTòa.FormattingEnabled = true;
            comboBoxTòa.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxTòa.Location = new Point(167, 68);
            comboBoxTòa.Margin = new Padding(3, 4, 3, 4);
            comboBoxTòa.Name = "comboBoxTòa";
            comboBoxTòa.Size = new Size(329, 28);
            comboBoxTòa.TabIndex = 22;
            comboBoxTòa.SelectedIndexChanged += comboBoxTòa_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(41, 67);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 19;
            label6.Text = "Tòa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 20;
            label2.Text = "Số phòng";
            // 
            // dataGridViewHóaĐơn
            // 
            dataGridViewHóaĐơn.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewHóaĐơn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHóaĐơn.Location = new Point(0, 237);
            dataGridViewHóaĐơn.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHóaĐơn.Name = "dataGridViewHóaĐơn";
            dataGridViewHóaĐơn.RowHeadersWidth = 51;
            dataGridViewHóaĐơn.Size = new Size(551, 200);
            dataGridViewHóaĐơn.TabIndex = 23;
            dataGridViewHóaĐơn.CellContentClick += dataGridViewHóaĐơn_CellContentClick;
            // 
            // btnThoát
            // 
            btnThoát.BackColor = Color.FromArgb(128, 255, 255);
            btnThoát.BackgroundImage = Properties.Resources.icons8_logout_26;
            btnThoát.BackgroundImageLayout = ImageLayout.None;
            btnThoát.Cursor = Cursors.Hand;
            btnThoát.FlatStyle = FlatStyle.Flat;
            btnThoát.Location = new Point(167, 180);
            btnThoát.Name = "btnThoát";
            btnThoát.Size = new Size(143, 51);
            btnThoát.TabIndex = 24;
            btnThoát.Text = "Thoát";
            btnThoát.UseVisualStyleBackColor = false;
            btnThoát.Click += btnThoát_Click;
            // 
            // buttonKiểmTra
            // 
            buttonKiểmTra.BackColor = Color.FromArgb(128, 255, 255);
            buttonKiểmTra.BackgroundImage = Properties.Resources.icons8_test_26;
            buttonKiểmTra.BackgroundImageLayout = ImageLayout.None;
            buttonKiểmTra.Cursor = Cursors.Hand;
            buttonKiểmTra.FlatStyle = FlatStyle.Flat;
            buttonKiểmTra.ForeColor = Color.Black;
            buttonKiểmTra.Location = new Point(368, 180);
            buttonKiểmTra.Margin = new Padding(3, 4, 3, 4);
            buttonKiểmTra.Name = "buttonKiểmTra";
            buttonKiểmTra.Size = new Size(128, 51);
            buttonKiểmTra.TabIndex = 25;
            buttonKiểmTra.Text = "Kiểm tra";
            buttonKiểmTra.UseVisualStyleBackColor = false;
            buttonKiểmTra.Click += buttonKiểmTra_Click;
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(552, 436);
            Controls.Add(buttonKiểmTra);
            Controls.Add(btnThoát);
            Controls.Add(dataGridViewHóaĐơn);
            Controls.Add(comboBoxSốPhòng);
            Controls.Add(comboBoxTòa);
            Controls.Add(label6);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Hoadon";
            Text = "Hóa đơn";
            Load += Hoadon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHóaĐơn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSốPhòng;
        private ComboBox comboBoxTòa;
        private Label label6;
        private Label label2;
        private DataGridView dataGridViewHóaĐơn;
        private Button btnThoát;
        private Button buttonKiểmTra;
    }
}