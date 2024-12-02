using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApss
{
    public class Utilities
    {
        public static string connectionString = "server =Bon; Database = QLBangDia; Integrated security = true; ";
        public static SqlConnection GetSql()
        {
            return new SqlConnection(connectionString);
        }
    }
}
