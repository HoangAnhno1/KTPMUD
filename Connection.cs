using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DANG_NHAP;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace KTPMUD
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source = DTuanDZ; Initial Catalog = Dang_nhap; Integrated Security = True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
