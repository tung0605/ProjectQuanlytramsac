using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmmanagement : Form
    {
        public frmmanagement()
        {
            InitializeComponent();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadmin f = new frmadmin();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numdiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccount f = new frmaccount();
            f.ShowDialog();
        }
    }
}
