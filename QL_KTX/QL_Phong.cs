using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class QL_Phong : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public QL_Phong()
        {
            InitializeComponent();
            this.Load += new EventHandler(QL_Phong_Load);

        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            string toa = comboBoxTòa.Text;
            string soPhong = comboBoxSốPhòng.Text;

            // Chuyển đổi giaTien và soNguoi thành kiểu dữ liệu phù hợp
            if (!decimal.TryParse(textBoxGiáTiền.Text, out decimal giaTien) || !int.TryParse(textBoxSốNgười.Text, out int soNguoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin  ^^");
                return;
            }

            // Kiểm tra trùng số phòng trong cùng một tòa
            string checkQuery = "SELECT COUNT(*) FROM Phong WHERE Toa = @Toa AND SoPhong = @SoPhong";
            SqlParameter[] checkParameters = {
             new SqlParameter("@Toa", toa),
                new SqlParameter("@SoPhong", soPhong)
            };

            int roomExists = (int)dal.ExecuteScalar(checkQuery, checkParameters);
            if (roomExists > 0)
            {
                MessageBox.Show("Phòng này đã được thêm!");
                return;
            }

            // Kiểm tra số người không được vượt quá 4
            if (soNguoi > 4)
            {
                MessageBox.Show("Phòng này đã đầy!");
                return;
            }

            string query = "INSERT INTO Phong (Toa, SoPhong, GiaTien, SoNguoi) VALUES (@Toa, @SoPhong, @GiaTien, @SoNguoi)";
            SqlParameter[] parameters = {
        new SqlParameter("@Toa", toa),
        new SqlParameter("@SoPhong", soPhong),
        new SqlParameter("@GiaTien", giaTien),
        new SqlParameter("@SoNguoi", soNguoi)
             };

            try
            {
                dal.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm phòng thành công!");
                LoadPhongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phòng thất bại: " + ex.Message);
            }
        }



        private void buttonSửa_Click(object sender, EventArgs e)
        {
            string toa = comboBoxTòa.Text;
            string soPhong = comboBoxSốPhòng.Text;

            // Chuyển đổi giaTien và soNguoi thành kiểu dữ liệu phù hợp
            if (!decimal.TryParse(textBoxGiáTiền.Text, out decimal giaTien) || !int.TryParse(textBoxSốNgười.Text, out int soNguoi))
            {
                MessageBox.Show("Vui lòng nhập giá tiền và số người hợp lệ.");
                return;
            }

            // Kiểm tra số người không được vượt quá 4
            if (soNguoi > 4)
            {
                MessageBox.Show("Phòng này đã đầy!");
                return;
            }

            string query = "UPDATE Phong SET Toa = @Toa, GiaTien = @GiaTien, SoNguoi = @SoNguoi WHERE SoPhong = @SoPhong";
            SqlParameter[] parameters = {
             new SqlParameter("@Toa", toa),
             new SqlParameter("@GiaTien", giaTien),
                new SqlParameter("@SoNguoi", soNguoi),
             new SqlParameter("@SoPhong", soPhong)
             };

            try
            {
                int rowsAffected = dal.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng để sửa.");
                }
                LoadPhongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa phòng thất bại: " + ex.Message);
            }
        }

        private void LoadPhongData()
        {
            string query = "SELECT * FROM Phong";
            DataTable dt = dal.ExecuteQuery(query);
            dataGridViewQuảnLýPhòng.DataSource = dt;
        }



        private void dataGridViewQuảnLýPhòng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQuảnLýPhòng.Rows[e.RowIndex];
                comboBoxTòa.Text = row.Cells["Toa"].Value.ToString();
                comboBoxSốPhòng.Text = row.Cells["SoPhong"].Value.ToString();
                textBoxGiáTiền.Text = row.Cells["GiaTien"].Value.ToString();
                textBoxSốNgười.Text = row.Cells["SoNguoi"].Value.ToString();
            }
        }

        private void buttonXóa_Click(object sender, EventArgs e)
        {
            string soPhong = comboBoxSốPhòng.Text;

            // Kiểm tra nếu soPhong không rỗng
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng chọn số phòng cần xóa.");
                return;
            }

            string query = "DELETE FROM Phong WHERE SoPhong = @SoPhong";
            SqlParameter[] parameters = {
        new SqlParameter("@SoPhong", soPhong)
    };

            try
            {
                int rowsAffected = dal.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng để xóa.");
                }
                LoadPhongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa phòng thất bại: " + ex.Message);
            }
        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void QL_Phong_Load(object sender, EventArgs e)
        {
            LoadPhongData();
            dataGridViewQuảnLýPhòng.CellClick += new DataGridViewCellEventHandler(dataGridViewQuảnLýPhòng_CellClick);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HopDong ql = new HopDong();
            this.Hide();
            ql.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QL_SinhVien ql = new QL_SinhVien();
            this.Hide();
            ql.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_Phong ql = new QL_Phong();
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            LuaChonCuaBanLaGi ql = new LuaChonCuaBanLaGi();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
