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
            ql.ShowDialog();
        }

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong ql = new QL_Phong();
            this.Hide();
            ql.ShowDialog();
        }

        private void tìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTrangPhong tt = new TinhTrangPhong();
            this.Hide();
            tt.ShowDialog();
        }

        private void đóngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dongtienphong dt = new Dongtienphong();
            this.Hide();
            dt.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon hd = new Hoadon();
            this.Hide();
            hd.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTrangPhong tt = new TinhTrangPhong();
            this.Hide();
            tt.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            this.Hide();
            hd.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
