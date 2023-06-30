using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using login_registration;
using System.Data.SqlClient;
using System.Media;


namespace WindowsFormsApp3
{ 
    public partial class Login : Form

    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public static int a;
        public Login()
        {
            InitializeComponent();
            conn = c.GetConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();

        }

        private void submit_Click(object sender, EventArgs e)

        {
            

            if (password.Text.Length==0 || user.Text.Length==0)
            {
                MessageBox.Show("enter both credentials");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("EXEC user__login @Username = '" + user.Text + "' ,@Status='Activate', @Password ='" + password.Text + "'",conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.Close();
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("user not found");
                    
                }
                else
                { 
                    
                    MessageBox.Show("Logged in successfully");

                    int id = Convert.ToInt32(dt.Rows[0]["id"]);
                    a = id;


                    
                    conn.Close();
                    Datashow ds = new Datashow(a);
                    ds.Show();
                }
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
        }
    }
}
