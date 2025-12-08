using ProjectQuanlytramsac.DTO;
using System.Collections.Generic;
using System.Data;

namespace ProjectQuanlytramsac.DAO
{
    public class item
    {
        private static item instance;

        public static item Instance
        {
            get { if (instance == null) instance = new item(); return item.instance; }
            private set { item.instance = value; }
        }

        private item() { }

        // Trong file DAO/item.cs (hoặc nơi bạn viết hàm loaditemlist)
        public List<items> loaditemlist()
        {
            // --- QUAN TRỌNG: Phải tạo list mới ở đây ---
            List<items> listTruSac = new List<items>();
            // -------------------------------------------

            string query = "SELECT * FROM TruSac"; // Hoặc câu lệnh lấy dữ liệu của bạn
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                items trusac = new items(item);
                listTruSac.Add(trusac);
            }

            return listTruSac;
        }

        public void UpdateStatus(int idTru, string status)
        {
            string query = string.Format("UPDATE TruSac SET trangThai = N'{0}' WHERE id = {1}", status, idTru);

            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}