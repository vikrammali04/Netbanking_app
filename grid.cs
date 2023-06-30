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
    public partial class grid : Form
    {
        public int id;
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();

        public grid(int i)
        {
            InitializeComponent();
            id=i;
            MessageBox.Show(i.ToString());
            conn = c.GetConnection();
        }

        private void grid_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from transection where  id='" + id + "'", conn);
            DataTable DT = new DataTable();

            SQLAdapter.Fill(DT);

            dataGridView1.DataSource = DT;
            conn.Close();
        }
    }
}
