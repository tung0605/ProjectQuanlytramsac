using ProjectQuanlytramsac.DAO;
using ProjectQuanlytramsac.DTO;
using System;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        // Sự kiện nút ĐĂNG NHẬP
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtnamelogin.Text;
            string password = txtpassword.Text;

            if (login(username, password))
            {
                // 1. Lấy thông tin tài khoản từ SQL
                // (Đảm bảo class DAO là Account, class DTO là changeinfo)
                changeinfo loginAccount = Account.Instance.GetAccountByUserName(username);

                // 2. Truyền vào Form Chính
                frmmanagement f = new frmmanagement(loginAccount);

                this.Hide();
                f.ShowDialog();
                this.Show(); // Hiện lại form đăng nhập khi tắt form chính
                txtnamelogin.Text = "";
                txtpassword.Text = "";

                // Đặt con trỏ chuột về ô Username (Tùy chọn)
                txtnamelogin.Focus();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi");
            }
        }

        // Hàm gọi xuống DAO
        bool login(string username, string password)
        {
            // Bây giờ bên DAO/Account.cs đã có hàm login rồi nên dòng này sẽ hết lỗi
            return Account.Instance.login(username, password);
        }

        // Sự kiện đóng form (Hỏi trước khi thoát)
        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        // Các hàm rỗng giữ nguyên để không lỗi giao diện
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtnamelogin_TextChanged(object sender, EventArgs e) { }
        private void txtpassword_TextChanged(object sender, EventArgs e) { }
    }
}