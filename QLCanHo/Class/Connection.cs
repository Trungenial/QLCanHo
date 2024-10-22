using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCanHo.Class
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-6VLE052\XUANVU;Initial Catalog=QLCanHo;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
