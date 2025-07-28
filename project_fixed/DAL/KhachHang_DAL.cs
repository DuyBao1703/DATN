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
    public class KhachHang_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO KhachHang VALUES 
                            (@MaKH, @TenKH, @SoDT, @DiaChi, @CCCD, @GioiTinh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDT", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE KhachHang SET TenKhachHang = @TenKH, SoDienThoai = @SoDT,
                            DiaChi = @DiaChi, CCCD = @CCCD, GioiTinh = @GioiTinh WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDT", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaKhachHang(string maKH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
