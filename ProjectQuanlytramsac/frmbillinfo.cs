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

        // Định dạng Tiền Việt (Dùng dấu phẩy ngăn thập phân, ví dụ: 4.000 VNĐ)
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
                // Truy vấn các trường cần thiết, bao gồm LoaiKhachHang và CheDoSac
                string query = "SELECT h.id AS BillID, t.id AS TruID, t.tenTru, t.CongSuatKW, " +
                                 "h.dateCheckIn, h.dateCheckOut, h.soKwhTieuThu, h.GiamGia, h.tongTien, " +
                                 "h.LoaiKhachHang, h.CheDoSac " +
                                 "FROM HoaDon h, TruSac t " +
                                 "WHERE h.idTruSac = t.id AND h.id = " + idBill;

                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];

                    // 1. Mã hóa đơn (Thêm dấu #)
                    lblbillid.Text = "#" + row["BillID"].ToString();

                    // 2. Mã trụ
                    lblitemid.Text = row["TruID"].ToString();

                    // 3. Tên trụ
                    lblnameitem.Text = row["tenTru"].ToString();

                    // 4. Công suất (Thêm kW)
                    lblpower.Text = row["CongSuatKW"].ToString() + " kW";

                    // Thêm thông tin mới (Nếu có Label tương ứng trên Form)
                    // Nếu bạn có label để hiển thị loại khách và chế độ sạc, hãy uncomment:
                    // lbllaiKhach.Text = row["LoaiKhachHang"].ToString();
                    // lblchedoSac.Text = row["CheDoSac"].ToString();

                    // 5. Thời gian sạc (Tính giờ)
                    DateTime timeIn = Convert.ToDateTime(row["dateCheckIn"]);
                    DateTime timeOut = DateTime.Now;
                    if (row["dateCheckOut"].ToString() != "")
                        timeOut = Convert.ToDateTime(row["dateCheckOut"]);

                    TimeSpan duration = timeOut - timeIn;
                    lbltimeuse.Text = duration.TotalHours.ToString("0.00", cultureDot) + " h";

                    // 6. Điện tiêu thụ (kWh)
                    double kwh = 0;
                    if (row["soKwhTieuThu"].ToString() != "")
                        kwh = Convert.ToDouble(row["soKwhTieuThu"], cultureDot); // Đảm bảo đọc đúng dấu chấm

                    lblelecuse.Text = kwh.ToString("0.00", cultureDot) + " kWh";

                    // 7. Giảm giá (%)
                    lbldiscount.Text = row["GiamGia"].ToString() + "%";

                    double tongTien_K_VND = 0;
                    if (row["tongTien"].ToString() != "")
                    {
                        // Sử dụng cultureDot để đọc đúng số thập phân (dấu chấm) từ DB
                        tongTien_K_VND = Convert.ToDouble(row["tongTien"], cultureDot);
                    }

                    // Giá trị thực tế (giả sử đơn vị trong DB là K VNĐ)
                    double tienThucTe_VN_D = tongTien_K_VND;

                    // SỬA ĐỔI LOGIC HIỂN THỊ:
                    // Mục đích: Nếu giá trị gốc là 3.000 VNĐ, bạn muốn hiển thị 3.00 VNĐ (tức là K VNĐ)
                    // => Chúng ta dùng giá trị tongTien_K_VND trực tiếp, hoặc chia cho 1000 nếu tongTien là VNĐ.

                    // Giả định rằng tongTien_K_VND đã là giá trị chia cho 1000 (Ví dụ: 3000 VNĐ => 3.00)
                    double tienHienThi_K_VND = tongTien_K_VND;

                    // Hiển thị dạng số thập phân, giữ 2 chữ số sau dấu phẩy (N2)
                    // Nếu cultureVN sử dụng dấu phẩy làm dấu thập phân: 3,00 VNĐ
                    // Nếu cultureVN sử dụng dấu chấm làm dấu thập phân: 3.00 VNĐ
                    lbltotal.Text = tienHienThi_K_VND.ToString("N2", cultureVN) + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message);
            }
        }

        // --- CÁC HÀM CỨU HỘ DESIGNER ---
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}