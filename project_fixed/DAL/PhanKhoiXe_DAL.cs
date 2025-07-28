using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATN
{

    public class PhanKhoiXe_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadPhanKhoiXe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhanKhoiXe";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemPhanKhoiXe(PhanKhoiXe pk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PhanKhoiXe VALUES (@MaPK, @DungTichCC, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPK", pk.MaPhanKhoi);
                cmd.Parameters.AddWithValue("@DungTichCC", pk.DungTichCC);
                cmd.Parameters.AddWithValue("@MoTa", pk.MoTa ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaPhanKhoiXe(PhanKhoiXe pk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE PhanKhoiXe SET DungTichCC = @DungTichCC, MoTa = @MoTa WHERE MaPhanKhoi = @MaPK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPK", pk.MaPhanKhoi);
                cmd.Parameters.AddWithValue("@DungTichCC", pk.DungTichCC);
                cmd.Parameters.AddWithValue("@MoTa", pk.MoTa ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaPhanKhoiXe(string maPK)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PhanKhoiXe WHERE MaPhanKhoi = @MaPK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPK", maPK);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}