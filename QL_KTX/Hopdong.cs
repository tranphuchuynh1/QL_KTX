using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_KTX
{
    public partial class HopDong : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();
        private byte[] imageBytes;
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            LoadHopDongData();
        }
        private void LoadHopDongData()
        {
            string query = @"
             SELECT hd.HopDongID, hd.MSSV, hd.HinhAnh ,sv.HoTen, 
               CASE 
                   WHEN sv.GioiTinh = 1 THEN N'Nam' 
                   ELSE N'Nữ' 
               END AS GioiTinh, sv.DiaChi , sv.SoDienThoai , 
               p.Toa, p.SoPhong, hd.NgayBatDau, hd.NgayKetThuc, hd.GhiChu
             FROM HopDong hd
             INNER JOIN SinhVien sv ON hd.MSSV = sv.MSSV
             INNER JOIN Phong p ON hd.PhongID = p.PhongID";
            DataTable dt = dal.ExecuteQuery(query);
            dataGridViewHợpĐồng.DataSource = dt;
        }




        private void comboBoxToa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedToa = comboBoxToa.Text;
            if (!string.IsNullOrEmpty(selectedToa))
            {
                LoadPhongForToa(selectedToa);
            }
        }
        private void LoadPhongForToa(string toa)
        {
            string query = "SELECT SoPhong FROM Phong WHERE Toa = @Toa";
            SqlParameter[] parameters = {
        new SqlParameter("@Toa", toa)
    };

            DataTable dt = dal.ExecuteQuery(query, parameters);
            comboBoxSốPhòng.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBoxSốPhòng.Items.Add(row["SoPhong"].ToString());
            }
        }

        private void comboBoxSốPhòng_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhong = comboBoxSốPhòng.Text;
            if (!string.IsNullOrEmpty(selectedPhong))
            {
                LoadMSSVForPhong(selectedPhong);
            }
        }
        private void LoadMSSVForPhong(string phong)
        {
            string query = "SELECT MSSV FROM SinhVien WHERE Phong = @Phong";
            SqlParameter[] parameters = {
        new SqlParameter("@Phong", phong)
    };

            DataTable dt = dal.ExecuteQuery(query, parameters);
            comboBoxMSSV.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBoxMSSV.Items.Add(row["MSSV"].ToString());
            }
        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {

            string mssv = comboBoxMSSV.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxSốPhòng.Text;
            DateTime ngayBatDau = dateTimePickerNgàyBắtĐầu.Value;
            DateTime ngayKetThuc = dateTimePickerNgàyKếtThúc.Value;
            string ghiChu = textBoxGhiChú.Text;

            byte[] imageBytes = this.imageBytes; // Lấy ảnh đã chọn từ biến toàn cục

            // Kiểm tra imageBytes có phải là null không
            if (imageBytes == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh trước khi thêm hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hợp đồng đã tồn tại
            string checkQuery = "SELECT COUNT(*) FROM HopDong WHERE MSSV = @MSSV AND PhongID = (SELECT PhongID FROM Phong WHERE Toa = @Toa AND SoPhong = @Phong)";
            SqlParameter[] checkParams = {
        new SqlParameter("@MSSV", mssv),
        new SqlParameter("@Toa", toa),
        new SqlParameter("@Phong", phong)
    };

            int count = Convert.ToInt32(dal.ExecuteScalar(checkQuery, checkParams));

            if (count > 0)
            {
                MessageBox.Show("Bạn đã có hợp đồng này trong danh sách bên dưới rồi, vui lòng thêm hợp đồng mới nhé ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm hợp đồng mới
                string insertQuery = "INSERT INTO HopDong (MSSV, PhongID, NgayBatDau, NgayKetThuc, GhiChu, HinhAnh) VALUES " +
                                     "(@MSSV, (SELECT PhongID FROM Phong WHERE Toa = @Toa AND SoPhong = @Phong), @NgayBatDau, @NgayKetThuc, @GhiChu, @HinhAnh)";
                SqlParameter[] insertParams = {
            new SqlParameter("@MSSV", mssv),
            new SqlParameter("@Toa", toa),
            new SqlParameter("@Phong", phong),
            new SqlParameter("@NgayBatDau", ngayBatDau),
            new SqlParameter("@NgayKetThuc", ngayKetThuc),
            new SqlParameter("@GhiChu", ghiChu),
            new SqlParameter("@HinhAnh", (object)imageBytes ?? DBNull.Value),
        };

                dal.ExecuteNonQuery(insertQuery, insertParams);
                MessageBox.Show("Thêm hợp đồng thành công!");
                LoadHopDongData();
            }
        }

        private void buttonSửa_Click(object sender, EventArgs e)
        {
            string mssv = comboBoxMSSV.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxSốPhòng.Text;
            DateTime ngayBatDau = dateTimePickerNgàyBắtĐầu.Value;
            DateTime ngayKetThuc = dateTimePickerNgàyKếtThúc.Value;
            string ghiChu = textBoxGhiChú.Text;

            byte[] imageBytes = this.imageBytes; // Lấy ảnh đã chọn từ biến toàn cục


            string query = "UPDATE HopDong SET NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, GhiChu = @GhiChu, HinhAnh = @HinhAnh " +
                           "WHERE MSSV = @MSSV AND PhongID = (SELECT PhongID FROM Phong WHERE Toa = @Toa AND SoPhong = @Phong)";
            SqlParameter[] parameters = {
            new SqlParameter("@MSSV", mssv),
            new SqlParameter("@Toa", toa),
            new SqlParameter("@Phong", phong),
            new SqlParameter("@NgayBatDau", ngayBatDau),
            new SqlParameter("@NgayKetThuc", ngayKetThuc),
            new SqlParameter("@GhiChu", ghiChu),
            new SqlParameter("@HinhAnh", imageBytes ?? (object)DBNull.Value),
             };

            dal.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Sửa hợp đồng thành công!");
            LoadHopDongData();
        }

        private void buttonXóa_Click(object sender, EventArgs e)
        {
            string mssv = comboBoxMSSV.Text;
            string toa = comboBoxToa.Text;
            string phong = comboBoxSốPhòng.Text;

            string query = "DELETE FROM HopDong WHERE MSSV = @MSSV AND PhongID = (SELECT PhongID FROM Phong WHERE Toa = @Toa AND SoPhong = @Phong)";
            SqlParameter[] parameters = {
        new SqlParameter("@MSSV", mssv),
        new SqlParameter("@Toa", toa),
        new SqlParameter("@Phong", phong)
          };

            dal.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Xóa hợp đồng thành công!");
            LoadHopDongData();
        }

        private void dataGridViewHợpĐồng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewHợpĐồng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHợpĐồng.Rows[e.RowIndex];

                // Kiểm tra và xử lý dữ liệu trước khi gán vào các control
                comboBoxToa.Text = row.Cells["Toa"].Value != DBNull.Value ? row.Cells["Toa"].Value.ToString() : string.Empty;
                comboBoxSốPhòng.Text = row.Cells["SoPhong"].Value != DBNull.Value ? row.Cells["SoPhong"].Value.ToString() : string.Empty;
                comboBoxMSSV.Text = row.Cells["MSSV"].Value != DBNull.Value ? row.Cells["MSSV"].Value.ToString() : string.Empty;
                dateTimePickerNgàyBắtĐầu.Value = row.Cells["NgayBatDau"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayBatDau"].Value) : DateTime.Now;
                dateTimePickerNgàyKếtThúc.Value = row.Cells["NgayKetThuc"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayKetThuc"].Value) : DateTime.Now;
                textBoxGhiChú.Text = row.Cells["GhiChu"].Value != DBNull.Value ? row.Cells["GhiChu"].Value.ToString() : string.Empty;
                // Load image if available
                byte[] imageBytes = row.Cells["HinhAnh"].Value as byte[];
                if (row.Cells["HinhAnh"].Value != DBNull.Value)
                {
                    imageBytes = (byte[])row.Cells["HinhAnh"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxAnhThe.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAnhThe.Image = null;
                }


                // Tải lại danh sách phòng dựa trên tòa nhà đã chọn
                LoadPhongForToa(comboBoxToa.Text);

                // Tải lại danh sách sinh viên dựa trên phòng đã chọn
                LoadMSSVForPhong(comboBoxSốPhòng.Text);
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void buttonChonTep_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn tệp
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn Ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc ảnh từ tệp
                    string filePath = openFileDialog.FileName;
                    pictureBoxAnhThe.Image = Image.FromFile(filePath);

                    // Chuyển đổi ảnh thành mảng byte để lưu vào cơ sở dữ liệu
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxAnhThe.Image.Save(ms, pictureBoxAnhThe.Image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        // Cập nhật ảnh vào biến toàn cục hoặc lưu vào database sau này
                        // Ví dụ lưu vào biến toàn cục (sẽ sử dụng để cập nhật trong cơ sở dữ liệu)
                        this.imageBytes = imageBytes;
                    }
                }
            }
        }

        private void pictureBoxAnhThe_Click(object sender, EventArgs e)
        {
            if (dataGridViewHợpĐồng.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewHợpĐồng.SelectedRows[0];
                int hopDongID = Convert.ToInt32(row.Cells["HopDongID"].Value);

                // Tải ảnh từ cơ sở dữ liệu
                string query = "SELECT HinhAnh FROM HopDong WHERE HopDongID = @HopDongID";
                SqlParameter[] parameters = {
            new SqlParameter("@HopDongID", hopDongID)
        };

                byte[] imageBytes = (byte[])dal.ExecuteScalar(query, parameters);

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxAnhThe.Image = Image.FromStream(ms);
                    }
                }
            }
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
            DangNhap ql = new DangNhap();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
