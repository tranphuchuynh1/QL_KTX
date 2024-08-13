using System.Data;
using System.Data.SqlClient;

namespace QL_KTX
{
    public partial class HopDong : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            LoadMSSVData();
            LoadPhongData();
            LoadHopDongData();
        }

        private void LoadHopDongData()
        {
            if (dataGridViewHợpĐồng == null)
            {
                MessageBox.Show("Lỗi: dataGridViewHợpĐồng chưa được khởi tạo.");
                return;
            }

            string query = "SELECT HopDong.HopDongID, HopDong.MSSV, SinhVien.HoTen, HopDong.PhongID, Phong.SoPhong, HopDong.NgayBatDau, HopDong.NgayKetThuc, HopDong.GhiChu " +
                           "FROM HopDong " +
                           "INNER JOIN SinhVien ON HopDong.MSSV = SinhVien.MSSV " +
                           "INNER JOIN Phong ON HopDong.PhongID = Phong.PhongID";
            DataTable dt = dal.ExecuteQuery(query);
            dataGridViewHợpĐồng.DataSource = dt;
        }
        private void LoadMSSVData()
        {
            string query = "SELECT MSSV, HoTen FROM SinhVien";
            DataTable dt = dal.ExecuteQuery(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxMSSV.DataSource = dt;
                comboBoxMSSV.DisplayMember = "MSSV"; // Hiển thị MSSV trong comboBox
                comboBoxMSSV.ValueMember = "MSSV";   // Lấy MSSV làm giá trị chính
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào trong hệ thống.");
            }
        }

        private void LoadPhongData()
        {
            string query = "SELECT PhongID, SoPhong FROM Phong";
            DataTable dt = dal.ExecuteQuery(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxSốPhòng.DataSource = dt;
                comboBoxSốPhòng.DisplayMember = "SoPhong"; // Display room numbers
                comboBoxSốPhòng.ValueMember = "PhongID";   // Use PhongID as the value
            }
            else
            {
                MessageBox.Show("Không có phòng nào trong hệ thống.");
            }
        }



        private void buttonXóa_Click(object sender, EventArgs e)
        {
            if (dataGridViewHợpĐồng.SelectedRows.Count > 0)
            {
                int hopDongID = (int)dataGridViewHợpĐồng.SelectedRows[0].Cells["HopDongID"].Value;

                string query = "DELETE FROM HopDong WHERE HopDongID = @HopDongID";
                SqlParameter[] parameters = {
            new SqlParameter("@HopDongID", hopDongID)
                };

                try
                {
                    dal.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa hợp đồng thành công!");
                    LoadHopDongData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa hợp đồng thất bại: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để xóa.");
            }
        }






        private void buttonSửa_Click(object sender, EventArgs e)
        {
            if (dataGridViewHợpĐồng.SelectedRows.Count > 0)
            {
                // Get the selected HopDongID
                int hopDongID = (int)dataGridViewHợpĐồng.SelectedRows[0].Cells["HopDongID"].Value;

                // Get the new values from the form fields
                string mssv = comboBoxMSSV.SelectedValue.ToString();
                int phongID = (int)comboBoxSốPhòng.SelectedValue;
                string ngayBatDau = dateTimePickerNgàyBắtĐầu.Value.ToString("yyyy-MM-dd");
                string ngayKetThuc = dateTimePickerNgàyKếtThúc.Value.ToString("yyyy-MM-dd");
                string ghiChu = textBoxGhiChú.Text;

                // Update the database
                string query = "UPDATE HopDong SET MSSV = @MSSV, PhongID = @PhongID, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, GhiChu = @GhiChu " +
                               "WHERE HopDongID = @HopDongID";
                SqlParameter[] parameters = {
            new SqlParameter("@MSSV", mssv),
            new SqlParameter("@PhongID", phongID),
            new SqlParameter("@NgayBatDau", ngayBatDau),
            new SqlParameter("@NgayKetThuc", ngayKetThuc),
            new SqlParameter("@GhiChu", ghiChu),
            new SqlParameter("@HopDongID", hopDongID)
        };

                try
                {
                    dal.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Sửa hợp đồng thành công!");
                    LoadHopDongData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa hợp đồng thất bại: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để sửa.");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        /*private void dataGridViewHợpĐồng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHợpĐồng.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewHợpĐồng.SelectedRows[0];

                // Kiểm tra nếu cột không có giá trị null
                if (selectedRow.Cells["MSSV"].Value != null)
                    comboBoxMSSV.SelectedValue = selectedRow.Cells["MSSV"].Value.ToString();

                if (selectedRow.Cells["PhongID"].Value != null)
                    comboBoxSốPhòng.SelectedValue = selectedRow.Cells["PhongID"].Value;

                if (selectedRow.Cells["NgayBatDau"].Value != null)
                    dateTimePickerNgàyBắtĐầu.Value = Convert.ToDateTime(selectedRow.Cells["NgayBatDau"].Value);

                if (selectedRow.Cells["NgayKetThuc"].Value != null)
                    dateTimePickerNgàyKếtThúc.Value = Convert.ToDateTime(selectedRow.Cells["NgayKetThuc"].Value);

                if (selectedRow.Cells["GhiChu"].Value != null)
                    textBoxGhiChú.Text = selectedRow.Cells["GhiChu"].Value.ToString();
            }
        }*/

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            if (comboBoxMSSV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn MSSV.");
                return;
            }

            if (comboBoxSốPhòng.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Số Phòng.");
                return;
            }

            string mssv = comboBoxMSSV.Text;
            int phongID = Convert.ToInt32(comboBoxSốPhòng.SelectedValue); // Convert safely
            string ngayBatDau = dateTimePickerNgàyBắtĐầu.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dateTimePickerNgàyKếtThúc.Value.ToString("yyyy-MM-dd");
            string ghiChu = textBoxGhiChú.Text;

            string query = "INSERT INTO HopDong (MSSV, PhongID, NgayBatDau, NgayKetThuc, GhiChu) " +
                           "VALUES (@MSSV, @PhongID, @NgayBatDau, @NgayKetThuc, @GhiChu)";
            SqlParameter[] parameters = {
        new SqlParameter("@MSSV", mssv),
        new SqlParameter("@PhongID", phongID),
        new SqlParameter("@NgayBatDau", ngayBatDau),
        new SqlParameter("@NgayKetThuc", ngayKetThuc),
        new SqlParameter("@GhiChu", ghiChu)
    };

            try
            {
                dal.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm hợp đồng thành công!");
                LoadHopDongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hợp đồng thất bại: " + ex.Message);
            }
        }

        private void dataGridViewHợpĐồng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu có hàng nào được chọn
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewHợpĐồng.Rows[e.RowIndex];

                // Kiểm tra nếu các cột không có giá trị null và gán giá trị cho các điều khiển tương ứng
                if (selectedRow.Cells["MSSV"].Value != null)
                    comboBoxMSSV.SelectedValue = selectedRow.Cells["MSSV"].Value.ToString();

                if (selectedRow.Cells["PhongID"].Value != null)
                    comboBoxSốPhòng.SelectedValue = selectedRow.Cells["PhongID"].Value;

                if (selectedRow.Cells["NgayBatDau"].Value != null)
                    dateTimePickerNgàyBắtĐầu.Value = Convert.ToDateTime(selectedRow.Cells["NgayBatDau"].Value);

                if (selectedRow.Cells["NgayKetThuc"].Value != null)
                    dateTimePickerNgàyKếtThúc.Value = Convert.ToDateTime(selectedRow.Cells["NgayKetThuc"].Value);

                if (selectedRow.Cells["GhiChu"].Value != null)
                    textBoxGhiChú.Text = selectedRow.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}