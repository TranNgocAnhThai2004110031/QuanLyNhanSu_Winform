using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class NhanVienDTO
    {
        private string maNhanVien;
        private string hoVaTen;
        private string diaChi;
        private string soDienThoai;
        private string ngaySinh;
        private string gioiTinh;
        private string chucVu;
        private string phongBan;
        private float luong;
        private float phuCap;
        private string trangThai;
        private string trinhDoHocVan;
        private string chuyenMon;
        private string email;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public float Luong { get => luong; set => luong = value; }
        public float PhuCap { get => phuCap; set => phuCap = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TrinhDoHocVan { get => trinhDoHocVan; set => trinhDoHocVan = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public string Email { get => email; set => email = value; }

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNhanVien, string hoVaTen, string diaChi, string soDienThoai, string ngaySinh, string gioiTinh, string chucVu, string phongBan, float luong, float phuCap, string trangThai, string trinhDoHocVan, string chuyenMon, string email)
        {
            this.maNhanVien = maNhanVien;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
            this.phongBan = phongBan;
            this.luong = luong;
            this.phuCap = phuCap;
            this.trangThai = trangThai;
            this.trinhDoHocVan = trinhDoHocVan;
            this.chuyenMon = chuyenMon;
            this.email = email;
        }
    }
}
