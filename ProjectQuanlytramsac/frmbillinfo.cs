using ProjectQuanlytramsac.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmBillInfo : Form
    {
        private int idBill;

        // 1. Định dạng tiền Việt Nam (Dùng dấu phẩy ngăn thập phân: 10,5)
        CultureInfo cultureVN = new CultureInfo("vi-VN");

        // 2. Định dạng Kỹ thuật (Dùng dấu chấm ngăn thập phân: 2.34)
        CultureInfo cultureDot = CultureInfo.InvariantCulture;

        public frmBillInfo(int id)
        {
            InitializeComponent();
            this.idBill = id;

            // Tải dữ liệu ngay khi mở Form
            LoadBillInfo();
        }

        void LoadBillInfo()
        {
            // Câu lệnh SQL lấy đầy đủ thông tin từ bảng Hóa Đơn và Trụ Sạc
            string query = "SELECT h.id AS BillID, t.id AS TruID, t.tenTru, t.CongSuatKW, " +
                           "h.dateCheckIn, h.dateCheckOut, h.soKwhTieuThu, h.GiamGia, h.tongTien " +
                           "FROM HoaDon h, TruSac t " +
                           "WHERE h.idTruSac = t.id AND h.id = " + idBill;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                // --- 1. MÃ HÓA ĐƠN ---
                lblbillid.Text = row["BillID"].ToString();

                // --- 2. MÃ TRỤ SẠC ---
                lblitemid.Text = row["TruID"].ToString();

                // --- 3. TÊN TRỤ SẠC ---
                lblnameitem.Text = row["tenTru"].ToString();

                // --- 4. CÔNG SUẤT TRỤ ---
                // Hiển thị dạng: 7.4 kW, 120 kW
                lblpower.Text = row["CongSuatKW"].ToString() + " kW";

                // --- 5. THỜI GIAN SẠC (Tính bằng GIỜ, lấy 2 số lẻ: 2.34) ---
                DateTime timeIn = (DateTime)row["dateCheckIn"];
                DateTime timeOut = (DateTime)row["dateCheckOut"];
                TimeSpan duration = timeOut - timeIn;
                double totalHours = duration.TotalHours;

                // Định dạng "0.00" với dấu chấm (InvariantCulture)
                lbltimeuse.Text = totalHours.ToString("0.00", cultureDot) + " giờ";

                // --- 6. SỐ ĐIỆN TIÊU THỤ (Lấy 2 số lẻ: 3.42) ---
                double kwh = Convert.ToDouble(row["soKwhTieuThu"]);
                lblelecuse.Text = kwh.ToString("0.00", cultureDot) + " kWh";

                // --- 7. GIẢM GIÁ ---
                lbldiscount.Text = row["GiamGia"].ToString() + "%";

                // --- 8. THÀNH TIỀN (Định dạng xxx,x VNĐ) ---
                double tongTien = Convert.ToDouble(row["tongTien"]);

                // Định dạng "N1" với văn hóa Việt Nam sẽ ra: 1.000,5 (Dấu phẩy ở cuối)
                lbltotal.Text = tongTien.ToString("N1", cultureVN) + " VNĐ";
            }
        }

        // Nút đóng (Nếu bạn có nút btnClose)
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}