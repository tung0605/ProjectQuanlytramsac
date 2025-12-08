namespace ProjectQuanlytramsac
{
    partial class frmadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbdoanhthu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbitemstatus = new System.Windows.Forms.ComboBox();
            this.txbnameitem = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.cmitemstatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvtrusac = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbtypeacc = new System.Windows.Forms.ComboBox();
            this.txtshowname = new System.Windows.Forms.TextBox();
            this.txtnameacc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgvlistacc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnremoveacc = new System.Windows.Forms.Button();
            this.btnchangeacc = new System.Windows.Forms.Button();
            this.btnaddacc = new System.Windows.Forms.Button();
            this.btnviewacc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtypestatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbpower = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtrusac)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistacc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvbill);
            this.panel7.Location = new System.Drawing.Point(6, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(745, 353);
            this.panel7.TabIndex = 1;
            // 
            // dgvbill
            // 
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(3, 3);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.Size = new System.Drawing.Size(739, 347);
            this.dgvbill.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbdoanhthu);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.btnthongke);
            this.panel6.Controls.Add(this.dtptodate);
            this.panel6.Controls.Add(this.dtpfromdate);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(745, 48);
            this.panel6.TabIndex = 0;
            // 
            // txbdoanhthu
            // 
            this.txbdoanhthu.Location = new System.Drawing.Point(658, 13);
            this.txbdoanhthu.Name = "txbdoanhthu";
            this.txbdoanhthu.ReadOnly = true;
            this.txbdoanhthu.Size = new System.Drawing.Size(84, 20);
            this.txbdoanhthu.TabIndex = 4;
            this.txbdoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doanh thu:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(444, 3);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(137, 42);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dtptodate
            // 
            this.dtptodate.Location = new System.Drawing.Point(238, 14);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(200, 20);
            this.dtptodate.TabIndex = 2;
            this.dtptodate.ValueChanged += new System.EventHandler(this.dtptodate_ValueChanged);
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Location = new System.Drawing.Point(14, 14);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(200, 20);
            this.dtpfromdate.TabIndex = 1;
            this.dtpfromdate.ValueChanged += new System.EventHandler(this.dtpfromdate_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê trạm sạc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbpower);
            this.panel5.Controls.Add(this.cbtypestatus);
            this.panel5.Controls.Add(this.cbitemstatus);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txbnameitem);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txbid);
            this.panel5.Controls.Add(this.cmitemstatus);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(492, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 354);
            this.panel5.TabIndex = 0;
            // 
            // cbitemstatus
            // 
            this.cbitemstatus.FormattingEnabled = true;
            this.cbitemstatus.Location = new System.Drawing.Point(107, 170);
            this.cbitemstatus.Name = "cbitemstatus";
            this.cbitemstatus.Size = new System.Drawing.Size(132, 21);
            this.cbitemstatus.TabIndex = 2;
            this.cbitemstatus.SelectedIndexChanged += new System.EventHandler(this.cbitemstatus_SelectedIndexChanged);
            // 
            // txbnameitem
            // 
            this.txbnameitem.Location = new System.Drawing.Point(107, 123);
            this.txbnameitem.Name = "txbnameitem";
            this.txbnameitem.Size = new System.Drawing.Size(132, 20);
            this.txbnameitem.TabIndex = 1;
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(107, 76);
            this.txbid.Name = "txbid";
            this.txbid.ReadOnly = true;
            this.txbid.Size = new System.Drawing.Size(132, 20);
            this.txbid.TabIndex = 1;
            // 
            // cmitemstatus
            // 
            this.cmitemstatus.AutoSize = true;
            this.cmitemstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmitemstatus.Location = new System.Drawing.Point(14, 174);
            this.cmitemstatus.Name = "cmitemstatus";
            this.cmitemstatus.Size = new System.Drawing.Size(87, 16);
            this.cmitemstatus.TabIndex = 0;
            this.cmitemstatus.Text = "Trạng thái trụ:";
            this.cmitemstatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên trụ sạc:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvtrusac);
            this.panel4.Location = new System.Drawing.Point(6, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 351);
            this.panel4.TabIndex = 0;
            // 
            // dtgvtrusac
            // 
            this.dtgvtrusac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtrusac.Location = new System.Drawing.Point(3, 3);
            this.dtgvtrusac.Name = "dtgvtrusac";
            this.dtgvtrusac.Size = new System.Drawing.Size(474, 345);
            this.dtgvtrusac.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnremove);
            this.panel3.Controls.Add(this.btnchange);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Controls.Add(this.btnview);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 53);
            this.panel3.TabIndex = 0;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(246, 14);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 31);
            this.btnremove.TabIndex = 0;
            this.btnremove.Text = "Xóa";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(165, 14);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 31);
            this.btnchange.TabIndex = 0;
            this.btnchange.Text = "Sửa";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(84, 14);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 31);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(3, 14);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 31);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "Xem";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbtypeacc);
            this.panel9.Controls.Add(this.txtpassword);
            this.panel9.Controls.Add(this.txtshowname);
            this.panel9.Controls.Add(this.txtnameacc);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(473, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(278, 362);
            this.panel9.TabIndex = 0;
            // 
            // cbtypeacc
            // 
            this.cbtypeacc.FormattingEnabled = true;
            this.cbtypeacc.Location = new System.Drawing.Point(121, 241);
            this.cbtypeacc.Name = "cbtypeacc";
            this.cbtypeacc.Size = new System.Drawing.Size(135, 21);
            this.cbtypeacc.TabIndex = 2;
            // 
            // txtshowname
            // 
            this.txtshowname.Location = new System.Drawing.Point(119, 150);
            this.txtshowname.Name = "txtshowname";
            this.txtshowname.Size = new System.Drawing.Size(137, 20);
            this.txtshowname.TabIndex = 1;
            // 
            // txtnameacc
            // 
            this.txtnameacc.Location = new System.Drawing.Point(119, 107);
            this.txtnameacc.Name = "txtnameacc";
            this.txtnameacc.Size = new System.Drawing.Size(137, 20);
            this.txtnameacc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên hiển thị:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên tài khoản:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgvlistacc);
            this.panel8.Location = new System.Drawing.Point(9, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(458, 362);
            this.panel8.TabIndex = 0;
            // 
            // dtgvlistacc
            // 
            this.dtgvlistacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistacc.Location = new System.Drawing.Point(3, 3);
            this.dtgvlistacc.Name = "dtgvlistacc";
            this.dtgvlistacc.Size = new System.Drawing.Size(455, 356);
            this.dtgvlistacc.TabIndex = 0;
            this.dtgvlistacc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnremoveacc);
            this.panel1.Controls.Add(this.btnchangeacc);
            this.panel1.Controls.Add(this.btnaddacc);
            this.panel1.Controls.Add(this.btnviewacc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnremoveacc
            // 
            this.btnremoveacc.Location = new System.Drawing.Point(285, 3);
            this.btnremoveacc.Name = "btnremoveacc";
            this.btnremoveacc.Size = new System.Drawing.Size(88, 33);
            this.btnremoveacc.TabIndex = 1;
            this.btnremoveacc.Text = "Xóa";
            this.btnremoveacc.UseVisualStyleBackColor = true;
            this.btnremoveacc.Click += new System.EventHandler(this.btnremoveacc_Click);
            // 
            // btnchangeacc
            // 
            this.btnchangeacc.Location = new System.Drawing.Point(191, 3);
            this.btnchangeacc.Name = "btnchangeacc";
            this.btnchangeacc.Size = new System.Drawing.Size(88, 33);
            this.btnchangeacc.TabIndex = 1;
            this.btnchangeacc.Text = "Sửa";
            this.btnchangeacc.UseVisualStyleBackColor = true;
            this.btnchangeacc.Click += new System.EventHandler(this.btnchangeacc_Click);
            // 
            // btnaddacc
            // 
            this.btnaddacc.Location = new System.Drawing.Point(97, 3);
            this.btnaddacc.Name = "btnaddacc";
            this.btnaddacc.Size = new System.Drawing.Size(88, 33);
            this.btnaddacc.TabIndex = 1;
            this.btnaddacc.Text = "Thêm";
            this.btnaddacc.UseVisualStyleBackColor = true;
            this.btnaddacc.Click += new System.EventHandler(this.btnaddacc_Click);
            // 
            // btnviewacc
            // 
            this.btnviewacc.Location = new System.Drawing.Point(3, 3);
            this.btnviewacc.Name = "btnviewacc";
            this.btnviewacc.Size = new System.Drawing.Size(88, 33);
            this.btnviewacc.TabIndex = 1;
            this.btnviewacc.Text = "Xem";
            this.btnviewacc.UseVisualStyleBackColor = true;
            this.btnviewacc.Click += new System.EventHandler(this.btnviewacc_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 351);
            this.panel2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(757, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh mục";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại trụ:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbtypestatus
            // 
            this.cbtypestatus.FormattingEnabled = true;
            this.cbtypestatus.Location = new System.Drawing.Point(107, 218);
            this.cbtypestatus.Name = "cbtypestatus";
            this.cbtypestatus.Size = new System.Drawing.Size(132, 21);
            this.cbtypestatus.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Công suất trụ:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbpower
            // 
            this.cbpower.FormattingEnabled = true;
            this.cbpower.Location = new System.Drawing.Point(107, 266);
            this.cbpower.Name = "cbpower";
            this.cbpower.Size = new System.Drawing.Size(132, 21);
            this.cbpower.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(42, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÔNG TIN TRỤ SẠC";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mật khẩu:";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(119, 193);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(137, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(53, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "THÔNG TIN TÀI KHOẢN";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản quản trị";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtrusac)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistacc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvtrusac;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmitemstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbitemstatus;
        private System.Windows.Forms.TextBox txbnameitem;
        private System.Windows.Forms.TextBox txbid;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgvlistacc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremoveacc;
        private System.Windows.Forms.Button btnchangeacc;
        private System.Windows.Forms.Button btnaddacc;
        private System.Windows.Forms.Button btnviewacc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtypeacc;
        private System.Windows.Forms.TextBox txtshowname;
        private System.Windows.Forms.TextBox txtnameacc;
        private System.Windows.Forms.TextBox txbdoanhthu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbpower;
        private System.Windows.Forms.ComboBox cbtypestatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}