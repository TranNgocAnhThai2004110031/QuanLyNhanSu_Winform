using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Sự
{
    public class UsersDTO
    {
        private int id;
        private string username;
        private string password;
        private string  accountType;
        
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string AccountTypes { get => accountType; set => accountType = value; }
        public int Id { get => id; set => id = value; }

        public UsersDTO() 
        { 
        
        }
        public UsersDTO(string username, string password, string accountType)
        {
            this.username = username;
            this.password = password;
            this.accountType = accountType;
        }

    }
}
