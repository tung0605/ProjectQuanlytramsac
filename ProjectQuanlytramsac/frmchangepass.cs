using ProjectQuanlytramsac.DAO;
using ProjectQuanlytramsac.DTO;
using System;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmchangepass : Form
    {
        // 1. Biến nhận thông tin tài khoản
        private changeinfo loginAccount;

        public changeinfo LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; LoadAccountInfo(loginAccount); }
        }

        public frmchangepass(changeinfo acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

            // --- QUAN TRỌNG: KẾT NỐI SỰ KIỆN NÚT BẤM BẰNG CODE ---
            // Vì trong file Designer của bạn chưa thấy dòng kết nối sự kiện cho nút btnaccept
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
        }

        // 2. Hàm hiển thị thông tin
        void LoadAccountInfo(changeinfo acc)
        {
            txtnamelogin.Text = acc.UserName;
            txtshowname.Text = acc.DisplayName;
        }

        // 3. LOGIC NÚT XÁC NHẬN (btnaccept)
        private void btnaccept_Click(object sender, EventArgs e)
        {
            string userName = txtnamelogin.Text;
            string displayName = txtshowname.Text;
            string password = txtcurrentpass.Text; // Mật khẩu hiện tại
            string newpass = txtnewpass.Text;      // Mật khẩu mới
            string reenterpass = txtacpnewpass.Text; // Nhập lại mật khẩu mới

            // Kiểm tra mật khẩu mới nhập lại
            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Mật khẩu mới nhập lại không khớp!", "Thông báo");
                return;
            }

            // Gọi xuống DAO để cập nhật
            if (Account.Instance.UpdateInfo(userName, displayName, password, newpass))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");

                // Cập nhật lại sự kiện để form cha (Management) biết mà đổi tên trên Menu
                if (updateAccountEvent != null)
                {
                    updateAccountEvent(this, new AccountEvent(Account.Instance.GetAccountByUserName(userName)));
                }
                this.Close(); // Đóng form sau khi đổi xong
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng mật khẩu hiện tại.", "Lỗi");
            }
        }

        // --- 4. CÁC HÀM "CỨU HỘ" (ĐỂ SỬA LỖI DESIGNER) ---
        // Bạn phải giữ các hàm này để file Designer tìm thấy, nếu xóa đi sẽ bị lỗi đỏ lòm
        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // --- 5. EVENT NÂNG CAO (Để cập nhật tên bên Form Chính) ---
        private event EventHandler<AccountEvent> updateAccountEvent;
        public event EventHandler<AccountEvent> UpdateAccountEvent
        {
            add { updateAccountEvent += value; }
            remove { updateAccountEvent -= value; }
        }

        public class AccountEvent : EventArgs
        {
            private changeinfo acc;
            public changeinfo Acc { get => acc; set => acc = value; }
            public AccountEvent(changeinfo acc) { this.Acc = acc; }
        }
    }
}