using ProjectQuanlytramsac.DAO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectQuanlytramsac
{
    public partial class frmadmin : Form
    {
        // Định dạng số Việt Nam
        CultureInfo culture = new CultureInfo("vi-VN");

        // BindingSource cho Tab Trụ sạc
        BindingSource truSacList = new BindingSource();

        public frmadmin()
        {
            InitializeComponent();

            // 1. Load ngày mặc định
            LoadDateTimePickerBill();

            // 2. Load dữ liệu thống kê
            LoadListBillByDate(dtpfromdate.Value, dtptodate.Value);

            // 3. Load dữ liệu Tab Quản lý Trụ sạc
            LoadListTruSac();
        }

        #region TAB 1: THỐNG KÊ DOANH THU

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpfromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtptodate.Value = dtpfromdate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                DataTable data = bill.Instance.GetBillListByDate(checkIn, checkOut);
                dgvbill.DataSource = data;

                double tongDoanhThu = 0;
                foreach (DataRow row in data.Rows)
                {
                    if (row["Tiền (k VNĐ)"] != DBNull.Value)
                    {
                        tongDoanhThu += Convert.ToDouble(row["Tiền (k VNĐ)"]);
                    }
                }

                if (txbdoanhthu != null)
                    txbdoanhthu.Text = tongDoanhThu.ToString("N2", culture) + " k VNĐ";

                if (dgvbill.Rows.Count > 0)
                {
                    dgvbill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Tắt tự động giãn

                    if (dgvbill.Columns.Contains("Mã HĐ"))
                    {
                        dgvbill.Columns["Mã HĐ"].Width = 60;
                        dgvbill.Columns["Mã HĐ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    if (dgvbill.Columns.Contains("Tiền (k VNĐ)"))
                    {
                        dgvbill.Columns["Tiền (k VNĐ)"].DefaultCellStyle.Format = "N2";
                        dgvbill.Columns["Tiền (k VNĐ)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvbill.Columns.Contains("Sản lượng (kWh)"))
                        dgvbill.Columns["Sản lượng (kWh)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    if (dgvbill.Columns.Contains("Công suất (kW)"))
                        dgvbill.Columns["Công suất (kW)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvbill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Bật lại tự động giãn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message);
            }
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpfromdate.Value, dtptodate.Value);
        }

        #endregion

        #region TAB 2: QUẢN LÝ TRỤ SẠC (Đã sửa tên gọi thành 'trusac')

        void LoadListTruSac()
        {
            dtgvtrusac.DataSource = truSacList;
            LoadTruSacData();
            LoadTruSacCombobox();
            AddTruSacBinding();
        }

        void LoadTruSacData()
        {
            // SỬA Ở ĐÂY: Gọi trusac.Instance thay vì TruSacDAO.Instance
            truSacList.DataSource = trusac.Instance.GetListTruSac();

            if (dtgvtrusac.Columns.Count > 0)
            {
                dtgvtrusac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dtgvtrusac.Columns.Contains("id")) dtgvtrusac.Columns["id"].HeaderText = "ID";
                if (dtgvtrusac.Columns.Contains("tenTru")) dtgvtrusac.Columns["tenTru"].HeaderText = "Tên Trụ";
                if (dtgvtrusac.Columns.Contains("trangThai")) dtgvtrusac.Columns["trangThai"].HeaderText = "Trạng thái";
                if (dtgvtrusac.Columns.Contains("LoaiXe")) dtgvtrusac.Columns["LoaiXe"].HeaderText = "Loại xe";
                if (dtgvtrusac.Columns.Contains("CongSuatKW")) dtgvtrusac.Columns["CongSuatKW"].HeaderText = "Công suất (kW)";
            }
        }

        void LoadTruSacCombobox()
        {
            cbitemstatus.Items.Clear();
            cbitemstatus.Items.AddRange(new object[] { "Trống", "Đang sạc", "Bảo trì" });

            cbtypestatus.Items.Clear();
            cbtypestatus.Items.AddRange(new object[] { "Ô tô", "Xe máy" });

            cbpower.Items.Clear();
            cbpower.Items.AddRange(new object[] { "1.2", "2.2", "3.5", "7.4", "11", "22", "30", "60", "120", "150", "180", "250", "360" });
        }


        void AddTruSacBinding()
        {
            txbid.DataBindings.Clear();
            txbnameitem.DataBindings.Clear();
            cbitemstatus.DataBindings.Clear();
            cbtypestatus.DataBindings.Clear();
            cbpower.DataBindings.Clear();

            txbid.DataBindings.Add(new Binding("Text", dtgvtrusac.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbnameitem.DataBindings.Add(new Binding("Text", dtgvtrusac.DataSource, "tenTru", true, DataSourceUpdateMode.Never));
            cbitemstatus.DataBindings.Add(new Binding("Text", dtgvtrusac.DataSource, "trangThai", true, DataSourceUpdateMode.Never));
            cbtypestatus.DataBindings.Add(new Binding("Text", dtgvtrusac.DataSource, "LoaiXe", true, DataSourceUpdateMode.Never));
            cbpower.DataBindings.Add(new Binding("Text", dtgvtrusac.DataSource, "CongSuatKW", true, DataSourceUpdateMode.Never));
        }

        // Nút XEM
        private void btnview_Click(object sender, EventArgs e)
        {
            LoadTruSacData();
        }

        // Nút THÊM
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txbnameitem.Text;
                string status = cbitemstatus.Text;
                string type = cbtypestatus.Text;
                float power = 0;
                float.TryParse(cbpower.Text, out power);

                // SỬA Ở ĐÂY: trusac.Instance
                if (trusac.Instance.InsertTruSac(name, status, type, power))
                {
                    MessageBox.Show("Thêm trụ thành công!");
                    LoadTruSacData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm trụ.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Nút SỬA
        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txbid.Text);
                string name = txbnameitem.Text;
                string status = cbitemstatus.Text;
                string type = cbtypestatus.Text;
                float power = 0;
                float.TryParse(cbpower.Text, out power);

                // SỬA Ở ĐÂY: trusac.Instance
                if (trusac.Instance.UpdateTruSac(id, name, status, type, power))
                {
                    MessageBox.Show("Cập nhật trụ thành công!");
                    LoadTruSacData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa trụ.");
                }
            }
            catch { MessageBox.Show("Vui lòng chọn trụ cần sửa!"); }
        }

        // Nút XÓA
        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txbid.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa trụ này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // SỬA Ở ĐÂY: trusac.Instance
                    if (trusac.Instance.DeleteTruSac(id))
                    {
                        MessageBox.Show("Xóa trụ thành công!");
                        LoadTruSacData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa trụ này (Có thể do đang có hóa đơn).");
                    }
                }
            }
            catch { MessageBox.Show("Vui lòng chọn trụ cần xóa!"); }
        }

        #endregion

        // CÁC HÀM RỖNG GIỮ NGUYÊN
        private void label1_Click(object sender, EventArgs e) { }
        private void tabPage4_Click(object sender, EventArgs e) { }
        private void dtpfromdate_ValueChanged(object sender, EventArgs e) { }
        private void dtptodate_ValueChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void cbitemstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}