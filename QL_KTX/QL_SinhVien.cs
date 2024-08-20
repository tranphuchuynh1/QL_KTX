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
            this.Load += new EventHandler(QL_SinhVien_Load);
            comboBoxToa.SelectedIndexChanged += new EventHandler(comboBoxToa_SelectedIndexChanged);
            dataGridViewQuảnLýSinhViên.CellClick += new DataGridViewCellEventHandler(dataGridViewQuảnLýSinhViên_CellClick);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

            string mssv = textboxMSSV.Text;

            // Check if MSSV already exists
            string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE MSSV = @MSSV";
            SqlParameter[] checkParameters = {
              new SqlParameter("@MSSV", mssv)
             };

            int count = (int)dal.ExecuteScalar(checkQuery, checkParameters);
            if (count > 0)
            {
                MessageBox.Show("Sinh viên này đã được thêm.");
                return;
            }
            string hoTen = textboxHọVàTên.Text;
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            if (ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                return;
            }
            bool gioiTinh = radioButtonNam.Checked;
            string diaChi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxPhong.Text;
            // Check if the room is full
            string checkRoomQuery = "SELECT COUNT(*) FROM SinhVien WHERE Toa = @Toa AND Phong = @Phong";
            SqlParameter[] roomParameters = {
             new SqlParameter("@Toa", toa),
            new SqlParameter("@Phong", phong)
            };

            int occupantsCount = (int)dal.ExecuteScalar(checkRoomQuery, roomParameters);
            if (occupantsCount >= 4)
            {
                MessageBox.Show("Phòng này đã đầy, vui lòng chọn phòng khác ^^");
                return;
            }



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
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            if (ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                return;
            }
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
            string query = "SELECT MSSV, HoTen, NgaySinh, CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS GioiTinh, DiaChi, SoDienThoai, Toa, Phong FROM SinhVien";
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

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewQuảnLýSinhViên_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridViewQuảnLýSinhViên.Rows[e.RowIndex];

                // Populate the text boxes with the selected row's data
                textboxMSSV.Text = row.Cells["MSSV"].Value != DBNull.Value ? row.Cells["MSSV"].Value.ToString() : string.Empty;
                textboxHọVàTên.Text = row.Cells["HoTen"].Value != DBNull.Value ? row.Cells["HoTen"].Value.ToString() : string.Empty;
                dateTimePickerNgaySinh.Value = row.Cells["NgaySinh"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgaySinh"].Value) : DateTime.Now;
                textBoxDiaChi.Text = row.Cells["DiaChi"].Value != DBNull.Value ? row.Cells["DiaChi"].Value.ToString() : string.Empty;
                textBoxSDT.Text = row.Cells["SoDienThoai"].Value != DBNull.Value ? row.Cells["SoDienThoai"].Value.ToString() : string.Empty;
                comboBoxToa.Text = row.Cells["Toa"].Value != DBNull.Value ? row.Cells["Toa"].Value.ToString() : string.Empty;
                comboBoxPhong.Text = row.Cells["Phong"].Value != DBNull.Value ? row.Cells["Phong"].Value.ToString() : string.Empty;

                // Set the radio buttons based on the gender value
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radioButtonNam.Checked = true;
                    radioButtonNu.Checked = false;
                }
                else
                {
                    radioButtonNam.Checked = false;
                    radioButtonNu.Checked = true;
                }

                // Optionally, load rooms for the selected building in case the rooms comboBox needs to be refreshed
                LoadPhongForToa(comboBoxToa.Text);
            }
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_Phong ql = new QL_Phong();
            this.Hide();
            ql.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_SinhVien ql = new QL_SinhVien();
            this.Hide();
            ql.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HopDong ql = new HopDong();
            this.Hide();
            ql.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dongtienphong ql = new Dongtienphong();
            this.Hide();
            ql.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hoadon ql = new Hoadon();
            this.Hide();
            ql.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TinhTrangPhong ql = new TinhTrangPhong();
            this.Hide();
            ql.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LuaChonCuaBanLaGi ql = new LuaChonCuaBanLaGi();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
