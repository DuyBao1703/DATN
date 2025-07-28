using DAL_DATN;
using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DATN
{
    public class NhanVien_BUS
    {
       
        private NhanVien_DAL dal = new NhanVien_DAL();

        public DataTable GetAllNhanVien()
        {
            return dal.LoadNhanVien();
        }
        public NhanVien DangNhap(string tenTK, string matKhau)
        {
            string hash = (matKhau); 
            return dal.DangNhap(tenTK, matKhau);
        }

        private string HashPassword(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }
        public bool AddNhanVien(NhanVien nv) => dal.ThemNhanVien(nv);
        public bool UpdateNhanVien(NhanVien nv) => dal.SuaNhanVien(nv);
        public bool DeleteNhanVien(string maNV) => dal.XoaNhanVien(maNV);
    }
}
