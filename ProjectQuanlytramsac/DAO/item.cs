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

        public List<items> loaditemlist()
        {
            List<items> itemlist = new List<items>();
            string query = "SELECT * FROM TruSac";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                items it = new items(row);
                itemlist.Add(it);
            }

            return itemlist;
        }

        public void UpdateStatus(int idTru, string status)
        {
            string query = string.Format("UPDATE TruSac SET trangThai = N'{0}' WHERE id = {1}", status, idTru);

            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}