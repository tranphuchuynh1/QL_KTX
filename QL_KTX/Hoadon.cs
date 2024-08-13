using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class Hoadon : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public Hoadon()
        {
            InitializeComponent();
            comboBoxTòa.SelectedIndexChanged += comboBoxTòa_SelectedIndexChanged;
            buttonKiểmTra.Click += buttonKiểmTra_Click;

        }


        private void btnThoát_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void comboBoxTòa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedToa = comboBoxTòa.SelectedValue.ToString();
            string query = "SELECT PhongID, SoPhong FROM Phong WHERE Toa = @Toa";
            SqlParameter[] parameters = {
        new SqlParameter("@Toa", selectedToa)
    };
            DataTable dt = dal.ExecuteQuery(query, parameters);

            comboBoxSốPhòng.DataSource = dt;
            comboBoxSốPhòng.DisplayMember = "SoPhong";
            comboBoxSốPhòng.ValueMember = "PhongID";
        }

        private void comboBoxSốPhòng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonKiểmTra_Click(object sender, EventArgs e)
        {
            if (comboBoxTòa.SelectedValue != null && comboBoxSốPhòng.SelectedValue != null)
            {
                string selectedToa = comboBoxTòa.SelectedValue.ToString();
                int selectedPhongID = (int)comboBoxSốPhòng.SelectedValue;

                string query = "SELECT Phong.Toa, Phong.SoPhong, ThanhToan.SoTien, ThanhToan.NgayThanhToan " +
                               "FROM ThanhToan " +
                               "INNER JOIN Phong ON ThanhToan.PhongID = Phong.PhongID " +
                               "WHERE Phong.Toa = @Toa AND Phong.PhongID = @PhongID";

                SqlParameter[] parameters = {
            new SqlParameter("@Toa", selectedToa),
            new SqlParameter("@PhongID", selectedPhongID)
        };

                DataTable dt = dal.ExecuteQuery(query, parameters);
                dataGridViewHóaĐơn.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thanh toán cho phòng này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Tòa và Số Phòng.");
            }
        }

        private void dataGridViewHóaĐơn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            LoadToaData();
        }
        private void LoadToaData()
        {
            string query = "SELECT DISTINCT Toa FROM Phong";
            DataTable dt = dal.ExecuteQuery(query);

            comboBoxTòa.DataSource = dt;
            comboBoxTòa.DisplayMember = "Toa";
            comboBoxTòa.ValueMember = "Toa";
        }
    }
}
