using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO_DATN;

namespace DAL_DATN
{
    public class NhanVien_DAL
    {
        
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";
        public NhanVien DangNhap(string tenTK, string matKhauHash)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE TenTK = @tk AND MatKhauHash = @mk";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tk", tenTK);
                cmd.Parameters.AddWithValue("@mk", matKhauHash);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new NhanVien
                    {
                        MaNV = reader["MaNV"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        TenTK = reader["TenTK"].ToString(),
                        VaiTro = Convert.ToBoolean(reader["VaiTro"]),
                        Email = reader["Email"].ToString()
                        // Có thể thêm nếu cần
                    };
                }
                return null;
            }
        }

        public DataTable LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO NhanVien VALUES (@MaNV, @TenNV, @TenTK, @MatKhauHash, @GioiTinh, @SoDienThoai, @DiaChi, @VaiTro, @Email, @HinhAnh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@TenTK", nv.TenTK);
                cmd.Parameters.AddWithValue("@MatKhauHash", nv.MatKhauHash);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@HinhAnh", nv.HinhAnh ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE NhanVien SET TenNV = @TenNV, TenTK = @TenTK, MatKhauHash = @MatKhauHash, GioiTinh = @GioiTinh,
                             SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, VaiTro = @VaiTro, Email = @Email, HinhAnh = @HinhAnh
                             WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@TenTK", nv.TenTK);
                cmd.Parameters.AddWithValue("@MatKhauHash", nv.MatKhauHash);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@HinhAnh", nv.HinhAnh ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaNhanVien(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
