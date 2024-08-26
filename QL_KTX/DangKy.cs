using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QL_KTX
{
    public partial class DangKy : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public DangKy()
        {
            InitializeComponent();
        }

        private void buttonĐăngKý_Click(object sender, EventArgs e)
        {
            string username = textBoxTàiKhoản.Text;
            string password = textBoxMậtKhẩu.Text;
            string confirmPassword = textBoxNhậpLạiMậtKhẩu.Text;

            // Kiểm tra mật khẩu
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa 6 ký tự trở lên !");
                return;
            }

            if (!Regex.IsMatch(password, @"[A-Za-z]") || !Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("Mật khẩu phải chứa cả chữ và số!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@TenDangNhap, @MatKhau)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password)
            };

            try
            {
                dal.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Đăng ký thành công!");
                this.Hide();
                DangNhap loginForm = new DangNhap();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message);
            }
        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DangNhap ou = new DangNhap();
            this.Hide();
            ou.Show();
        }
    }
}


/*
 * using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QL_KTX
{
    public partial class DangKy : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public DangKy()
        {
            InitializeComponent();
        }

        private void buttonĐăngKý_Click(object sender, EventArgs e)
        {
            string username = textBoxTàiKhoản.Text;
            string password = textBoxMậtKhẩu.Text;
            string confirmPassword = textBoxNhậpLạiMậtKhẩu.Text;

            // Kiểm tra mật khẩu
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }

            if (!Regex.IsMatch(password, @"[A-Za-z]") || !Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("Mật khẩu phải chứa cả chữ và số!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@TenDangNhap, @MatKhau)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password)
            };

            try
            {
                dal.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Đăng ký thành công!");
                this.Hide();
                DangNhap loginForm = new DangNhap();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message);
            }
        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DangNhap ou = new DangNhap();
            this.Hide();
            ou.Show();
        }
    }
}

 */