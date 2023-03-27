using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    internal class UserBLL
    {
        private UserDAL userDAL;
        public UserBLL()
        {
            userDAL = new UserDAL();
        }
        public DataTable getAllUser()
        {
            return userDAL.getAllUser();
        }
        public bool insertUser(UsersDTO tblUser) { return userDAL.insertUser(tblUser); }
        public bool updateUser(UsersDTO tblUser) { return userDAL.updatePhongBan(tblUser); }
        public bool deleteUser(UsersDTO tblUser) { return userDAL.deletePhongBan(tblUser); }

    }
}
