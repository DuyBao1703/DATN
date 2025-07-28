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
    public class ChiTietHoaDon_BUS
    {
        private ChiTietHoaDon_DAL dal = new ChiTietHoaDon_DAL();

        public DataTable GetAllChiTietHoaDon() => dal.LoadChiTietHoaDon();
        public bool AddChiTietHoaDon(ChiTietHoaDon ct) => dal.ThemChiTietHoaDon(ct);
        public bool UpdateChiTietHoaDon(ChiTietHoaDon ct) => dal.SuaChiTietHoaDon(ct);
        public bool DeleteChiTietHoaDon(string maCTHD) => dal.XoaChiTietHoaDon(maCTHD);
    }

}
