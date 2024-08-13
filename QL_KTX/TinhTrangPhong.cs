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
    public partial class TinhTrangPhong : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();
        public TinhTrangPhong()
        {
            InitializeComponent();
            comboBoxTòa.SelectedIndexChanged += comboBoxTòa_SelectedIndexChanged;
            buttonKiểmTra.Click += buttonKiểmTra_Click;
        }



        private void comboBoxSốPhòng_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void buttonKiểmTra_Click(object sender, EventArgs e)
        {
            if (comboBoxTòa.SelectedValue != null && comboBoxSốPhòng.SelectedValue != null)
            {
                string selectedToa = comboBoxTòa.SelectedValue.ToString();
                int selectedPhongID = (int)comboBoxSốPhòng.SelectedValue;

                string query = "SELECT Toa, SoPhong, GiaTien, SoNguoi " +
                               "FROM Phong " +
                               "WHERE Toa = @Toa AND PhongID = @PhongID";

                SqlParameter[] parameters = {
            new SqlParameter("@Toa", selectedToa),
            new SqlParameter("@PhongID", selectedPhongID)
        };

                DataTable dt = dal.ExecuteQuery(query, parameters);
                dataGridViewTìnhTrạngPhòng.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho phòng này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Tòa và Số Phòng.");
            }
        }

        private void dataGridViewTìnhTrạngPhòng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Giaodien ql = new Giaodien();
            this.Hide();
            ql.ShowDialog();
        }

        private void TinhTrangPhong_Load(object sender, EventArgs e)
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
