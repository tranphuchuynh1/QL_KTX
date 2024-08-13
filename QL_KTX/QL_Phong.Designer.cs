namespace QL_KTX
{
    partial class QL_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Phong));
            dataGridViewQuảnLýPhòng = new DataGridView();
            groupBox1 = new GroupBox();
            buttonThoát = new Button();
            buttonSửa = new Button();
            buttonXóa = new Button();
            comboBoxSốPhòng = new ComboBox();
            comboBoxTòa = new ComboBox();
            buttonThêm = new Button();
            textBoxSốNgười = new TextBox();
            textBoxGiáTiền = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuảnLýPhòng).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewQuảnLýPhòng
            // 
            dataGridViewQuảnLýPhòng.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridViewQuảnLýPhòng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuảnLýPhòng.Location = new Point(2, 353);
            dataGridViewQuảnLýPhòng.Margin = new Padding(3, 4, 3, 4);
            dataGridViewQuảnLýPhòng.Name = "dataGridViewQuảnLýPhòng";
            dataGridViewQuảnLýPhòng.RowHeadersWidth = 51;
            dataGridViewQuảnLýPhòng.Size = new Size(696, 200);
            dataGridViewQuảnLýPhòng.TabIndex = 5;
            dataGridViewQuảnLýPhòng.CellClick += dataGridViewQuảnLýPhòng_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonThoát);
            groupBox1.Controls.Add(buttonSửa);
            groupBox1.Controls.Add(buttonXóa);
            groupBox1.Controls.Add(comboBoxSốPhòng);
            groupBox1.Controls.Add(comboBoxTòa);
            groupBox1.Controls.Add(buttonThêm);
            groupBox1.Controls.Add(textBoxSốNgười);
            groupBox1.Controls.Add(textBoxGiáTiền);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.FromArgb(255, 255, 128);
            groupBox1.Location = new Point(2, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(696, 329);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý phòng";
            // 
            // buttonThoát
            // 
            buttonThoát.BackColor = Color.FromArgb(255, 255, 128);
            buttonThoát.BackgroundImage = Properties.Resources.icons8_logout_26;
            buttonThoát.BackgroundImageLayout = ImageLayout.None;
            buttonThoát.Cursor = Cursors.Hand;
            buttonThoát.FlatStyle = FlatStyle.Popup;
            buttonThoát.ForeColor = Color.Black;
            buttonThoát.Location = new Point(489, 148);
            buttonThoát.Margin = new Padding(3, 4, 3, 4);
            buttonThoát.Name = "buttonThoát";
            buttonThoát.Size = new Size(103, 51);
            buttonThoát.TabIndex = 13;
            buttonThoát.Text = "Thoát";
            buttonThoát.UseVisualStyleBackColor = false;
            buttonThoát.Click += buttonThoát_Click;
            // 
            // buttonSửa
            // 
            buttonSửa.BackColor = Color.FromArgb(255, 255, 128);
            buttonSửa.BackgroundImage = Properties.Resources.icons8_save_as_26;
            buttonSửa.BackgroundImageLayout = ImageLayout.None;
            buttonSửa.Cursor = Cursors.Hand;
            buttonSửa.FlatStyle = FlatStyle.Flat;
            buttonSửa.ForeColor = Color.Black;
            buttonSửa.Location = new Point(381, 235);
            buttonSửa.Margin = new Padding(3, 4, 3, 4);
            buttonSửa.Name = "buttonSửa";
            buttonSửa.Size = new Size(102, 51);
            buttonSửa.TabIndex = 14;
            buttonSửa.Text = "Sữa";
            buttonSửa.UseVisualStyleBackColor = false;
            buttonSửa.Click += buttonSửa_Click;
            // 
            // buttonXóa
            // 
            buttonXóa.BackColor = Color.FromArgb(255, 255, 128);
            buttonXóa.BackgroundImage = Properties.Resources.icons8_x_26;
            buttonXóa.BackgroundImageLayout = ImageLayout.None;
            buttonXóa.Cursor = Cursors.Hand;
            buttonXóa.FlatStyle = FlatStyle.Flat;
            buttonXóa.ForeColor = Color.Black;
            buttonXóa.Location = new Point(381, 148);
            buttonXóa.Margin = new Padding(3, 4, 3, 4);
            buttonXóa.Name = "buttonXóa";
            buttonXóa.Size = new Size(102, 51);
            buttonXóa.TabIndex = 15;
            buttonXóa.Text = "Xóa";
            buttonXóa.UseVisualStyleBackColor = false;
            buttonXóa.Click += buttonXóa_Click;
            // 
            // comboBoxSốPhòng
            // 
            comboBoxSốPhòng.FormattingEnabled = true;
            comboBoxSốPhòng.Location = new Point(149, 119);
            comboBoxSốPhòng.Margin = new Padding(3, 4, 3, 4);
            comboBoxSốPhòng.Name = "comboBoxSốPhòng";
            comboBoxSốPhòng.Size = new Size(201, 28);
            comboBoxSốPhòng.TabIndex = 12;
            // 
            // comboBoxTòa
            // 
            comboBoxTòa.FormattingEnabled = true;
            comboBoxTòa.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxTòa.Location = new Point(149, 59);
            comboBoxTòa.Margin = new Padding(3, 4, 3, 4);
            comboBoxTòa.Name = "comboBoxTòa";
            comboBoxTòa.Size = new Size(201, 28);
            comboBoxTòa.TabIndex = 12;
            // 
            // buttonThêm
            // 
            buttonThêm.BackColor = Color.FromArgb(255, 255, 128);
            buttonThêm.BackgroundImage = Properties.Resources.icons8_add_new_26;
            buttonThêm.BackgroundImageLayout = ImageLayout.None;
            buttonThêm.Cursor = Cursors.Hand;
            buttonThêm.FlatStyle = FlatStyle.Flat;
            buttonThêm.ForeColor = Color.Black;
            buttonThêm.Location = new Point(381, 64);
            buttonThêm.Margin = new Padding(3, 4, 3, 4);
            buttonThêm.Name = "buttonThêm";
            buttonThêm.Size = new Size(102, 48);
            buttonThêm.TabIndex = 5;
            buttonThêm.Text = "Thêm";
            buttonThêm.UseVisualStyleBackColor = false;
            buttonThêm.Click += buttonThêm_Click;
            // 
            // textBoxSốNgười
            // 
            textBoxSốNgười.Location = new Point(149, 239);
            textBoxSốNgười.Margin = new Padding(3, 4, 3, 4);
            textBoxSốNgười.Name = "textBoxSốNgười";
            textBoxSốNgười.Size = new Size(201, 27);
            textBoxSốNgười.TabIndex = 2;
            // 
            // textBoxGiáTiền
            // 
            textBoxGiáTiền.Location = new Point(149, 179);
            textBoxGiáTiền.Margin = new Padding(3, 4, 3, 4);
            textBoxGiáTiền.Name = "textBoxGiáTiền";
            textBoxGiáTiền.Size = new Size(201, 27);
            textBoxGiáTiền.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 128);
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(11, 72);
            label7.Name = "label7";
            label7.Size = new Size(33, 17);
            label7.TabIndex = 1;
            label7.Text = "Tòa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(11, 240);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 1;
            label4.Text = "Số người";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 184);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 1;
            label3.Text = "Giá tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 128);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Số phòng";
            // 
            // QL_Phong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_01671;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(698, 552);
            Controls.Add(dataGridViewQuảnLýPhòng);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "QL_Phong";
            Text = "QL_Phong";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuảnLýPhòng).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewQuảnLýPhòng;
        private GroupBox groupBox1;
        private Button buttonThêm;
        private TextBox textBoxGiáTiền;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxSốNgười;
        private Label label7;
        private ComboBox comboBoxTòa;
        private Button buttonThoát;
        private Button buttonSửa;
        private Button buttonXóa;
        private ComboBox comboBoxSốPhòng;
    }
}