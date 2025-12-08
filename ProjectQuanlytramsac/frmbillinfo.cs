using ProjectQuanlytramsac.DAO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmbillinfo : Form
    {
        private int idBill;

        // Định dạng Tiền Việt (Dùng dấu phẩy ngăn thập phân: 4,0)
        CultureInfo cultureVN = new CultureInfo("vi-VN");

        // Định dạng Kỹ thuật (Dùng dấu chấm: 2.34)
        CultureInfo cultureDot = CultureInfo.InvariantCulture;

        public frmbillinfo(int id)
        {
            InitializeComponent();
            this.idBill = id;
            LoadBillInfo();
        }

        void LoadBillInfo()
        {
            try
            {
                string query = "SELECT h.id AS BillID, t.id AS TruID, t.tenTru, t.CongSuatKW, " +
                               "h.dateCheckIn, h.dateCheckOut, h.soKwhTieuThu, h.GiamGia, h.tongTien " +
                               "FROM HoaDon h, TruSac t " +
                               "WHERE h.idTruSac = t.id AND h.id = " + idBill;

                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    // 1. Mã hóa đơn (Thêm dấu #) -> #4
                    lblbillid.Text = "#" + row["BillID"].ToString();

                    // 2. Mã trụ
                    lblitemid.Text = row["TruID"].ToString();

                    // 3. Tên trụ
                    lblnameitem.Text = row["tenTru"].ToString();

                    // 4. Công suất (Thêm kW) -> 12 kW
                    lblpower.Text = row["CongSuatKW"].ToString() + " kW";

                    // 5. Thời gian sạc (Thêm h) -> 0.00 h
                    DateTime timeIn = Convert.ToDateTime(row["dateCheckIn"]);
                    DateTime timeOut = DateTime.Now;
                    if (row["dateCheckOut"].ToString() != "")
                        timeOut = Convert.ToDateTime(row["dateCheckOut"]);

                    TimeSpan duration = timeOut - timeIn;
                    lbltimeuse.Text = duration.TotalHours.ToString("0.00", cultureDot) + " h";

                    // 6. Điện tiêu thụ (Thêm kWh) -> 0.40 kWh
                    double kwh = 0;
                    if (row["soKwhTieuThu"].ToString() != "")
                        kwh = Convert.ToDouble(row["soKwhTieuThu"]);

                    lblelecuse.Text = kwh.ToString("0.00", cultureDot) + " kWh";

                    // 7. Giảm giá (Thêm %) -> 5%
                    lbldiscount.Text = row["GiamGia"].ToString() + "%";

                    // --- 8. THÀNH TIỀN (SỬA THEO YÊU CẦU CỦA BẠN) ---
                    double tongTien = 0;
                    if (row["tongTien"].ToString() != "")
                        tongTien = Convert.ToDouble(row["tongTien"]);

                    // Chia cho 1000 để đổi đơn vị
                    double tienHienThi = tongTien / 1000;

                    // Dùng "N1" để BẮT BUỘC hiện 1 số lẻ (4 -> 4,0)
                    // Kết quả: "4,0 VNĐ" hoặc "1.000,0 VNĐ"
                    lbltotal.Text = tienHienThi.ToString("N1", cultureVN) + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        // --- CÁC HÀM CỨU HỘ DESIGNER ---
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}