using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class admin_showdata : Form
    {
        //public int id;
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        public admin_showdata()
        {
            InitializeComponent();
            conn = c.GetConnection();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void admin_showdata_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from User_data ", conn);
            DataTable DT = new DataTable();

            SQLAdapter.Fill(DT);

            dataGridView1.DataSource = DT;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                //try
                //{
                    
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    string sts = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    //MessageBox.Show(id.ToString());
                    conn.Open();
                    SqlCommand sql = new SqlCommand(" exec update_status @id,@sts", conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@sts", sts);
                sql.ExecuteNonQuery();
                    MessageBox.Show("success");
                    
                    conn.Close();
                //}
                //catch
                //{
                //    MessageBox.Show("something went wrong");
                //}
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
