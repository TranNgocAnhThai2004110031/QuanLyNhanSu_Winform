using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class PhongBanDTO
    {
        private string maPhong;
        private string tenPhong;
        private int soLuongNhanVien;
        private DateTime ngayThanhLap;
        private string ghiChu;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int SoLuongNhanVien { get => soLuongNhanVien; set => soLuongNhanVien = value; }
        public DateTime NgayThanhLap { get => ngayThanhLap; set => ngayThanhLap = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public PhongBanDTO()
        {
        }
        public PhongBanDTO(string maPhong, string tenPhong, int soLuongNhanVien, DateTime ngayThanhLap, string ghiChu)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.soLuongNhanVien = soLuongNhanVien;
            this.ngayThanhLap = ngayThanhLap;
            this.ghiChu = ghiChu;
        }
    }
}
