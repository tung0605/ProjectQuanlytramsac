using ProjectQuanlytramsac.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
            loadaccountlist();
        }

        void loadaccountlist()
        {
            string query = "EXEC getaccbyusername @username";

            DataProvider provider = new DataProvider();

            dtgvlistacc.DataSource = provider.ExecuteQuery(query, new object[] { "admin" }); 




        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dtpfromdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtptodate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
