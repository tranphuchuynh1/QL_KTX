namespace QL_KTX
{
    partial class LuaChonCuaBanLaGi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuaChonCuaBanLaGi));
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Fuchsia;
            button1.Location = new Point(162, 239);
            button1.Name = "button1";
            button1.Size = new Size(213, 202);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(493, 239);
            button2.Name = "button2";
            button2.Size = new Size(214, 202);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(496, 211);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 0, 30, 0);
            label2.Size = new Size(211, 25);
            label2.TabIndex = 3;
            label2.Text = "Chế Độ Thư Giãn";
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.Info;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(1, 606);
            button7.Name = "button7";
            button7.Size = new Size(832, 57);
            button7.TabIndex = 13;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 211);
            label1.Name = "label1";
            label1.Padding = new Padding(43, 0, 43, 0);
            label1.Size = new Size(210, 25);
            label1.TabIndex = 18;
            label1.Text = "Form Dữ Liệu";
            // 
            // LuaChonCuaBanLaGi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 663);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LuaChonCuaBanLaGi";
            Text = "LuaChonCuaBanLaGi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Button button7;
        private Label label1;
    }
}