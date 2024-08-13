
using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_KTX
{
    public class DataAccessLayer
    {
        private readonly string connectionString = "Data Source=LAPTOP-NCNJOQ5A\\SQLEXPRESS;Initial Catalog=QL_KTX;Integrated Security=True";


        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }
    }
}
