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

            LoadAccount(); // <--- THÊM DÒNG NÀY ĐỂ KÍCH HOẠT TAB TÀI KHOẢN
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







        // --- KHAI BÁO BIẾN BINDING TÀI KHOẢN ---
        BindingSource accountList = new BindingSource();

        // --- CẬP NHẬT CONSTRUCTOR ---
        // Tìm đến public frmadmin() và thêm dòng LoadAccount();
        /*
        public frmadmin()
        {
            InitializeComponent();
            // ... các hàm load cũ ...
            LoadListTruSac();
            
            LoadAccount(); // <--- THÊM DÒNG NÀY ĐỂ KÍCH HOẠT TAB TÀI KHOẢN
        }
        */

        // --- KHAI BÁO BIẾN BINDING TÀI KHOẢN ---
        BindingSource accountlist = new BindingSource();

        #region TAB 3: QUẢN LÝ TÀI KHOẢN (HIỂN THỊ FULL DATA + MẬT KHẨU)

        void LoadAccount()
        {
            dtgvlistacc.DataSource = accountList;
            LoadAccountList();
            LoadAccountComboBox();
            AddAccountBinding();
        }

        // 1. Tải danh sách tài khoản
        void LoadAccountList()
        {
            // Lấy danh sách từ DAO (đã sửa để lấy cả PassWord)
            accountList.DataSource = Account.Instance.GetListAccount();

            // Trang trí bảng
            if (dtgvlistacc.Columns.Count > 0)
            {
                dtgvlistacc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvlistacc.Columns["UserName"].HeaderText = "Tên đăng nhập";
                dtgvlistacc.Columns["DisplayName"].HeaderText = "Tên hiển thị";
                dtgvlistacc.Columns["Type"].HeaderText = "Quyền tài khoản";
                // --- THÊM CỘT MẬT KHẨU ---
                if (dtgvlistacc.Columns.Contains("PassWord"))
                    dtgvlistacc.Columns["PassWord"].HeaderText = "Mật khẩu";
            }
        }

        // 2. Nạp dữ liệu cho ComboBox Loại tài khoản (Giữ nguyên)
        void LoadAccountComboBox()
        {
            cbtypeacc.Items.Clear();
            cbtypeacc.Items.Add("Nhân viên"); // Index 0 -> Type = 0
            cbtypeacc.Items.Add("Admin");     // Index 1 -> Type = 1
            cbtypeacc.SelectedIndex = 0;
        }

        // 3. Binding: Liên kết dữ liệu từ bảng vào ô nhập (THÊM MẬT KHẨU)
        void AddAccountBinding()
        {
            txtnameacc.DataBindings.Clear();
            txtshowname.DataBindings.Clear();
            txtpassword.DataBindings.Clear(); // Xóa binding cũ của mật khẩu (nếu có)

            // Binding Tên đăng nhập, Tên hiển thị
            txtnameacc.DataBindings.Add(new Binding("Text", dtgvlistacc.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtshowname.DataBindings.Add(new Binding("Text", dtgvlistacc.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));

            // --- BINDING MẬT KHẨU (Hiện thẳng lên ô txtpassword) ---
            txtpassword.DataBindings.Add(new Binding("Text", dtgvlistacc.DataSource, "PassWord", true, DataSourceUpdateMode.Never));

            // Logic cập nhật ComboBox Loại TK
            txtnameacc.TextChanged += Txtnameacc_TextChanged;
        }

        // Hàm phụ để cập nhật ComboBox khi chọn dòng khác trên bảng (Giữ nguyên)
        private void Txtnameacc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvlistacc.SelectedCells.Count > 0)
                {
                    var cellValue = dtgvlistacc.SelectedCells[0].OwningRow.Cells["Type"].Value;
                    if (cellValue != DBNull.Value)
                    {
                        int id = (int)cellValue;
                        if (id == 1) cbtypeacc.SelectedIndex = 1;
                        else cbtypeacc.SelectedIndex = 0;
                    }
                }
            }
            catch { }
        }

        // --- SỰ KIỆN NÚT BẤM ---

        // 1. Nút XEM (btnviewacc)
        private void btnviewacc_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        // 2. Nút THÊM (btnaddacc) - Giữ nguyên logic Password mặc định '0'
        private void btnaddacc_Click(object sender, EventArgs e)
        {
            string userName = txtnameacc.Text;
            string displayName = txtshowname.Text;
            int type = cbtypeacc.SelectedIndex;

            try
            {
                if (Account.Instance.InsertAccount(userName, displayName, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công!\nMật khẩu mặc định là: admin");
                    LoadAccountList();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại (Tên đăng nhập đã tồn tại).");
                }
            }
            catch { MessageBox.Show("Lỗi hệ thống khi thêm tài khoản."); }
        }

        // 3. Nút SỬA (btnchangeacc) -> Cập nhật cả Mật khẩu
        private void btnchangeacc_Click(object sender, EventArgs e)
        {
            string userName = txtnameacc.Text;
            string displayName = txtshowname.Text;
            int type = cbtypeacc.SelectedIndex;
            string password = txtpassword.Text; // LẤY MẬT KHẨU TỪ Ô NHẬP

            // Gọi hàm Update có thêm tham số password (Đã sửa trong DAO)
            if (Account.Instance.UpdateAccount(userName, displayName, type, password))
            {
                MessageBox.Show("Cập nhật thông tin & mật khẩu thành công!");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        // 4. Nút XÓA (btnremoveacc) - Giữ nguyên
        private void btnremoveacc_Click(object sender, EventArgs e)
        {
            string userName = txtnameacc.Text;

            // Bảo vệ tài khoản Admin gốc
            if (userName.ToLower() == "admin")
            {
                MessageBox.Show("Không được xóa tài khoản Admin gốc!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Account.Instance.DeleteAccount(userName))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadAccountList();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
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