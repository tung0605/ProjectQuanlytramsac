namespace ProjectQuanlytramsac
{
    partial class frmchangepass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchangepass));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamelogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtshowname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcurrentpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtacpnewpass = new System.Windows.Forms.TextBox();
            this.btnaccept = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnamelogin
            // 
            this.txtnamelogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtnamelogin.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamelogin.Location = new System.Drawing.Point(62, 104);
            this.txtnamelogin.Name = "txtnamelogin";
            this.txtnamelogin.ReadOnly = true;
            this.txtnamelogin.Size = new System.Drawing.Size(300, 28);
            this.txtnamelogin.TabIndex = 0;
            this.txtnamelogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtshowname
            // 
            this.txtshowname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtshowname.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowname.Location = new System.Drawing.Point(62, 167);
            this.txtshowname.Name = "txtshowname";
            this.txtshowname.Size = new System.Drawing.Size(300, 28);
            this.txtshowname.TabIndex = 1;
            this.txtshowname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcurrentpass
            // 
            this.txtcurrentpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtcurrentpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentpass.Location = new System.Drawing.Point(62, 230);
            this.txtcurrentpass.Name = "txtcurrentpass";
            this.txtcurrentpass.Size = new System.Drawing.Size(300, 28);
            this.txtcurrentpass.TabIndex = 2;
            this.txtcurrentpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtnewpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(62, 293);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(300, 28);
            this.txtnewpass.TabIndex = 3;
            this.txtnewpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xác nhận mật khẩu:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtacpnewpass
            // 
            this.txtacpnewpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtacpnewpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacpnewpass.Location = new System.Drawing.Point(62, 356);
            this.txtacpnewpass.Name = "txtacpnewpass";
            this.txtacpnewpass.Size = new System.Drawing.Size(300, 28);
            this.txtacpnewpass.TabIndex = 4;
            this.txtacpnewpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnaccept
            // 
            this.btnaccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaccept.BackgroundImage")));
            this.btnaccept.Font = new System.Drawing.Font("Google Sans Flex", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccept.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnaccept.Location = new System.Drawing.Point(260, 409);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(137, 46);
            this.btnaccept.TabIndex = 5;
            this.btnaccept.Text = "Xác nhận";
            this.btnaccept.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Google Sans Flex", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN CÁ NHÂN";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmchangepass
            // 
            this.AcceptButton = this.btnaccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 473);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.txtacpnewpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcurrentpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtshowname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnamelogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmchangepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamelogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtshowname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcurrentpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtacpnewpass;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.Label label6;
    }
}