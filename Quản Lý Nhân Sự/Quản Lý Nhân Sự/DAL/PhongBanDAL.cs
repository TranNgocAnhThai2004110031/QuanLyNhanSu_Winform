using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Nhân_Sự
{
    class PhongBanDAL
    {
        DBConnection dc;
        SqlDataAdapter da;
        SqlConnection con;
        SqlCommand cmd;

        public PhongBanDAL()
        {
            dc = new DBConnection();
        }
        public DataTable getAllPhongBan()
        {
            string sql = "SELECT * FROM PhongBan";
            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public bool insertPhongBan(PhongBanDTO tblPhongBan)
        {
            string sql = "INSERT INTO PhongBan(MaPhong, TenPhong, SoLuongNhanVien, NgayThanhLap, GhiChu)" +
                " VALUES (@MaPhong, @TenPhong, @SoLuongNhanVien, @NgayThanhLap, @GhiChu)";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = tblPhongBan.MaPhong;
                cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = tblPhongBan.TenPhong;
                cmd.Parameters.Add("@SoLuongNhanVien", SqlDbType.Int).Value = tblPhongBan.SoLuongNhanVien;
                cmd.Parameters.Add("@NgayThanhLap", SqlDbType.DateTime).Value = tblPhongBan.NgayThanhLap;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = tblPhongBan.GhiChu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool updatePhongBan(PhongBanDTO tblPhongBan)
        {
            string sql = "UPDATE PhongBan SET TenPhong = @TenPhong," +
                " SoLuongNhanVien = @SoLuongNhanVien, NgayThanhLap = @NgayThanhLap, GhiChu = @GhiChu WHERE MaPhong = @MaPhong";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = tblPhongBan.MaPhong;
                cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = tblPhongBan.TenPhong;
                cmd.Parameters.Add("@SoLuongNhanVien", SqlDbType.Int).Value = tblPhongBan.SoLuongNhanVien;
                cmd.Parameters.Add("@NgayThanhLap", SqlDbType.DateTime).Value = tblPhongBan.NgayThanhLap;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = tblPhongBan.GhiChu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool deletePhongBan(PhongBanDTO tblPhongBan)
        {
            string sql = "DELETE PhongBan WHERE MaPhong = @MaPhong";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = tblPhongBan.MaPhong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable chart()
        {
            string sql = "SELECT TenPhong, MaPhong, SoLuongNhanVien " +
                    " FROM PhongBan GROUP BY TenPhong, MaPhong, SoLuongNhanVien ";

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
