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
    public class XeMay_BUS
    {
        private XeMay_DAL dal = new XeMay_DAL();

        public DataTable GetAllXeMay() => dal.LoadXeMay();
        public bool AddXeMay(XeMay xm) => dal.ThemXeMay(xm);
        public bool UpdateXeMay(XeMay xm) => dal.SuaXeMay(xm);
        public bool DeleteXeMay(string maXe) => dal.XoaXeMay(maXe);
    }

}
