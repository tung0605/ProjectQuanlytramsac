namespace ProjectQuanlytramsac
{
    partial class frmmanagement
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.chargetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbtotalmoney = new System.Windows.Forms.TextBox();
            this.numdiscount = new System.Windows.Forms.NumericUpDown();
            this.btndiscount = new System.Windows.Forms.Button();
            this.btnrepair = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.flpitem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbguesttype = new System.Windows.Forms.ComboBox();
            this.cbchargetype = new System.Windows.Forms.ComboBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.timerSac = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pToolStripMenuItem.Text = "Admin";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đToolStripMenuItem
            // 
            this.đToolStripMenuItem.Name = "đToolStripMenuItem";
            this.đToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đToolStripMenuItem.Text = "Thông tin cá nhân";
            this.đToolStripMenuItem.Click += new System.EventHandler(this.đToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvbill);
            this.panel2.Location = new System.Drawing.Point(595, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 459);
            this.panel2.TabIndex = 2;
            // 
            // lsvbill
            // 
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chargetime,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvbill.GridLines = true;
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(3, 3);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(350, 453);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            this.lsvbill.SelectedIndexChanged += new System.EventHandler(this.lsvbill_SelectedIndexChanged);
            // 
            // chargetime
            // 
            this.chargetime.Text = "Thời gian đã sạc";
            this.chargetime.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số điện (kWh)";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Công Suất";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 101;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbtotalmoney);
            this.panel3.Controls.Add(this.numdiscount);
            this.panel3.Controls.Add(this.btndiscount);
            this.panel3.Controls.Add(this.btnrepair);
            this.panel3.Controls.Add(this.btnpay);
            this.panel3.Location = new System.Drawing.Point(954, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 545);
            this.panel3.TabIndex = 3;
            // 
            // txbtotalmoney
            // 
            this.txbtotalmoney.Location = new System.Drawing.Point(3, 522);
            this.txbtotalmoney.Name = "txbtotalmoney";
            this.txbtotalmoney.Size = new System.Drawing.Size(119, 20);
            this.txbtotalmoney.TabIndex = 1;
            // 
            // numdiscount
            // 
            this.numdiscount.Location = new System.Drawing.Point(3, 427);
            this.numdiscount.Name = "numdiscount";
            this.numdiscount.Size = new System.Drawing.Size(119, 20);
            this.numdiscount.TabIndex = 0;
            this.numdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numdiscount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numdiscount.ValueChanged += new System.EventHandler(this.numdiscount_ValueChanged);
            // 
            // btndiscount
            // 
            this.btndiscount.Location = new System.Drawing.Point(3, 389);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(119, 32);
            this.btndiscount.TabIndex = 0;
            this.btndiscount.Text = "Giảm giá";
            this.btndiscount.UseVisualStyleBackColor = true;
            this.btndiscount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrepair
            // 
            this.btnrepair.Location = new System.Drawing.Point(3, 320);
            this.btnrepair.Name = "btnrepair";
            this.btnrepair.Size = new System.Drawing.Size(119, 63);
            this.btnrepair.TabIndex = 0;
            this.btnrepair.Text = "Báo hỏng/bảo trì";
            this.btnrepair.UseVisualStyleBackColor = true;
            this.btnrepair.Click += new System.EventHandler(this.btnrepair_Click);
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(3, 453);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(119, 63);
            this.btnpay.TabIndex = 0;
            this.btnpay.Text = "Thanh toán";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // flpitem
            // 
            this.flpitem.Location = new System.Drawing.Point(12, 27);
            this.flpitem.Name = "flpitem";
            this.flpitem.Size = new System.Drawing.Size(577, 545);
            this.flpitem.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbguesttype);
            this.panel1.Controls.Add(this.cbchargetype);
            this.panel1.Controls.Add(this.btnstart);
            this.panel1.Location = new System.Drawing.Point(595, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 80);
            this.panel1.TabIndex = 3;
            // 
            // cbguesttype
            // 
            this.cbguesttype.FormattingEnabled = true;
            this.cbguesttype.Location = new System.Drawing.Point(3, 46);
            this.cbguesttype.Name = "cbguesttype";
            this.cbguesttype.Size = new System.Drawing.Size(194, 21);
            this.cbguesttype.TabIndex = 2;
            this.cbguesttype.Text = "Loại khách hàng";
            // 
            // cbchargetype
            // 
            this.cbchargetype.FormattingEnabled = true;
            this.cbchargetype.Location = new System.Drawing.Point(3, 12);
            this.cbchargetype.Name = "cbchargetype";
            this.cbchargetype.Size = new System.Drawing.Size(194, 21);
            this.cbchargetype.TabIndex = 1;
            this.cbchargetype.Text = "Loại sạc/Chế độ sạc";
            this.cbchargetype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnstart
            // 
            this.btnstart.AutoSize = true;
            this.btnstart.Location = new System.Drawing.Point(203, 3);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(147, 74);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Bắt đầu phiên sạc";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timerSac
            // 
            this.timerSac.Interval = 1000;
            this.timerSac.Tick += new System.EventHandler(this.timersac_Tick);
            // 
            // frmmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 584);
            this.Controls.Add(this.flpitem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý trạm sạc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.FlowLayoutPanel flpitem;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.NumericUpDown numdiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbguesttype;
        private System.Windows.Forms.ComboBox cbchargetype;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnrepair;
        private System.Windows.Forms.ColumnHeader chargetime;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbtotalmoney;
        private System.Windows.Forms.Timer timerSac;
    }
}