using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WindowsFormsApp3;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_registration
{
 
    public partial class Registration : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public Registration()
        {
            InitializeComponent();
            conn = c.GetConnection();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
        //public object  list = new List<object>();
        
        private void submit_Click(object sender, EventArgs e)
        {
            


            if (fname.TextLength == 0 || lname.TextLength == 0 || password.TextLength == 0 || uname.TextLength == 0 || mid.TextLength == 0 ||
                phone.TextLength == 0 || accnumber.TextLength ==0 ||gender.Text=="Select")
            {
                MessageBox.Show("All fileds are mendatory");

            }
            
            
            
            
           

            else 
            {
                if (phone.Text.Length != 10 || accnumber.Text.Length != 5)
                {
                    MessageBox.Show("phone number digit should be 10  and acc number should be 5 digit number");
                }
                else
                {
                    Validate v = new Validate(uname.Text,phone.Text,mid.Text,accnumber.Text);
                   int cn= v.valid();

                    if (cn == 0)
                    {
                       // MessageBox.Show(cn.ToString());

                        conn.Open();
                        cmd = new SqlCommand("exec user__register '" + fname.Text + "', '" + lname.Text + "', '" + mid.Text + "', '" + uname.Text + "', '" + password.Text + "', '" + phone.Text + "','" + accnumber.Text + "', '" + gender.Text + "', " + Convert.ToInt32(0) + "", conn);
                        cmd.ExecuteNonQuery();
                        /*Data data = new Data(fname.Text, lname.Text, id.Text, user.Text, password.Text, add.Text, gender.Text);
                        data.Add(new Data(fname.Text, lname.Text, mid.Text, uname.Text, password.Text, phone.Text, gender.Text));
                        MessageBox.Show("Registration succesfull");




                        //l.Show();
                        l.data = data;*/
                        MessageBox.Show("User succesfully registered");
                    }
                    else
                    {
                        //MessageBox.Show(cn.ToString());
                        MessageBox.Show("user already registered");
                    }
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Login l = new Login();
            l.Show();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }


    
}
