namespace QL_KTX
{
    partial class PhongThuGian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongThuGian));
            panel4 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            label2 = new Label();
            button_open = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(axWindowsMediaPlayer1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button_open);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(listBox1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1327, 674);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 192);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(1021, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 35);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(74, 7);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "Danh sách nhạc";
            label1.Click += label1_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(11, 12);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1004, 589);
            axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 631);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Đang phát";
            // 
            // button_open
            // 
            button_open.Location = new Point(1021, 629);
            button_open.Name = "button_open";
            button_open.Size = new Size(94, 29);
            button_open.TabIndex = 4;
            button_open.Text = "...";
            button_open.UseVisualStyleBackColor = true;
            button_open.Click += button_open_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 630);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(894, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(1215, 629);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1021, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 544);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // PhongThuGian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 674);
            Controls.Add(panel4);
            Name = "PhongThuGian";
            Text = "PhongThuGian";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private Button button_open;
        private TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel3;
        private Label label1;
    }
}