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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {

            QL_SinhVien f = new QL_SinhVien();
            f.Show();
            this.Hide();

        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();
            this.Hide();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
