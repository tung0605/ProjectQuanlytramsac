using ProjectQuanlytramsac.DTO;
using System;
using System.Data;

namespace ProjectQuanlytramsac.DAO
{
    public class bill
    {
        private static bill instance;

        public static bill Instance
        {
            get { if (instance == null) instance = new bill(); return bill.instance; }
            private set { bill.instance = value; }
        }

        private bill() { }

        public int getuncheckbillbyitemid(int idTruSac)
        {
            string query = "SELECT * FROM HoaDon WHERE idTruSac = " + idTruSac + " AND status = 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                bills bill = new bills(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int idTruSac, string cheDo, string loaiKhach)
        {
            string query = string.Format("INSERT INTO HoaDon (idTruSac, dateCheckIn, status, CheDoSac, LoaiKhachHang) VALUES ({0}, GETDATE(), 0, N'{1}', N'{2}')",
                                         idTruSac, cheDo, loaiKhach);

            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void CheckOut(int idBill, double tongTien, double soKwh, int giamGia)
        {
            // 1. Làm tròn 2 chữ số thập phân (Ví dụ: 3.24159 -> 3.24)
            double tienLamTron = Math.Round(tongTien, 2);
            double kwhLamTron = Math.Round(soKwh, 2);

            // 2. Chuyển sang chuỗi với định dạng Quốc tế (Dấu chấm)
            // Nếu máy tính bạn đang để tiếng Việt (dấu phẩy), SQL sẽ báo lỗi cú pháp nếu không làm bước này
            System.Globalization.CultureInfo quocTe = System.Globalization.CultureInfo.InvariantCulture;

            string sqlTien = tienLamTron.ToString(quocTe); // Thành "3200.50"
            string sqlKwh = kwhLamTron.ToString(quocTe);   // Thành "1.25"

            // 3. Câu lệnh SQL
            string query = "UPDATE HoaDon SET dateCheckOut = GETDATE(), status = 1, " +
                           "tongTien = " + sqlTien + ", " +
                           "soKwhTieuThu = " + sqlKwh + ", " +
                           "GiamGia = " + giamGia +
                           " WHERE id = " + idBill;

            DataProvider.Instance.ExcuteNonQuery(query);
        }


        public DateTime GetDateCheckIn(int idBill)
        {
            string query = "SELECT dateCheckIn FROM HoaDon WHERE id = " + idBill;
            object data = DataProvider.Instance.ExcuteScalar(query);

            if (data != null)
            {
                return Convert.ToDateTime(data);
            }
            return DateTime.Now; // Fallback nếu lỗi
        }
    }
}