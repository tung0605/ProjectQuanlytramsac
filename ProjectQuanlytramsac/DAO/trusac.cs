using System.Data;

namespace ProjectQuanlytramsac.DAO
{
    // Dù file tên là trusac.cs, nhưng Class phải tên là trusac 
    // thì bên frmadmin mới gọi được lệnh trusac.Instance...
    public class trusac
    {
        private static trusac instance;

        public static trusac Instance
        {
            get { if (instance == null) instance = new trusac(); return instance; }
            private set { instance = value; }
        }

        private trusac() { }

        // 1. Lấy danh sách trụ
        public DataTable GetListTruSac()
        {
            // Lấy các cột cần thiết để hiển thị lên bảng
            string query = "SELECT id, tenTru, trangThai, LoaiXe, CongSuatKW FROM TruSac";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        // 2. Thêm trụ mới
        public bool InsertTruSac(string name, string status, string type, float power)
        {
            string query = string.Format("INSERT INTO TruSac (tenTru, trangThai, LoaiXe, CongSuatKW) VALUES (N'{0}', N'{1}', N'{2}', {3})", name, status, type, power);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        // 3. Sửa trụ
        public bool UpdateTruSac(int id, string name, string status, string type, float power)
        {
            string query = string.Format("UPDATE TruSac SET tenTru = N'{0}', trangThai = N'{1}', LoaiXe = N'{2}', CongSuatKW = {3} WHERE id = {4}", name, status, type, power, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        // 4. Xóa trụ
        public bool DeleteTruSac(int id)
        {
            // Lưu ý: SQL sẽ báo lỗi nếu bạn xóa trụ đang có hóa đơn lưu trữ.
            // Để an toàn, chúng ta nên xóa hóa đơn của trụ đó trước (nếu muốn xóa vĩnh viễn)
            // Hoặc dùng Try-Catch bên Form để bắt lỗi này.
            string query = string.Format("DELETE TruSac WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}