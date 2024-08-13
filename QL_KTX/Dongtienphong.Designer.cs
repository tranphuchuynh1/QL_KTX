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
            buttonThoat = new Button();
            buttonThanhToán = new Button();
            textBoxTiềnĐóng = new TextBox();
            Tòa = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerNgàyĐóng = new DateTimePicker();
            comboBoxTòa = new ComboBox();
            comboBoxSốPhòng = new ComboBox();
            SuspendLayout();
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.FromArgb(128, 255, 128);
            buttonThoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            buttonThoat.BackgroundImageLayout = ImageLayout.None;
            buttonThoat.Cursor = Cursors.Hand;
            buttonThoat.FlatStyle = FlatStyle.Flat;
            buttonThoat.Location = new Point(334, 280);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(143, 51);
            buttonThoat.TabIndex = 20;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonThanhToán
            // 
            buttonThanhToán.BackColor = Color.FromArgb(128, 255, 128);
            buttonThanhToán.BackgroundImage = Properties.Resources.icons8_money_26;
            buttonThanhToán.BackgroundImageLayout = ImageLayout.None;
            buttonThanhToán.Cursor = Cursors.Hand;
            buttonThanhToán.FlatStyle = FlatStyle.Flat;
            buttonThanhToán.Location = new Point(77, 280);
            buttonThanhToán.Margin = new Padding(3, 4, 3, 4);
            buttonThanhToán.Name = "buttonThanhToán";
            buttonThanhToán.Size = new Size(143, 51);
            buttonThanhToán.TabIndex = 19;
            buttonThanhToán.Text = "Thanh toán";
            buttonThanhToán.UseVisualStyleBackColor = false;
            buttonThanhToán.Click += buttonThanhToán_Click;
            // 
            // textBoxTiềnĐóng
            // 
            textBoxTiềnĐóng.Location = new Point(304, 143);
            textBoxTiềnĐóng.Margin = new Padding(3, 4, 3, 4);
            textBoxTiềnĐóng.Name = "textBoxTiềnĐóng";
            textBoxTiềnĐóng.Size = new Size(239, 27);
            textBoxTiềnĐóng.TabIndex = 16;
            textBoxTiềnĐóng.TextChanged += textBoxTiềnĐóng_TextChanged;
            // 
            // Tòa
            // 
            Tòa.AutoSize = true;
            Tòa.BackColor = Color.Transparent;
            Tòa.Font = new Font("Microsoft Sans Serif", 12F);
            Tòa.ForeColor = Color.Black;
            Tòa.Location = new Point(54, 36);
            Tòa.Name = "Tòa";
            Tòa.Size = new Size(47, 25);
            Tòa.TabIndex = 13;
            Tòa.Text = "Tòa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 140);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 14;
            label4.Text = "Tiền đóng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(54, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 15;
            label2.Text = "Số phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 191);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 14;
            label1.Text = "Ngày đóng";
            // 
            // dateTimePickerNgàyĐóng
            // 
            dateTimePickerNgàyĐóng.Location = new Point(304, 191);
            dateTimePickerNgàyĐóng.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerNgàyĐóng.Name = "dateTimePickerNgàyĐóng";
            dateTimePickerNgàyĐóng.Size = new Size(239, 27);
            dateTimePickerNgàyĐóng.TabIndex = 21;
            dateTimePickerNgàyĐóng.ValueChanged += dateTimePickerNgàyĐóng_ValueChanged;
            // 
            // comboBoxTòa
            // 
            comboBoxTòa.FormattingEnabled = true;
            comboBoxTòa.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxTòa.Location = new Point(304, 37);
            comboBoxTòa.Margin = new Padding(3, 4, 3, 4);
            comboBoxTòa.Name = "comboBoxTòa";
            comboBoxTòa.Size = new Size(239, 28);
            comboBoxTòa.TabIndex = 23;
            comboBoxTòa.SelectedIndexChanged += comboBoxTòa_SelectedIndexChanged;
            // 
            // comboBoxSốPhòng
            // 
            comboBoxSốPhòng.FormattingEnabled = true;
            comboBoxSốPhòng.Items.AddRange(new object[] { "B1", "B3" });
            comboBoxSốPhòng.Location = new Point(304, 89);
            comboBoxSốPhòng.Margin = new Padding(3, 4, 3, 4);
            comboBoxSốPhòng.Name = "comboBoxSốPhòng";
            comboBoxSốPhòng.Size = new Size(239, 28);
            comboBoxSốPhòng.TabIndex = 24;
            comboBoxSốPhòng.SelectedIndexChanged += comboBoxSốPhòng_SelectedIndexChanged;
            // 
            // Dongtienphong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 358);
            Controls.Add(comboBoxSốPhòng);
            Controls.Add(comboBoxTòa);
            Controls.Add(dateTimePickerNgàyĐóng);
            Controls.Add(buttonThoat);
            Controls.Add(buttonThanhToán);
            Controls.Add(textBoxTiềnĐóng);
            Controls.Add(Tòa);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dongtienphong";
            Text = "Đóng tiền";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonThoat;
        private Button buttonThanhToán;
        private TextBox textBoxTiềnĐóng;
        private Label Tòa;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerNgàyĐóng;
        private ComboBox comboBoxTòa;
        private ComboBox comboBoxSốPhòng;
    }
}