using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quản_Lý_Nhân_Sự
{
    class DBConnection
    {
        private String str;
        public DBConnection()
        {
            str = @"Data Source=LENOVO\SQLTHAI;Initial Catalog=QLNhanSu;Integrated Security=True";
        }
        public SqlConnection getConnection() { return new SqlConnection(str); }
    }
}
