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
    public class TrangThaiXe_BUS
    {
        TrangThaiXe_DAL dal = new TrangThaiXe_DAL();

        public DataTable GetAllTrangThaiXe() => dal.LoadTrangThaiXe();
        public bool AddTrangThaiXe(TrangThaiXe tt) => dal.ThemTrangThaiXe(tt);
        public bool UpdateTrangThaiXe(TrangThaiXe tt) => dal.SuaTrangThaiXe(tt);
        public bool DeleteTrangThaiXe(string maTT) => dal.XoaTrangThaiXe(maTT);
    }

}
