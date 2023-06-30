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
    public partial class admin_login : Form

    {

        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public admin_login()
        {
            InitializeComponent();
            conn = c.GetConnection();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            if (password.Text.Length == 0 || user.Text.Length == 0)
            {
                MessageBox.Show("enter both credentials");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("exec admin_login @userid = '" + user.Text + "' , @password ='" + password.Text + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("admin not found");

                }
                else
                {
                    MessageBox.Show("Logged in successfully");
                    // MessageBox.Show("logged in succefully");
                    admin_dashboard ad = new admin_dashboard();
                    ad.Show();

                }
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                Login l = new Login();
                l.Show();
            }

            private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                admin_reg ar = new admin_reg();
                ar.Show();
            }
        
    }
}
