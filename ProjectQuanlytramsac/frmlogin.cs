using ProjectQuanlytramsac.DAO;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtnamelogin.Text;
            string password = txtpassword.Text;
            if (login(username, password))
            {
            frmmanagement f = new frmmanagement();
            this.Hide();
            f.ShowDialog();
            this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        bool login(string username, string password)
        {
            return Account.Instance.login(username, password);
        }




        private void txtnamelogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
