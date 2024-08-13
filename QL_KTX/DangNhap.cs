using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class DangNhap : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void buttonĐăngNhập_Click(object sender, EventArgs e)
        {
            string username = textBoxTàiKhoản.Text;
            string password = textBoxMậtKhẩu.Text;

            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password)
            };

            int result = (int)dal.ExecuteScalar(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Giaodien mainForm = new Giaodien();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
        }

        private void buttonChuyểnQuaFormĐăngKý_Click(object sender, EventArgs e)
        {
            DangKy registerForm = new DangKy();
            this.Hide();
            registerForm.Show();
        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
