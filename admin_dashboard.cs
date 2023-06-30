using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class admin_dashboard : Form
    {
        SqlConnection conn = new SqlConnection(); // sqlconnection 
        Connection c = new Connection(); // conncetion class
        SqlCommand cmd = new SqlCommand();
        public admin_dashboard()
        {
            InitializeComponent();
            conn = c.GetConnection();

        }

        private void showalldata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_showdata aw = new admin_showdata();
            aw.Show();
        }

        private void editprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string amt = Interaction.InputBox("enter a id of the user");
           int y = int.Parse(amt);
            Editprofile ep = new Editprofile(y);
            ep.Show();
        }

        private void activateuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_activate aa = new admin_activate();
            aa.Show();
        }

        private void deactivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_deactivate ad = new admin_deactivate();
            ad.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            less_frequent lf = new less_frequent();
            lf.Show();
        }

        private void frequent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            most_frequent mf = new most_frequent();
            mf.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
