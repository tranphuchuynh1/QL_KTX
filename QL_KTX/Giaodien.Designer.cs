namespace QL_KTX
{
    partial class Giaodien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giaodien));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            qLSinhViênToolStripMenuItem = new ToolStripMenuItem();
            qLPhòngToolStripMenuItem = new ToolStripMenuItem();
            tìnhTrạngPhòngToolStripMenuItem = new ToolStripMenuItem();
            phòngToolStripMenuItem = new ToolStripMenuItem();
            hợpĐồngToolStripMenuItem = new ToolStripMenuItem();
            đóngTiềnToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, tìnhTrạngPhòngToolStripMenuItem, đóngTiềnToolStripMenuItem, hóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(357, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(128, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { qLSinhViênToolStripMenuItem, qLPhòngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // qLSinhViênToolStripMenuItem
            // 
            qLSinhViênToolStripMenuItem.Name = "qLSinhViênToolStripMenuItem";
            qLSinhViênToolStripMenuItem.Size = new Size(140, 22);
            qLSinhViênToolStripMenuItem.Text = "QL Sinh viên";
            qLSinhViênToolStripMenuItem.Click += qLSinhViênToolStripMenuItem_Click;
            // 
            // qLPhòngToolStripMenuItem
            // 
            qLPhòngToolStripMenuItem.Name = "qLPhòngToolStripMenuItem";
            qLPhòngToolStripMenuItem.Size = new Size(140, 22);
            qLPhòngToolStripMenuItem.Text = "QL Phòng";
            qLPhòngToolStripMenuItem.Click += qLPhòngToolStripMenuItem_Click;
            // 
            // tìnhTrạngPhòngToolStripMenuItem
            // 
            tìnhTrạngPhòngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phòngToolStripMenuItem, hợpĐồngToolStripMenuItem });
            tìnhTrạngPhòngToolStripMenuItem.Name = "tìnhTrạngPhòngToolStripMenuItem";
            tìnhTrạngPhòngToolStripMenuItem.Size = new Size(73, 20);
            tìnhTrạngPhòngToolStripMenuItem.Text = "Tình trạng";
            // 
            // phòngToolStripMenuItem
            // 
            phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            phòngToolStripMenuItem.Size = new Size(128, 22);
            phòngToolStripMenuItem.Text = "Phòng";
            phòngToolStripMenuItem.Click += phòngToolStripMenuItem_Click;
            // 
            // hợpĐồngToolStripMenuItem
            // 
            hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            hợpĐồngToolStripMenuItem.Size = new Size(128, 22);
            hợpĐồngToolStripMenuItem.Text = "Hợp đồng";
            hợpĐồngToolStripMenuItem.Click += hợpĐồngToolStripMenuItem_Click;
            // 
            // đóngTiềnToolStripMenuItem
            // 
            đóngTiềnToolStripMenuItem.Name = "đóngTiềnToolStripMenuItem";
            đóngTiềnToolStripMenuItem.Size = new Size(71, 20);
            đóngTiềnToolStripMenuItem.Text = "Đóng tiền";
            đóngTiềnToolStripMenuItem.Click += đóngTiềnToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(65, 20);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // Giaodien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.a2_WGEM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(357, 459);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Giaodien";
            Text = "Giao diện";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem qLSinhViênToolStripMenuItem;
        private ToolStripMenuItem qLPhòngToolStripMenuItem;
        private ToolStripMenuItem tìnhTrạngPhòngToolStripMenuItem;
        private ToolStripMenuItem đóngTiềnToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem phòngToolStripMenuItem;
        private ToolStripMenuItem hợpĐồngToolStripMenuItem;
    }
}