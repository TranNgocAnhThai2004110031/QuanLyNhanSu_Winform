using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class PhongBanBLL
    {
        private PhongBanDAL phongBanDAL;
        public PhongBanBLL()
        {
            phongBanDAL = new PhongBanDAL();
        }
        public DataTable getAllPhongBan()
        {
            return phongBanDAL.getAllPhongBan();
        }
        public bool insertPhongBan(PhongBanDTO tblPhongBan) { return phongBanDAL.insertPhongBan(tblPhongBan); }
        public bool updatePhongBan(PhongBanDTO tblPhongBan) { return phongBanDAL.updatePhongBan(tblPhongBan); }
        public bool deletePhongBan(PhongBanDTO tblPhongBan) { return phongBanDAL.deletePhongBan(tblPhongBan); }
        public DataTable chart() { return phongBanDAL.chart(); }
    }
}
