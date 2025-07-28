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
    public class LoaiXeMay_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadLoaiXeMay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LoaiXeMay";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemLoaiXe(LoaiXeMay lx)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LoaiXeMay VALUES (@MaLoaiXe, @TenLoaiXe, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiXe", lx.MaLoaiXe);
                cmd.Parameters.AddWithValue("@TenLoaiXe", lx.TenLoaiXe);
                cmd.Parameters.AddWithValue("@MoTa", lx.MoTa ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaLoaiXe(LoaiXeMay lx)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE LoaiXeMay SET TenLoaiXe = @TenLoaiXe, MoTa = @MoTa WHERE MaLoaiXe = @MaLoaiXe";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiXe", lx.MaLoaiXe);
                cmd.Parameters.AddWithValue("@TenLoaiXe", lx.TenLoaiXe);
                cmd.Parameters.AddWithValue("@MoTa", lx.MoTa ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaLoaiXe(string maLoaiXe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM LoaiXeMay WHERE MaLoaiXe = @MaLoaiXe";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiXe", maLoaiXe);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
