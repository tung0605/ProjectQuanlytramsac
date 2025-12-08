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

        // --- BỔ SUNG HÀM LOGIN (Hàm bạn đang thiếu) ---
        public bool login(string userName, string passWord)
        {
            // Kiểm tra trong database có dòng nào khớp Tên và Mật khẩu không
            // Lưu ý: N'...' để hỗ trợ tiếng Việt nếu cần, dù tên đăng nhập thường không dấu
            string query = "SELECT * FROM Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            // Nếu số dòng tìm thấy > 0 nghĩa là đúng tài khoản
            return result.Rows.Count > 0;
        }
        // ----------------------------------------------

        // Hàm lấy thông tin tài khoản (để truyền sang Form chính)
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

        // ... Các hàm Update, Insert khác giữ nguyên ...
        public bool UpdateInfo(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC updateaccount @userName , @displayName , @password , @newPassword",
                new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }
    }
}