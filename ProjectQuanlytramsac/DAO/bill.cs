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
            // --- BƯỚC 1: QUY ĐỔI ĐƠN VỊ TIỀN ---
            // Bạn muốn lưu 3 nghìn là 3.00 -> Phải chia cho 1000
            double tienLuuDatabase = tongTien / 1000;

            // --- BƯỚC 2: LÀM TRÒN SỐ LIỆU ---
            // Làm tròn 2 số thập phân (Ví dụ: 3.456 -> 3.46)
            double tienLamTron = Math.Round(tienLuuDatabase, 2);
            double kwhLamTron = Math.Round(soKwh, 2);

            // --- BƯỚC 3: ĐỊNH DẠNG DẤU CHẤM (CHO SQL) ---
            // Bắt buộc dùng CultureInfo.InvariantCulture để ra dấu chấm (3.00) thay vì dấu phẩy
            System.Globalization.CultureInfo quocTe = System.Globalization.CultureInfo.InvariantCulture;

            string sqlTien = tienLamTron.ToString(quocTe); // Kết quả sẽ là "3.00" hoặc "3.50"
            string sqlKwh = kwhLamTron.ToString(quocTe);   // Kết quả sẽ là "1.25"

            // --- BƯỚC 4: TÍNH THỜI GIAN SẠC (PHÚT) ---
            string queryGetTime = "SELECT dateCheckIn FROM HoaDon WHERE id = " + idBill;
            object result = DataProvider.Instance.ExcuteScalar(queryGetTime);
            int tongPhut = 0;
            if (result != null)
            {
                DateTime timeIn = (DateTime)result;
                tongPhut = (int)(DateTime.Now - timeIn).TotalMinutes;
            }

            // --- BƯỚC 5: GỬI LỆNH CẬP NHẬT VÀO SQL ---
            string query = "UPDATE HoaDon SET dateCheckOut = GETDATE(), status = 1, " +
                           "tongTien = " + sqlTien + ", " +       // Lưu số nhỏ (3.00)
                           "soKwhTieuThu = " + sqlKwh + ", " +
                           "thoiGianSacPhut = " + tongPhut + ", " +
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

        // Thêm vào trong class bill của file DAO/bill.cs
        public System.Data.DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string start = checkIn.ToString("yyyy-MM-dd");
            string end = checkOut.ToString("yyyy-MM-dd");

            // Lấy FULL thông tin
            string query = string.Format(
                "SELECT " +
                "h.id AS [Mã HĐ], " +                  // Mới
                "t.tenTru AS [Tên trụ], " +
                "t.LoaiXe AS [Loại xe], " +            // Mới
                "t.CongSuatKW AS [Công suất (kW)], " + // Mới
                "h.LoaiKhachHang AS [Khách hàng], " +  // Mới
                "h.CheDoSac AS [Chế độ sạc], " +       // Mới
                "h.dateCheckIn AS [Giờ vào], " +
                "h.dateCheckOut AS [Giờ ra], " +
                "h.thoiGianSacPhut AS [Số phút], " +   // Mới (nếu DB bạn đã có cột này)
                "h.soKwhTieuThu AS [Sản lượng (kWh)], " +
                "h.GiamGia AS [Giảm (%)], " +
                "h.tongTien AS [Tiền (k VNĐ)] " +
                "FROM HoaDon AS h, TruSac AS t " +
                "WHERE h.idTruSac = t.id " +
                "AND h.status = 1 " +
                "AND h.dateCheckIn >= '{0}' AND h.dateCheckIn <= '{1} 23:59:59'", start, end);

            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}