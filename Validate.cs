using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class Validate
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        string user;
        string phone;
        string mail;
        string acc;

        public Validate(string u, string p , string m,string a)

        {
            conn = c.GetConnection();
            this.mail = m;
            this.user = u;
            this.phone = p;
            this.acc = a;
            

            
        }
        public int valid()
        {
            conn.Open();

            SqlCommand sql = new SqlCommand("select Count(*) from User_data where AccNumber= '" + acc + "'   or mailid = '" + mail + "' or Phone = '" + phone + " ' or Username='"+user+"'", conn);
    
            SqlDataReader data = sql.ExecuteReader();
            data.Read();
            int count = Convert.ToInt32(data.GetValue(0));
            
            conn.Close();
            return count;
        }
    }
}
