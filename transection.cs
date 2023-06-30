using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
   
    class transection
    {
        public int temp;
        public int amt;

        public int id;


        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();


        public transection( int bal ,int amount ,int ID)

        {
            temp = bal;
            amt = amount;
            id = ID;
            conn = c.GetConnection();
        }

        public void credit()
        {
            //conn.Close();
            cmd = new SqlCommand("insert into transection(id,Credited,Available_Balance,Date)values('" + id + "','" + amt + "','" + temp + "', GETUTCDATE() )", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void debit()
        {
            //conn.Close();
            cmd = new SqlCommand("insert into transection(id,Debited,Available_Balance,Date)values('" + id + "','" + amt + "','" + temp + "', GETUTCDATE() )", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
