using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLLichCongTac
{
    public class DBConnect
    {
        public SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-3AABFT6;Initial Catalog=LCT;Integrated Security=True");
    }
}
