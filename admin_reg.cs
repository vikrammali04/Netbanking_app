using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    
    public partial class admin_reg : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public admin_reg()
        {
            InitializeComponent();
            conn = c.GetConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(user.Text.Length==0 || pin.Text.Length ==0 || password.Text.Length==0)
            {
                MessageBox.Show("Enter both credentials");
            }

            else if(pin.Text!="1234")
            {
                MessageBox.Show("Invalid pin");
            }
            else
            {
                conn.Open();
                SqlCommand sql = new SqlCommand("select Count(*) from admin_data where userid= '" + user.Text + "'", conn);

                SqlDataReader data = sql.ExecuteReader();
                data.Read();
                int count = Convert.ToInt32(data.GetValue(0));

                conn.Close();

                if(count!=0 )
                {
                    MessageBox.Show("User already exist");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("exec admin_register '" + user.Text + "','" + password.Text + "'", conn);
                    cmd.ExecuteReader();
                    MessageBox.Show("admin registered");
                }
                
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
