using ProjectQuanlytramsac.DTO;
using System;
using System.Data;
using System.Globalization; // Cần thiết để định dạng dấu chấm thập phân cho SQL

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
                // Giả định class bills tồn tại trong ProjectQuanlytramsac.DTO
                bills bill = new bills(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int idTruSac, string cheDo, string loaiKhach)
        {
            // GIỮ NGUYÊN
            string query = string.Format("INSERT INTO HoaDon (idTruSac, dateCheckIn, status, CheDoSac, LoaiKhachHang) VALUES ({0}, GETDATE(), 0, N'{1}', N'{2}')",
                                         idTruSac, cheDo, loaiKhach);

            DataProvider.Instance.ExcuteNonQuery(query);
        }

        // --- HÀM CHECKOUT ĐÃ SỬA: NHẬN 7 ĐỐI SỐ (KHẮC PHỤC CS1501) VÀ CẬP NHẬT ĐẦY ĐỦ DỮ LIỆU ---
        public void CheckOut(int idBill, double tongTien, double soKwh, int giamGia, int thoiGianSacPhut, string cheDoSac, string loaiKhachHang)
        {
            // tongTien được truyền vào là tổng tiền thực thu (đã giảm) tính bằng VNĐ.

            // --- BƯỚC 1: QUY ĐỔI ĐƠN VỊ TIỀN ---
            // Quy đổi từ VNĐ sang "k VNĐ" (Ví dụ: 3000 VNĐ -> 3.00) để lưu vào cột 'tongTien'.
            // Cột 'tongTien' trong DB nên được đổi tên/hiểu là đơn vị 'k VNĐ'
            double tienLuuDatabase = tongTien / 1000;

            // --- BƯỚC 2: LÀM TRÒN SỐ LIỆU ---
            // Làm tròn 2 số thập phân
            double tienLamTron = Math.Round(tienLuuDatabase, 2);
            double kwhLamTron = Math.Round(soKwh, 2);

            // --- BƯỚC 3: ĐỊNH DẠNG DẤU CHẤM (CHO SQL) ---
            // Bắt buộc dùng CultureInfo.InvariantCulture để ra dấu chấm (3.00) thay vì dấu phẩy
            CultureInfo quocTe = CultureInfo.InvariantCulture;

            string sqlTien = tienLamTron.ToString(quocTe);
            string sqlKwh = kwhLamTron.ToString(quocTe);

            // --- BƯỚC 4: GỬI LỆNH CẬP NHẬT VÀO SQL ---
            string query = string.Format(
                "UPDATE HoaDon SET dateCheckOut = GETDATE(), status = 1, " +
                "tongTien = {0}, " + // Tiền thực thu (k VNĐ)
                "soKwhTieuThu = {1}, " + // Sản lượng (kWh)
                "GiamGia = {2}, " + // Giảm (%)
                "thoiGianSacPhut = {3}, " + // Số phút
                "CheDoSac = N'{4}', " + // Chế độ sạc
                "LoaiKhachHang = N'{5}' " + // Loại khách hàng
                "WHERE id = {6}",
                sqlTien, sqlKwh, giamGia, thoiGianSacPhut, cheDoSac, loaiKhachHang, idBill);

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

        // Hàm GetBillListByDate: GIỮ NGUYÊN nhưng đã sửa lại nhãn cột [Tiền (k VNĐ)] cho rõ ràng.
        // --- SỬA TRONG FILE bill.cs (billDAO.cs) ---
        public System.Data.DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string start = checkIn.ToString("yyyy-MM-dd");
            string end = checkOut.ToString("yyyy-MM-dd");

            // Lấy FULL thông tin
            string query = string.Format(
                "SELECT " +
                "h.id AS [Mã HĐ], " +
                "t.tenTru AS [Tên trụ], " +
                "t.LoaiXe AS [Loại xe], " +
                "t.CongSuatKW AS [Công suất (kW)], " +
                "h.LoaiKhachHang AS [Khách hàng], " +
                "h.CheDoSac AS [Chế độ sạc], " +
                "h.dateCheckIn AS [Giờ vào], " +
                "h.dateCheckOut AS [Giờ ra], " +
                "h.thoiGianSacPhut AS [Số phút], " +
                "h.soKwhTieuThu AS [Sản lượng (kWh)], " +
                "h.GiamGia AS [Giảm (%)], " +
                // --- ĐÃ SỬA: NHÂN VỚI 1000 VÀ ĐẶT LẠI NHÃN CỘT ---
                "h.tongTien * 1000 AS [Tiền (k VNĐ)] " +
                "FROM HoaDon AS h, TruSac AS t " +
                "WHERE h.idTruSac = t.id " +
                "AND h.status = 1 " +
                "AND h.dateCheckIn >= '{0}' AND h.dateCheckIn <= '{1} 23:59:59'", start, end);

            return DataProvider.Instance.ExcuteQuery(query);
        }

    }
}