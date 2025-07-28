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
    public class XeMay_DAL
    {
        private string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        public DataTable LoadXeMay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM XeMay";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemXeMay(XeMay xm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO XeMay VALUES 
            (@MaXe, @TenXe, @Mau, @MaHang, @MaLoaiXe, @GiaNhap, @GiaBan, @SoKhung, @SoMay, @HinhAnh, @MaTrangThaiXe, @MaPhanKhoi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaXe", xm.MaXe);
                cmd.Parameters.AddWithValue("@TenXe", xm.TenXe);
                cmd.Parameters.AddWithValue("@Mau", xm.Mau);
                cmd.Parameters.AddWithValue("@MaHang", xm.MaHang);
                cmd.Parameters.AddWithValue("@MaLoaiXe", xm.MaLoaiXe);
                cmd.Parameters.AddWithValue("@GiaNhap", xm.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", xm.GiaBan);
                cmd.Parameters.AddWithValue("@SoKhung", xm.SoKhung);
                cmd.Parameters.AddWithValue("@SoMay", xm.SoMay);
                cmd.Parameters.AddWithValue("@HinhAnh", xm.HinhAnh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaTrangThaiXe", xm.MaTrangThaiXe);
                cmd.Parameters.AddWithValue("@MaPhanKhoi", xm.MaPhanKhoi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaXeMay(XeMay xm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE XeMay SET 
                TenXe = @TenXe, Mau = @Mau, MaHang = @MaHang, MaLoaiXe = @MaLoaiXe,
                GiaNhap = @GiaNhap, GiaBan = @GiaBan, SoKhung = @SoKhung, SoMay = @SoMay, 
                HinhAnh = @HinhAnh, MaTrangThaiXe = @MaTrangThaiXe, MaPhanKhoi = @MaPhanKhoi 
                WHERE MaXe = @MaXe";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaXe", xm.MaXe);
                cmd.Parameters.AddWithValue("@TenXe", xm.TenXe);
                cmd.Parameters.AddWithValue("@Mau", xm.Mau);
                cmd.Parameters.AddWithValue("@MaHang", xm.MaHang);
                cmd.Parameters.AddWithValue("@MaLoaiXe", xm.MaLoaiXe);
                cmd.Parameters.AddWithValue("@GiaNhap", xm.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", xm.GiaBan);
                cmd.Parameters.AddWithValue("@SoKhung", xm.SoKhung);
                cmd.Parameters.AddWithValue("@SoMay", xm.SoMay);
                cmd.Parameters.AddWithValue("@HinhAnh", xm.HinhAnh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaTrangThaiXe", xm.MaTrangThaiXe);
                cmd.Parameters.AddWithValue("@MaPhanKhoi", xm.MaPhanKhoi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaXeMay(string maXe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM XeMay WHERE MaXe = @MaXe";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaXe", maXe);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
