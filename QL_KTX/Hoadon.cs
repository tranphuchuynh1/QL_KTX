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
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Giaodien gd = new Giaodien();
            this.Hide();
            gd.FormClosed += (s, agrs) => this.Close();
            gd.Show();
        }
    }
}
