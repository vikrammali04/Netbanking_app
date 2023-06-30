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
using System.Data.SqlClient;
using System.Media;


namespace WindowsFormsApp3
{
    public partial class Editprofile : Form
    {
        public static int g1;
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public Editprofile(int g)
        {
            InitializeComponent();
            g1 = g;
            conn = c.GetConnection();

            showdata();

        }
        public void showdata()
        {
            //Login l = new Login();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("exec edit_profile @g1", conn);
            cmd1.Parameters.AddWithValue("@g1", g1);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            reader1.Read();
            //MessageBox.Show(g.ToString());
            fname.Text = reader1["Firstname"].ToString();
            lname.Text = reader1["LastName"].ToString();
            user.Text = reader1["Username"].ToString();
            //password.Text = reader1["Password"].ToString();
            phone.Text = reader1["Phone"].ToString();
            accnum.Text = reader1["AccNumber"].ToString();
            //gender.Text = reader1["Gender"].ToString();
            id.Text = reader1["mailid"].ToString();
            conn.Close();

            


        }

        private void submit_Click(object sender, EventArgs e)
        {

            
                conn.Open();
                cmd = new SqlCommand("update User_data set Firstname = '" + fname.Text + "',LastName = '" + lname.Text + "',Username = '" + user.Text + "',Phone = '" + phone.Text + "',mailid = '" + id.Text + "' where id = '" + g1 + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data updated");
                conn.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
