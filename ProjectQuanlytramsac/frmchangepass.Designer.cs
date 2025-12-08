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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnamelogin
            // 
            this.txtnamelogin.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamelogin.Location = new System.Drawing.Point(213, 30);
            this.txtnamelogin.Name = "txtnamelogin";
            this.txtnamelogin.ReadOnly = true;
            this.txtnamelogin.Size = new System.Drawing.Size(217, 28);
            this.txtnamelogin.TabIndex = 0;
            this.txtnamelogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtshowname
            // 
            this.txtshowname.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowname.Location = new System.Drawing.Point(213, 80);
            this.txtshowname.Name = "txtshowname";
            this.txtshowname.Size = new System.Drawing.Size(217, 28);
            this.txtshowname.TabIndex = 1;
            this.txtshowname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcurrentpass
            // 
            this.txtcurrentpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentpass.Location = new System.Drawing.Point(213, 130);
            this.txtcurrentpass.Name = "txtcurrentpass";
            this.txtcurrentpass.Size = new System.Drawing.Size(217, 28);
            this.txtcurrentpass.TabIndex = 2;
            this.txtcurrentpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(213, 180);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(217, 28);
            this.txtnewpass.TabIndex = 3;
            this.txtnewpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xác nhận mật khẩu:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtacpnewpass
            // 
            this.txtacpnewpass.Font = new System.Drawing.Font("Google Sans Flex Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacpnewpass.Location = new System.Drawing.Point(213, 230);
            this.txtacpnewpass.Name = "txtacpnewpass";
            this.txtacpnewpass.Size = new System.Drawing.Size(217, 28);
            this.txtacpnewpass.TabIndex = 4;
            this.txtacpnewpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(327, 279);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(120, 40);
            this.btnaccept.TabIndex = 5;
            this.btnaccept.Text = "Xác nhận";
            this.btnaccept.UseVisualStyleBackColor = true;
            // 
            // frmchangepass
            // 
            this.AcceptButton = this.btnaccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 354);
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
            this.Controls.Add(this.label1);
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
    }
}