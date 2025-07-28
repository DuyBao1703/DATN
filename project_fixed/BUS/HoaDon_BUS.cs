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
    public class HoaDon_BUS
    {
        HoaDon_DAL dal = new HoaDon_DAL();

        public DataTable GetAllHoaDon() => dal.LoadHoaDon();
        public bool AddHoaDon(HoaDon hd) => dal.ThemHoaDon(hd);
        public bool UpdateHoaDon(HoaDon hd) => dal.SuaHoaDon(hd);
        public bool DeleteHoaDon(string maHD) => dal.XoaHoaDon(maHD);
    }

}
