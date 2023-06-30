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
using WindowsFormsApp3;
using Microsoft.VisualBasic;


namespace WindowsFormsApp3
{
    public partial class Datashow : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        //public int g { set; get; }
        public static int g;
        public SqlDataReader reader1;
        //public SqlCommand cmd1;
        public Datashow(int c1)
        {
            InitializeComponent();
            //int g = c1;
            g = c1;
            //MessageBox.Show(g.ToString());
            conn = c.GetConnection();

            showdata();
        }
        public void dbwork()
        {
            //conn.Open();
            cmd = new SqlCommand("exec edit_profile @g", conn);
            cmd.Parameters.AddWithValue("@g", g);


        }
        public void showdata()
        {
            //Login l = new Login();
            conn.Open();
            dbwork();
            reader1 = cmd.ExecuteReader();
            reader1.Read();

            //MessageBox.Show(g.ToString());
            fname.Text = reader1["Firstname"].ToString();
            lname.Text = reader1["LastName"].ToString();
            user.Text = reader1["Username"].ToString();
            balance.Text = reader1["Balance"].ToString();
            phone.Text = reader1["Phone"].ToString();
            accnum.Text = reader1["AccNumber"].ToString();
            gender.Text = reader1["Gender"].ToString();
            id.Text = reader1["mailid"].ToString();
            conn.Close();
            reader1.Close();
           
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Editprofile ep = new Editprofile(g);
            ep.Show();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            conn.Open();
            dbwork();
            string amt = Interaction.InputBox("enter a amoun you want to withdraw");
            reader1 = cmd.ExecuteReader();
            reader1.Read();
            int i = int.Parse((reader1["id"]).ToString());
            MessageBox.Show(i.ToString());

            //conn.Close();

            //int temp = int.Parse(reader1["Balance"].ToString()) + int.Parse(amt);
            if (int.Parse(reader1["Balance"].ToString()) >= int.Parse(amt))
            {
                
                //conn.Open();
                int temp = int.Parse(reader1["Balance"].ToString()) - int.Parse(amt);
                //MessageBox.Show("Amount successfully debited");
                conn.Close();
                conn.Open();
                cmd = new SqlCommand("exec update_balance '" + temp + "' ,'"+i+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Amount successfully debited");
                MessageBox.Show("Available balance is : " + temp);
                reader1.Close();
                conn.Close();
                transection tn = new transection(temp, int.Parse(amt), i);
                tn.debit();
            }

            else
            {
                MessageBox.Show("insufficient balance");
                //conn.Close();
            }
            conn.Close();
        }





        private void deposit_Click(object sender, EventArgs e)
        {
            dbwork();
            string amt = Interaction.InputBox("enter a amoun you want to deposit");
            conn.Open();
            reader1 = cmd.ExecuteReader();
            reader1.Read();

            int i = int.Parse((reader1["id"]).ToString());
            int temp = int.Parse(reader1["Balance"].ToString()) + int.Parse(amt);
            conn.Close();
            //MessageBox.Show("Amount successfully credited");
            //cmd = new SqlCommand("exec update_balance '" + temp + "' ,'" + i + "'", conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Amount successfully credited");
            MessageBox.Show("Available balance is : " + temp);
            //reader1.Close();
            //conn.Close();
            transection tn = new transection(temp, int.Parse(amt), i);
            tn.credit();

            conn.Close();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbwork();
            conn.Open();
            reader1 = cmd.ExecuteReader();
            reader1.Read();
            grid gr = new grid(int.Parse(reader1["id"].ToString()));
            gr.Show();
            conn.Close();
        }
    }
}

