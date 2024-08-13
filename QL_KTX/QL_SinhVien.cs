using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class QL_SinhVien : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public QL_SinhVien()
        {
            InitializeComponent();
            comboBoxToa.SelectedIndexChanged += new EventHandler(comboBoxToa_SelectedIndexChanged);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string mssv = textboxMSSV.Text;
            string hoTen = textboxHọVàTên.Text;
            string ngaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            bool gioiTinh = radioButtonNam.Checked;
            string diaChi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxPhong.Text;

            string query = "INSERT INTO SinhVien (MSSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Toa, Phong) " +
                           "VALUES (@MSSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @Toa, @Phong)";
            SqlParameter[] parameters = {
                new SqlParameter("@MSSV", mssv),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh ? 1 : 0),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@Toa", toa),
                new SqlParameter("@Phong", phong)
            };

            dal.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Thêm sinh viên thành công!");
            LoadSinhVienData();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string mssv = textboxMSSV.Text;

            string query = "DELETE FROM SinhVien WHERE MSSV = @MSSV";
            SqlParameter[] parameters = {
                new SqlParameter("@MSSV", mssv)
            };

            dal.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Xóa sinh viên thành công!");
            LoadSinhVienData();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string mssv = textboxMSSV.Text;
            string hoTen = textboxHọVàTên.Text;
            string ngaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            bool gioiTinh = radioButtonNam.Checked;
            string diaChi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxPhong.Text;

            string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                           "DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Toa = @Toa, Phong = @Phong " +
                           "WHERE MSSV = @MSSV";
            SqlParameter[] parameters = {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh ? 1 : 0),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@Toa", toa),
                new SqlParameter("@Phong", phong),
                new SqlParameter("@MSSV", mssv)
            };

            dal.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Sửa thông tin sinh viên thành công!");
            LoadSinhVienData();
        }

        private void LoadSinhVienData()
        {
            string query = "SELECT * FROM SinhVien";
            DataTable dt = dal.ExecuteQuery(query);
            dataGridViewQuảnLýSinhViên.DataSource = dt;
        }

        private void QL_SinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVienData();
        }

        private void comboBoxToa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected building
            string selectedToa = comboBoxToa.Text;
            if (!string.IsNullOrEmpty(selectedToa))
            {
                // Load the corresponding rooms
                LoadPhongForToa(selectedToa);
            }
        }
        private void LoadPhongForToa(string toa)
        {
            string query = "SELECT SoPhong FROM Phong WHERE Toa = @Toa";
            SqlParameter[] parameters = {
            new SqlParameter("@Toa", toa)
        };

            try
            {
                DataTable dt = dal.ExecuteQuery(query, parameters);
                comboBoxPhong.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxPhong.Items.Add(row["SoPhong"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải phòng: " + ex.Message);
            }
        }

       

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
