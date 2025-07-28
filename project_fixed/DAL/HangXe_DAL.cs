using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
//Install - Package System.Data.SqlClient
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATN
{
    public class HangXe_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadHangXe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM HangXe";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemHangXe(HangXe hx)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HangXe VALUES (@MaHang, @TenHang, @QuocGia, @NamThanhLap)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", hx.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", hx.TenHang);
                cmd.Parameters.AddWithValue("@QuocGia", hx.QuocGia);
                cmd.Parameters.AddWithValue("@NamThanhLap", hx.NamThanhLap);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaHangXe(HangXe hx)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE HangXe SET TenHang = @TenHang, QuocGia = @QuocGia, NamThanhLap = @NamThanhLap WHERE MaHang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", hx.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", hx.TenHang);
                cmd.Parameters.AddWithValue("@QuocGia", hx.QuocGia);
                cmd.Parameters.AddWithValue("@NamThanhLap", hx.NamThanhLap);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaHangXe(string maHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM HangXe WHERE MaHang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", maHang);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
