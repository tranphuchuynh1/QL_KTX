using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class Giaodien : Form
    {
        public Giaodien()
        {
            InitializeComponent();
        }

        private void qLSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_SinhVien ql = new QL_SinhVien();
            this.Hide();
            ql.FormClosed += (s, agrs) => this.Close();
            ql.Show();
        }

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong ql = new QL_Phong();
            this.Hide();
            ql.FormClosed += (s, agrs) => this.Close();
            ql.Show();
        }

        private void tìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTrangPhong tt = new TinhTrangPhong();
            this.Hide();
            tt.FormClosed += (s, agrs) => this.Close();
            tt.Show();
        }

        private void đóngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dongtienphong dt = new Dongtienphong();
            this.Hide();
            dt.FormClosed += (s, agrs) => this.Close();
            dt.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.FormClosed += (s, agrs) => this.Close();
            dn.Show();

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon hd = new Hoadon();
            this.Hide();
            hd.FormClosed += (s, agrs) => this.Close();
            hd.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTrangPhong tt = new TinhTrangPhong();
            this.Hide();
            tt.FormClosed += (s, agrs) => this.Close();
            tt.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong();
            this.Hide();
            hd.FormClosed += (s, agrs) => this.Close();
            hd.Show();
        }
    }
}
