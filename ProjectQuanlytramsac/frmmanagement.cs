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

        // Bộ định dạng Tiếng Việt (3,5 k)
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

        public frmmanagement()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            try
            {
                LoadTramSac();
                LoadCombobox();
            }
            catch { }
        }

        #region Methods

        void LoadTramSac()
        {
            flpitem.Controls.Clear();
            List<items> listTru = item.Instance.loaditemlist();

            foreach (items it in listTru)
            {
                Button btn = new Button() { Width = items.itemwidth, Height = items.itemheight };
                // Hiện tên và công suất lên nút cho dễ nhìn
                btn.Text = it.TenTru + "\n" + it.CongSuatKW + "kW\n" + it.TrangThai;
                btn.Tag = it;

                switch (it.TrangThai)
                {
                    case "Trống": btn.BackColor = Color.LightGreen; break;
                    case "Đang sạc": btn.BackColor = Color.OrangeRed; break;
                    case "Bảo trì": btn.BackColor = Color.Gray; break;
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

                // CẤU TRÚC LISTVIEW: 
                // Cột 0: Thời gian | Cột 1: Số điện | Cột 2: Công suất | Cột 3: Thành tiền

                ListViewItem lsvItem = new ListViewItem("Điện năng (00:00:00)");
                lsvItem.SubItems.Add("0.0"); // Cột 1: Số điện

                // --- SỬA Ở ĐÂY: Hiện đúng công suất của trụ ---
                lsvItem.SubItems.Add(selectedTru.CongSuatKW.ToString()); // Cột 2: Công suất (7.4, 30, 120...)
                                                                         // ----------------------------------------------

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

            // Hiện rõ công suất lên tiêu đề Form
            this.Text = $"Đang chọn: {selectedTru.TenTru} (Công suất: {selectedTru.CongSuatKW} kW)";

            ShowBill(selectedTru.ID);

            if (selectedTru.TrangThai == "Trống")
            {
                btnstart.Enabled = true;
                btnpay.Enabled = false;
                btnrepair.Text = "Báo hỏng";
            }
            else if (selectedTru.TrangThai == "Đang sạc")
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

                    // Tính toán theo công suất thực
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


                }
            }
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (selectedTru == null) return;
            if (selectedTru.TrangThai == "Trống")
                item.Instance.UpdateStatus(selectedTru.ID, "Bảo trì");
            else if (selectedTru.TrangThai == "Bảo trì")
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
            if (selectedTru == null || selectedTru.TrangThai != "Đang sạc")
            {
                timerSac.Stop();
                return;
            }

            // 1. Tính toán
            TimeSpan duration = DateTime.Now - timeBatDauSac;
            double soGio = duration.TotalHours;

            // Công suất thực của trụ * Số giờ = Số kWh
            double kwh = selectedTru.CongSuatKW * soGio;
            double tongTienGoc = kwh * 3000;

            double tienGiam = tongTienGoc * ((double)phanTramGiamGia / 100);
            double thucThu = tongTienGoc - tienGiam;
            if (thucThu < 0) thucThu = 0;

            // 3. Hiển thị
            if (lsvbill.Items.Count > 0)
            {
                ListViewItem item = lsvbill.Items[0];

                // Cột 1: Số điện
                item.SubItems[1].Text = kwh.ToString("0.0") + " kWh";

                // --- SỬA Ở ĐÂY: Cột 2 hiển thị Công suất ---
                if (item.SubItems.Count > 2)
                {
                    item.SubItems[2].Text = selectedTru.CongSuatKW.ToString();
                }
                // -------------------------------------------

                // Cột 3: Thành tiền (3,5 k)
                if (item.SubItems.Count > 3)
                {
                    item.SubItems[3].Text = (tongTienGoc / 1000).ToString("0.#", culture) + " k";
                }

                string strTime = string.Format("{0:00}:{1:00}:{2:00}", duration.Hours, duration.Minutes, duration.Seconds);
                item.Text = "Điện năng (" + strTime + ")";
            }

            txbtotalmoney.Text = (thucThu / 1000).ToString("0.#", culture);
        }

        #endregion

        // CÁC HÀM CỨU HỘ GIAO DIỆN
        private void pToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccount f = new frmaccount();
            f.ShowDialog();
        }
        private void đToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void lsvbill_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numdiscount_ValueChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { btndiscount_Click(sender, e); }
    }
}