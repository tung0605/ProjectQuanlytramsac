using ProjectQuanlytramsac.DTO;
using System.Data;

namespace ProjectQuanlytramsac.DAO
{
    public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account() { }

        // 1. Hàm Đăng nhập (Đã có từ trước)
        public bool login(string userName, string passWord)
        {
            string query = "SELECT * FROM Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }

        // 2. Hàm lấy thông tin 1 tài khoản (Đã có từ trước)
        public changeinfo GetAccountByUserName(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = N'" + userName + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new changeinfo(item);
            }
            return null;
        }

        // 3. Hàm cập nhật thông tin cá nhân (Đã có từ trước)
        public bool UpdateInfo(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC updateaccount @userName , @displayName , @password , @newPassword",
                new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }

        // --- CÁC HÀM MỚI BỔ SUNG CHO TAB QUẢN LÝ TÀI KHOẢN ---

        // 4. Lấy danh sách tất cả tài khoản
        // Trong file DAO/Account.cs

        // 1. Sửa hàm lấy danh sách: Thêm cột PassWord
        public DataTable GetListAccount()
        {
            // Lấy tất cả thông tin
            return DataProvider.Instance.ExcuteQuery("SELECT UserName, DisplayName, Type, PassWord FROM Account");
        }



        // 5. Thêm tài khoản mới (Pass mặc định là 0)
        public bool InsertAccount(string name, string displayName, int type)
        {
            // PassWord mặc định là '0'
            string query = string.Format("INSERT INTO Account (UserName, DisplayName, Type, PassWord) VALUES (N'{0}', N'{1}', {2}, N'admin')", name, displayName, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        // 2. Sửa hàm Cập nhật: Cho phép sửa cả Mật khẩu (nếu muốn)
        public bool UpdateAccount(string name, string displayName, int type, string password)
        {
            // Cập nhật Tên hiển thị, Loại TK VÀ MẬT KHẨU
            string query = string.Format("UPDATE Account SET DisplayName = N'{1}', Type = {2}, PassWord = N'{3}' WHERE UserName = N'{0}'", name, displayName, type, password);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        // 7. Xóa tài khoản
        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        // 8. Đặt lại mật khẩu về 0
        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE Account SET PassWord = N'0' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}