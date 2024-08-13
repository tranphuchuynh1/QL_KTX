namespace QL_KTX
{
    partial class QL_SinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_SinhVien));
            groupBox1 = new GroupBox();
            comboBoxToa = new ComboBox();
            comboBoxPhong = new ComboBox();
            buttonThoat = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThem = new Button();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            dateTimePickerNgaySinh = new DateTimePicker();
            textBoxSDT = new TextBox();
            textBoxDiaChi = new TextBox();
            textboxHọVàTên = new TextBox();
            textboxMSSV = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridViewQuảnLýSinhViên = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuảnLýSinhViên).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBoxToa);
            groupBox1.Controls.Add(comboBoxPhong);
            groupBox1.Controls.Add(buttonThoat);
            groupBox1.Controls.Add(buttonSua);
            groupBox1.Controls.Add(buttonXoa);
            groupBox1.Controls.Add(buttonThem);
            groupBox1.Controls.Add(radioButtonNu);
            groupBox1.Controls.Add(radioButtonNam);
            groupBox1.Controls.Add(dateTimePickerNgaySinh);
            groupBox1.Controls.Add(textBoxSDT);
            groupBox1.Controls.Add(textBoxDiaChi);
            groupBox1.Controls.Add(textboxHọVàTên);
            groupBox1.Controls.Add(textboxMSSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Cyan;
            groupBox1.Location = new Point(2, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(830, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sinh viên";
            // 
            // comboBoxToa
            // 
            comboBoxToa.FormattingEnabled = true;
            comboBoxToa.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxToa.Location = new Point(145, 269);
            comboBoxToa.Margin = new Padding(3, 4, 3, 4);
            comboBoxToa.Name = "comboBoxToa";
            comboBoxToa.Size = new Size(403, 28);
            comboBoxToa.TabIndex = 13;
            comboBoxToa.SelectedIndexChanged += comboBoxToa_SelectedIndexChanged;
            // 
            // comboBoxPhong
            // 
            comboBoxPhong.FormattingEnabled = true;
            comboBoxPhong.Location = new Point(145, 305);
            comboBoxPhong.Margin = new Padding(3, 4, 3, 4);
            comboBoxPhong.Name = "comboBoxPhong";
            comboBoxPhong.Size = new Size(403, 28);
            comboBoxPhong.TabIndex = 11;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.Cyan;
            buttonThoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            buttonThoat.BackgroundImageLayout = ImageLayout.None;
            buttonThoat.Cursor = Cursors.Hand;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.ForeColor = Color.Black;
            buttonThoat.Location = new Point(611, 284);
            buttonThoat.Margin = new Padding(3, 4, 3, 4);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(103, 51);
            buttonThoat.TabIndex = 5;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click_1;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.Cyan;
            buttonSua.BackgroundImage = Properties.Resources.icons8_save_as_26;
            buttonSua.BackgroundImageLayout = ImageLayout.None;
            buttonSua.Cursor = Cursors.Hand;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.ForeColor = Color.Black;
            buttonSua.Location = new Point(611, 201);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(102, 51);
            buttonSua.TabIndex = 5;
            buttonSua.Text = "Sữa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.Cyan;
            buttonXoa.BackgroundImage = Properties.Resources.icons8_x_26;
            buttonXoa.BackgroundImageLayout = ImageLayout.None;
            buttonXoa.Cursor = Cursors.Hand;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.ForeColor = Color.Black;
            buttonXoa.Location = new Point(611, 119);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(102, 51);
            buttonXoa.TabIndex = 5;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.Cyan;
            buttonThem.BackgroundImage = Properties.Resources.icons8_add_administrator_26;
            buttonThem.BackgroundImageLayout = ImageLayout.None;
            buttonThem.Cursor = Cursors.Hand;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.ForeColor = Color.Black;
            buttonThem.Location = new Point(611, 37);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(102, 49);
            buttonThem.TabIndex = 5;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.ForeColor = Color.Black;
            radioButtonNu.Location = new Point(374, 151);
            radioButtonNu.Margin = new Padding(3, 4, 3, 4);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 4;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.ForeColor = Color.Black;
            radioButtonNam.Location = new Point(200, 151);
            radioButtonNam.Margin = new Padding(3, 4, 3, 4);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 4;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(147, 116);
            dateTimePickerNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(401, 27);
            dateTimePickerNgaySinh.TabIndex = 3;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(149, 228);
            textBoxSDT.Margin = new Padding(3, 4, 3, 4);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(402, 27);
            textBoxSDT.TabIndex = 2;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(149, 193);
            textBoxDiaChi.Margin = new Padding(3, 4, 3, 4);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(402, 27);
            textBoxDiaChi.TabIndex = 2;
            // 
            // textboxHọVàTên
            // 
            textboxHọVàTên.Location = new Point(146, 77);
            textboxHọVàTên.Margin = new Padding(3, 4, 3, 4);
            textboxHọVàTên.Name = "textboxHọVàTên";
            textboxHọVàTên.Size = new Size(402, 27);
            textboxHọVàTên.TabIndex = 2;
            // 
            // textboxMSSV
            // 
            textboxMSSV.Location = new Point(146, 37);
            textboxMSSV.Margin = new Padding(3, 4, 3, 4);
            textboxMSSV.Name = "textboxMSSV";
            textboxMSSV.Size = new Size(402, 27);
            textboxMSSV.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 283);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 1;
            label1.Text = "Tòa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(128, 255, 255);
            label8.Font = new Font("Microsoft Sans Serif", 8.25F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(7, 311);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 1;
            label8.Text = "Phòng ở";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(128, 255, 255);
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(7, 236);
            label7.Name = "label7";
            label7.Size = new Size(36, 17);
            label7.TabIndex = 1;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 255, 255);
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(7, 197);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 255, 255);
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(7, 159);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 1;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 255, 255);
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(7, 120);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 1;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 255);
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 81);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 43);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 1;
            label2.Text = "MSSV";
            // 
            // dataGridViewQuảnLýSinhViên
            // 
            dataGridViewQuảnLýSinhViên.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewQuảnLýSinhViên.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuảnLýSinhViên.Location = new Point(2, 360);
            dataGridViewQuảnLýSinhViên.Margin = new Padding(3, 4, 3, 4);
            dataGridViewQuảnLýSinhViên.Name = "dataGridViewQuảnLýSinhViên";
            dataGridViewQuảnLýSinhViên.RowHeadersWidth = 51;
            dataGridViewQuảnLýSinhViên.Size = new Size(830, 193);
            dataGridViewQuảnLýSinhViên.TabIndex = 2;
            // 
            // QL_SinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.a2_WGEM2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 551);
            Controls.Add(dataGridViewQuảnLýSinhViên);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "QL_SinhVien";
            Text = "QL_SinhVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuảnLýSinhViên).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonThoat;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThem;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxSDT;
        private TextBox textBoxDiaChi;
        private TextBox textboxHọVàTên;
        private TextBox textboxMSSV;
        private DataGridView dataGridViewQuảnLýSinhViên;
        private Label label8;
        private ComboBox comboBoxPhong;
        private ComboBox comboBoxToa;
        private Label label1;
    }
}
