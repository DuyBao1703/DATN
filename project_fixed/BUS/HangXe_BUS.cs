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
    public class HangXe_BUS
    {
        private HangXe_DAL dal = new HangXe_DAL();

        public DataTable GetAllHangXe() => dal.LoadHangXe();

        public bool AddHangXe(HangXe hx) => dal.ThemHangXe(hx);

        public bool UpdateHangXe(HangXe hx) => dal.SuaHangXe(hx);

        public bool DeleteHangXe(string maHang) => dal.XoaHangXe(maHang);
    }

}
