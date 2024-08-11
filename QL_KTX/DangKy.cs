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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }


        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }
    }
}
