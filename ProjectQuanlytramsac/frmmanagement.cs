using ProjectQuanlytramsac.DAO;
using ProjectQuanlytramsac.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmmanagement : Form
    {
        // 1. Biến toàn cục
        private items selectedTru = null;
        private DateTime timeBatDauSac;
        private int phanTramGiamGia = 0;

        // --- THÊM BIẾN NÀY ĐỂ HẾT LỖI ---
        private changeinfo loginAccount;
        // -------------------------------

        // Bộ định dạng Tiếng Việt (3,5 k)
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

        // --- SỬA CONSTRUCTOR ĐỂ NHẬN TÀI KHOẢN ---
        public frmmanagement(changeinfo acc)
        {
            InitializeComponent();

            this.loginAccount = acc; // Lưu lại tài khoản

            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            try
            {
                LoadTramSac();
                LoadCombobox();

                // Hiển thị tên người dùng lên Menu
                if (acc != null)
                {
                    thôngTinCáNhânToolStripMenuItem.Text = $"Thông tin ({acc.DisplayName})";

                    // Phân quyền: Nếu là Nhân viên (Type = 0) thì ẩn nút Admin
                    // (Giả sử Type 1 là Admin)
                    // pToolStripMenuItem là nút Admin của bạn
                    pToolStripMenuItem.Enabled = (acc.Type == 1);
                }
            }
            catch { }
        }

        #region Methods

        void LoadTramSac()
        {
            flpitem.Controls.Clear();

            // 1. Lấy dữ liệu mới nhất từ SQL
            List<items> listTru = item.Instance.loaditemlist();

            foreach (items it in listTru)
            {
                Button btn = new Button() { Width = items.itemwidth, Height = items.itemheight };
                btn.Text = it.TenTru + "\n" + it.CongSuatKW + "kW\n" + it.TrangThai;
                btn.Tag = it;

                // 2. XỬ LÝ CHUỖI TRƯỚC KHI SO SÁNH (QUAN TRỌNG)
                string statusChuan = it.TrangThai.Trim().ToLower();

                switch (statusChuan)
                {
                    case "trống":
                        btn.BackColor = Color.LightGreen;
                        break;

                    case "đang sạc":
                        btn.BackColor = Color.OrangeRed;
                        break;

                    case "bảo trì":
                        btn.BackColor = Color.Gray;
                        break;

                    default:
                        btn.BackColor = Color.White;
                        break;
                }

                btn.Click += btn_Click;
                flpitem.Controls.Add(btn);
            }
        }

        void LoadCombobox()
        {
            numdiscount.Minimum = 0;
            numdiscount.Maximum = 100;

            cbchargetype.Items.Clear();
            cbchargetype.Items.Add("Sạc đầy");
            cbchargetype.Items.Add("Sạc theo giờ");
            cbchargetype.Items.Add("Sạc theo tiền");
            cbchargetype.SelectedIndex = 0;

            cbguesttype.Items.Clear();
            cbguesttype.Items.Add("Vãng lai");
            cbguesttype.Items.Add("Thành viên");
            cbguesttype.Items.Add("VIP");
            cbguesttype.SelectedIndex = 0;
        }

        void ShowBill(int idTru)
        {
            lsvbill.Items.Clear();
            int idBill = bill.Instance.getuncheckbillbyitemid(idTru);

            timerSac.Stop();

            if (idBill != -1)
            {
                timeBatDauSac = bill.Instance.GetDateCheckIn(idBill);

                ListViewItem lsvItem = new ListViewItem("Điện năng (00:00:00)");
                lsvItem.SubItems.Add("0.0"); // Cột 1: Số điện

                // Cột 2: Hiện công suất thực tế
                if (selectedTru != null)
                    lsvItem.SubItems.Add(selectedTru.CongSuatKW.ToString());
                else
                    lsvItem.SubItems.Add("0");

                lsvItem.SubItems.Add("0");   // Cột 3: Thành tiền
                lsvbill.Items.Add(lsvItem);

                timerSac.Start();
                txbtotalmoney.Text = "Đang sạc...";
            }
            else
            {
                txbtotalmoney.Text = "0";
            }
        }

        #endregion

        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            selectedTru = (sender as Button).Tag as items;

            this.Text = $"Đang chọn: {selectedTru.TenTru} (Công suất: {selectedTru.CongSuatKW} kW)";

            ShowBill(selectedTru.ID);

            string status = selectedTru.TrangThai.Trim().ToLower();

            if (status == "trống")
            {
                btnstart.Enabled = true;
                btnpay.Enabled = false;
                btnrepair.Text = "Báo hỏng";
            }
            else if (status == "đang sạc")
            {
                btnstart.Enabled = false;
                btnpay.Enabled = true;
                btnrepair.Enabled = false;
            }
            else
            {
                btnstart.Enabled = false;
                btnpay.Enabled = false;
                btnrepair.Text = "Hoàn tất sửa";
                btnrepair.Enabled = true;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (selectedTru == null) return;
            bill.Instance.InsertBill(selectedTru.ID, cbchargetype.Text, cbguesttype.Text);
            item.Instance.UpdateStatus(selectedTru.ID, "Đang sạc");
            LoadTramSac();
            ShowBill(selectedTru.ID);
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (selectedTru == null) return;

            int idTru = selectedTru.ID;
            int idBill = bill.Instance.getuncheckbillbyitemid(idTru);

            if (idBill != -1)
            {
                string msg = "Thanh toán trụ " + selectedTru.TenTru + "?\n" +
                             "Công suất: " + selectedTru.CongSuatKW + " kW\n" +
                             "Giảm giá: " + phanTramGiamGia + "%";

                if (MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DateTime timeVao = bill.Instance.GetDateCheckIn(idBill);
                    double soGio = (DateTime.Now - timeVao).TotalHours;

                    double soKwh = selectedTru.CongSuatKW * soGio;
                    double tongTienGoc = soKwh * 3000;

                    double tienGiam = tongTienGoc * ((double)phanTramGiamGia / 100);
                    double thucThu = tongTienGoc - tienGiam;
                    if (thucThu < 0) thucThu = 0;

                    bill.Instance.CheckOut(idBill, thucThu, soKwh, phanTramGiamGia);
                    item.Instance.UpdateStatus(idTru, "Trống");

                    phanTramGiamGia = 0;
                    numdiscount.Value = 0;

                    txbtotalmoney.Text = (thucThu / 1000).ToString("0.#", culture);

                    timerSac.Stop();
                    LoadTramSac();
                    ShowBill(idTru);

                    frmbillinfo f = new frmbillinfo(idBill);
                    f.ShowDialog();
                }
            }
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (selectedTru == null) return;

            string status = selectedTru.TrangThai.Trim().ToLower();

            if (status == "trống")
                item.Instance.UpdateStatus(selectedTru.ID, "Bảo trì");
            else if (status == "bảo trì")
                item.Instance.UpdateStatus(selectedTru.ID, "Trống");

            LoadTramSac();
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            phanTramGiamGia = (int)numdiscount.Value;
            timersac_Tick(null, null);
        }

        private void timersac_Tick(object sender, EventArgs e)
        {
            if (selectedTru == null || selectedTru.TrangThai.Trim().ToLower() != "đang sạc")
            {
                timerSac.Stop();
                return;
            }

            TimeSpan duration = DateTime.Now - timeBatDauSac;
            double soGio = duration.TotalHours;

            double kwh = selectedTru.CongSuatKW * soGio;
            double tongTienGoc = kwh * 3000;

            double tienGiam = tongTienGoc * ((double)phanTramGiamGia / 100);
            double thucThu = tongTienGoc - tienGiam;
            if (thucThu < 0) thucThu = 0;

            if (lsvbill.Items.Count > 0)
            {
                ListViewItem item = lsvbill.Items[0];
                item.SubItems[1].Text = kwh.ToString("0.0") + " kWh";

                if (item.SubItems.Count > 2)
                    item.SubItems[2].Text = selectedTru.CongSuatKW.ToString();

                if (item.SubItems.Count > 3)
                    item.SubItems[3].Text = (tongTienGoc / 1000).ToString("0.#", culture) + " k";

                string strTime = string.Format("{0:00}:{1:00}:{2:00}", duration.Hours, duration.Minutes, duration.Seconds);
                item.Text = "Điện năng (" + strTime + ")";
            }

            txbtotalmoney.Text = (thucThu / 1000).ToString("0.#", culture);
        }

        #endregion

        // CÁC HÀM CỨU HỘ GIAO DIỆN & MENU

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadmin f = new frmadmin();
            f.ShowDialog();
            LoadTramSac(); // Cập nhật màu sau khi tắt Admin
        }

        // --- SỰ KIỆN NÚT THÔNG TIN CÁ NHÂN ---
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Truyền loginAccount sang form đổi mật khẩu
            frmchangepass f = new frmchangepass(loginAccount);

            // Đăng ký sự kiện cập nhật tên
            f.UpdateAccountEvent += F_UpdateAccountEvent;

            f.ShowDialog();
        }

        // Hàm xử lý khi Form con báo về là "Đã đổi tên xong"
        void F_UpdateAccountEvent(object sender, frmchangepass.AccountEvent e)
        {
            // Cập nhật lại tên hiển thị trên Menu
            thôngTinCáNhânToolStripMenuItem.Text = $"Thông tin ({e.Acc.DisplayName})";
        }

        private void đToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void lsvbill_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numdiscount_ValueChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { btndiscount_Click(sender, e); }
    }
}