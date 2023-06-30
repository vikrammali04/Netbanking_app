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
    public partial class admin_activate : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        public admin_activate()
        {
            InitializeComponent();
            conn = c.GetConnection();
            admin_activate1();
        }
        private void admin_activate1()
        {
            //MessageBox.Show("reached");
            conn.Open();
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from User_data where Status ='Activate' ", conn);
            DataTable DT = new DataTable();

            SQLAdapter.Fill(DT);

            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
