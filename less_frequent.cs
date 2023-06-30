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
    public partial class less_frequent : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        DataTable DT = new DataTable();
        public less_frequent()
        {
            InitializeComponent();
            conn = c.GetConnection();
        }

        private void less_frequent_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select Distinct id from transection where Date between DATEADD(MONTH,-2,GETDATE()) and GETDATE() group by id having count(Date)<5", conn);
            cmd.ExecuteNonQuery();
            SqlDataReader data = cmd.ExecuteReader();
            DataTable DT = new DataTable();
            List<int> ids = new List<int>();
            while (data.Read())
            {
                int id = Convert.ToInt32(data.GetValue(0));
                //MessageBox.Show(id.ToString());
                ids.Add(id);
            }
            data.Close(); // Close the first data reader
            foreach (int id in ids)
            {
                SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from User_data where id = '" + id + "' ", conn);
                DataTable userTable = new DataTable();
                SQLAdapter.Fill(userTable);
                DT.Merge(userTable);
            }
            dataGridView1.DataSource = DT;
            conn.Close();

        }
    }
}
