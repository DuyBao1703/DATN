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
    public class ChiTietHoaDon_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadChiTietHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietHoaDon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemChiTietHoaDon(ChiTietHoaDon ct)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ChiTietHoaDon VALUES (@MaCTHD, @MaHD, @MaXe, @GiaBan, @SoLuong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTHD", ct.MaCTHD);
                cmd.Parameters.AddWithValue("@MaHD", ct.MaHD);
                cmd.Parameters.AddWithValue("@MaXe", ct.MaXe);
                cmd.Parameters.AddWithValue("@GiaBan", ct.GiaBan);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaChiTietHoaDon(ChiTietHoaDon ct)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE ChiTietHoaDon SET MaHD = @MaHD, MaXe = @MaXe, GiaBan = @GiaBan, SoLuong = @SoLuong WHERE MaCTHD = @MaCTHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTHD", ct.MaCTHD);
                cmd.Parameters.AddWithValue("@MaHD", ct.MaHD);
                cmd.Parameters.AddWithValue("@MaXe", ct.MaXe);
                cmd.Parameters.AddWithValue("@GiaBan", ct.GiaBan);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaChiTietHoaDon(string maCTHD)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietHoaDon WHERE MaCTHD = @MaCTHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTHD", maCTHD);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

}
