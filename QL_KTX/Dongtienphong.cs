using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class Dongtienphong : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public Dongtienphong()
        {
            InitializeComponent();
            comboBoxTòa.SelectedIndexChanged += new EventHandler(comboBoxTòa_SelectedIndexChanged);
        }



        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void comboBoxTòa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tòa nhà đã chọn
            string selectedToa = comboBoxTòa.Text;
            if (!string.IsNullOrEmpty(selectedToa))
            {
                // Tải các số phòng tương ứng cho tòa nhà đã chọn
                LoadPhongForToa(selectedToa);
            }
        }
        private void LoadPhongForToa(string toa)
        {
            string query = "SELECT PhongID, SoPhong FROM Phong WHERE Toa = @Toa";
            SqlParameter[] parameters = {
            new SqlParameter("@Toa", toa)
        };

            try
            {
                DataTable dt = dal.ExecuteQuery(query, parameters);
                comboBoxSốPhòng.DataSource = dt;
                comboBoxSốPhòng.DisplayMember = "SoPhong";
                comboBoxSốPhòng.ValueMember = "PhongID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số phòng: " + ex.Message);
            }
        }

        private void comboBoxSốPhòng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTiềnĐóng_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgàyĐóng_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonThanhToán_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            // string mssv = textBoxMSSV.Text;
            int phongID = (int)comboBoxSốPhòng.SelectedValue;
            string tienDong = textBoxTiềnĐóng.Text;
            DateTime ngayDong = dateTimePickerNgàyĐóng.Value;

            // Kiểm tra tính hợp lệ của dữ liệu
            /*  if (string.IsNullOrWhiteSpace(mssv) ||
                  phongID <= 0 ||
                  !decimal.TryParse(tienDong, out decimal soTien) ||
                  ngayDong == default(DateTime))
              {
                  MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                  return;
              }*/

            // Chuẩn bị truy vấn SQL
            string query = "INSERT INTO ThanhToan ( PhongID, SoTien, NgayThanhToan) " +
                           "VALUES ( @PhongID, @SoTien, @NgayThanhToan)";

            SqlParameter[] parameters = {
       //  new SqlParameter("@MSSV", mssv),
        new SqlParameter("@PhongID", phongID),
        new SqlParameter("@SoTien", tienDong),
        new SqlParameter("@NgayThanhToan", ngayDong)
    };

            try
            {
                // Thực hiện truy vấn
                dal.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thanh toán thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
    }
}
