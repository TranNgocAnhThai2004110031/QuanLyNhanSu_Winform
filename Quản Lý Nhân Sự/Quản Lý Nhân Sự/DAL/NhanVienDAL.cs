using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class NhanVienDAL
    {
        DBConnection dc;
        SqlDataAdapter da;
        SqlConnection con;
        SqlCommand cmd;

        public NhanVienDAL()
        {
            dc = new DBConnection();
        }
        public DataTable getAllNhanVien()
        {
            string sql = "SELECT * FROM DanhSachNhanVien";
            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public bool insertNhanVien(NhanVienDTO tblNhanVien)
        {
            string sql = "INSERT INTO DanhSachNhanVien(MaNhanVien, HoVaTen, DiaChi, SoDienThoai, NgaySinh, GioiTinh, ChucVu, PhongBan, Luong, PhuCap, TrangThai, TrinhDoHocVan, ChuyenMon, Email)" +
                                       " VALUES (@MaNhanVien, @HoVaTen, @DiaChi, @SoDienThoai, @NgaySinh, @GioiTinh, @ChucVu, @PhongBan, @Luong, @PhuCap, @TrangThai, @TrinhDoHocVan, @ChuyenMon, @Email)";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNhanVien", SqlDbType.NChar).Value = tblNhanVien.MaNhanVien;
                cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = tblNhanVien.HoVaTen;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = tblNhanVien.DiaChi;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NChar).Value = tblNhanVien.SoDienThoai;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = tblNhanVien.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = tblNhanVien.GioiTinh;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = tblNhanVien.ChucVu;
                cmd.Parameters.Add("@PhongBan", SqlDbType.NVarChar).Value = tblNhanVien.PhongBan;
                cmd.Parameters.Add("@Luong", SqlDbType.Money).Value = tblNhanVien.Luong;
                cmd.Parameters.Add("@PhuCap", SqlDbType.Money).Value = tblNhanVien.PhuCap;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = tblNhanVien.TrangThai;
                cmd.Parameters.Add("@TrinhDoHocVan", SqlDbType.NVarChar).Value = tblNhanVien.TrinhDoHocVan;
                cmd.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar).Value = tblNhanVien.ChuyenMon;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tblNhanVien.Email;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool updateNhanVien(NhanVienDTO tblNhanVien)
        {
            string sql = "UPDATE DanhSachNhanVien SET MaNhanVien = @MaNhanVien, HoVaTen = @HoVaTen, DiaChi = @DiaChi, " +
                "SoDienThoai = @SoDienThoai, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, ChucVu = @ChucVu, " +
                "PhongBan = @PhongBan, Luong = @Luong, PhuCap = @PhuCap, TrangThai = @TrangThai, TrinhDoHocVan = @TrinhDoHocVan," +
                " ChuyenMon = @ChuyenMon, Email = @Email WHERE MaNhanVien = @MaNhanVien";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNhanVien", SqlDbType.NChar).Value = tblNhanVien.MaNhanVien;
                cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = tblNhanVien.HoVaTen;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = tblNhanVien.DiaChi;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NChar).Value = tblNhanVien.SoDienThoai;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = tblNhanVien.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = tblNhanVien.GioiTinh;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = tblNhanVien.ChucVu;
                cmd.Parameters.Add("@PhongBan", SqlDbType.NVarChar).Value = tblNhanVien.PhongBan;
                cmd.Parameters.Add("@Luong", SqlDbType.Money).Value = tblNhanVien.Luong;
                cmd.Parameters.Add("@PhuCap", SqlDbType.Money).Value = tblNhanVien.PhuCap;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = tblNhanVien.TrangThai;
                cmd.Parameters.Add("@TrinhDoHocVan", SqlDbType.NVarChar).Value = tblNhanVien.TrinhDoHocVan;
                cmd.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar).Value = tblNhanVien.ChuyenMon;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tblNhanVien.Email;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool deleteNhanVien(NhanVienDTO tblNhanVien)
        {
            string sql = "DELETE DanhSachNhanVien WHERE MaNhanVien = @MaNhanVien";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNhanVien", SqlDbType.NChar).Value = tblNhanVien.MaNhanVien;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable findNhanVien(string maNV, string hvt, string pb)
        {
            string sql = "SELECT * FROM DanhSachNhanVien WHERE MaNhanVien like '%" + maNV + "%' OR HoVaTen like '%" + hvt +
                "%' OR PhongBan like '%" + pb + "%'";

            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        //public DataTable findNhanVien3(string yc)
        //{
        //    string sql = "SELECT * FROM DanhSachNhanVien WHERE MaNhanVien like '%" + yc + "%' OR HoVaTen like '%" + yc +
        //        "%' OR PhongBan like '%" + yc + "%'";

        //    con = dc.getConnection();
        //    da = new SqlDataAdapter(sql, con);
        //    con.Open();
        //    DataTable dataTable = new DataTable();
        //    da.Fill(dataTable);
        //    con.Close();
        //    return dataTable;
        //}
        public DataTable thongKe()
        {
            string sql = "SELECT MaNhanVien, HoVaTen, ChucVu, Luong, PhuCap, (SUM(Luong) + SUM(PhuCap)) AS LuongThang " +
                    " FROM DanhSachNhanVien WHERE MaNhanVien != '' GROUP BY MaNhanVien, HoVaTen, ChucVu, Luong, PhuCap,Luong, PhuCap";

            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public DataTable chart()
        {
            string sql = "SELECT HoVaTen, (SUM(Luong) + SUM(PhuCap)) AS LuongThang " +
                    " FROM DanhSachNhanVien GROUP BY HoVaTen";

            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }
}

