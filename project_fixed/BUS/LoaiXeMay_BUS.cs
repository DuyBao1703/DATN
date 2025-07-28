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
    public class LoaiXeMay_BUS
    {
        private LoaiXeMay_DAL dal = new LoaiXeMay_DAL();

        public DataTable GetAllLoaiXeMay() => dal.LoadLoaiXeMay();
        public bool AddLoaiXeMay(LoaiXeMay lx) => dal.ThemLoaiXe(lx);
        public bool UpdateLoaiXeMay(LoaiXeMay lx) => dal.SuaLoaiXe(lx);
        public bool DeleteLoaiXeMay(string maLoaiXe) => dal.XoaLoaiXe(maLoaiXe);
    }

}
