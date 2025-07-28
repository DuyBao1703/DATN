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
    public class TrangThaiXe_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

     
        public DataTable LoadTrangThaiXe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TrangThaiXe";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemTrangThaiXe(TrangThaiXe tt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TrangThaiXe VALUES (@MaTT, @TenTT, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTT", tt.MaTrangThaiXe);
                cmd.Parameters.AddWithValue("@TenTT", tt.TenTrangThaiXe);
                cmd.Parameters.AddWithValue("@GhiChu", tt.GhiChu ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaTrangThaiXe(TrangThaiXe tt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE TrangThaiXe 
                             SET TenTrangThaiXe = @TenTT, GhiChu = @GhiChu 
                             WHERE MaTrangThaiXe = @MaTT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTT", tt.MaTrangThaiXe);
                cmd.Parameters.AddWithValue("@TenTT", tt.TenTrangThaiXe);
                cmd.Parameters.AddWithValue("@GhiChu", tt.GhiChu ?? (object)DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaTrangThaiXe(string maTT)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TrangThaiXe WHERE MaTrangThaiXe = @MaTT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTT", maTT);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
