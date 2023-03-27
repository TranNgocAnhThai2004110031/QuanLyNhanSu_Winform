using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    class UserDAL
    {
        DBConnection dc;
        SqlDataAdapter da;
        SqlConnection con;
        SqlCommand cmd;
        
        public UserDAL()
        {
            dc = new DBConnection();
        }
        public DataTable getAllUser()
        {
            string sql = "SELECT * FROM Users";
            con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public bool insertUser(UsersDTO tblUser)
        {
            string sql = "INSERT INTO Users(Username, Password, AccessRights)" +
                " VALUES (@Username, @Password, @AccessRights)";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = tblUser.Username;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tblUser.Password;
                cmd.Parameters.Add("@AccessRights", SqlDbType.NText).Value = tblUser.AccountTypes;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool updatePhongBan(UsersDTO tblUser)
        {
            string sql = "UPDATE Users SET Username = @Username," +
                " Password = @Password, AccessRights = @AccessRights WHERE " +
                "Username = @Username";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = tblUser.Username;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tblUser.Password;
                cmd.Parameters.Add("@AccessRights", SqlDbType.NText).Value = tblUser.AccountTypes;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool deletePhongBan(UsersDTO tblUser)
        {
            string sql = "DELETE Users WHERE Id = @Id";
            con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tblUser.Id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
