using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Connection
    {
        public   SqlConnection GetConnection()
                
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-32BJ5KJ\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True";
            return con;

        }
      
    }
}
