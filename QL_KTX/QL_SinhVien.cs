namespace QL_KTX
{
    public partial class QL_SinhVien : Form
    {
        public QL_SinhVien()
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
