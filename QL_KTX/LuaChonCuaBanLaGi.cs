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
    public partial class LuaChonCuaBanLaGi : Form
    {
        public LuaChonCuaBanLaGi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhongThuGian ql = new PhongThuGian();
            this.Hide();
            ql.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DangNhap ql = new DangNhap();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
