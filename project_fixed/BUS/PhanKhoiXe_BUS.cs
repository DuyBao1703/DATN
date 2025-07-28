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
    public class PhanKhoiXe_BUS
    {
        PhanKhoiXe_DAL dal = new PhanKhoiXe_DAL();

        public DataTable GetAllPhanKhoiXe() => dal.LoadPhanKhoiXe();
        public bool AddPhanKhoiXe(PhanKhoiXe pk) => dal.ThemPhanKhoiXe(pk);
        public bool UpdatePhanKhoiXe(PhanKhoiXe pk) => dal.SuaPhanKhoiXe(pk);
        public bool DeletePhanKhoiXe(string maPK) => dal.XoaPhanKhoiXe(maPK);
    }

}
