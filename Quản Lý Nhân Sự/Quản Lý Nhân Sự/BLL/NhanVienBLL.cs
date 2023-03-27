using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL;
        public NhanVienBLL()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public DataTable getAllNhanVien()
        {
            return nhanVienDAL.getAllNhanVien();
        }
        public bool insertNhanVien(NhanVienDTO tblNhanVien) { return nhanVienDAL.insertNhanVien(tblNhanVien); }
        public bool updateNhanVien(NhanVienDTO tblNhanVien) { return nhanVienDAL.updateNhanVien(tblNhanVien); }
        public bool deleteNhanVien(NhanVienDTO tblNhanVien) { return nhanVienDAL.deleteNhanVien(tblNhanVien); }
        public DataTable findNhanVien(string maNV, string hvt, string pb) { return nhanVienDAL.findNhanVien(maNV, hvt, pb); }
        //public DataTable findNhanVien2(string yc) { return nhanVienDAL.findNhanVien3(yc); }
        public DataTable thongKe() { return nhanVienDAL.thongKe(); }
        public DataTable chart() { return nhanVienDAL.chart(); }
    }
}
