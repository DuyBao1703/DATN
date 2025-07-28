using DAL_DATN;
using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DATN
{
    public class KhachHang_BUS
    {
        private KhachHang_DAL dal = new KhachHang_DAL();

        public DataTable GetAllKhachHang() => dal.LoadKhachHang();
        public bool AddKhachHang(KhachHang kh) => dal.ThemKhachHang(kh);
        public bool UpdateKhachHang(KhachHang kh) => dal.SuaKhachHang(kh);
        public bool DeleteKhachHang(string maKH) => dal.XoaKhachHang(maKH);
    }

}
