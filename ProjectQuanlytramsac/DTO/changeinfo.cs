using System.Data;

namespace ProjectQuanlytramsac.DTO
{
    public class changeinfo
    {
        // Các thuộc tính
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }

        public changeinfo(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PassWord = password;
        }

        // Constructor nhận DataRow từ SQL
        public changeinfo(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["PassWord"].ToString();
        }
    }
}