namespace ProjectQuanlytramsac
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblshow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnamelogin = new System.Windows.Forms.Label();
            this.txtnamelogin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 61);
            this.panel4.TabIndex = 2;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.BackColor = System.Drawing.Color.Transparent;
            this.lblshow.Font = new System.Drawing.Font("Google Sans Flex", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.Location = new System.Drawing.Point(135, 9);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(156, 60);
            this.lblshow.TabIndex = 3;
            this.lblshow.Text = "Sign Up";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblnamelogin);
            this.panel2.Controls.Add(this.txtnamelogin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 75);
            this.panel2.TabIndex = 0;
            // 
            // lblnamelogin
            // 
            this.lblnamelogin.AutoSize = true;
            this.lblnamelogin.BackColor = System.Drawing.Color.Transparent;
            this.lblnamelogin.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamelogin.Location = new System.Drawing.Point(53, 6);
            this.lblnamelogin.Name = "lblnamelogin";
            this.lblnamelogin.Size = new System.Drawing.Size(68, 22);
            this.lblnamelogin.TabIndex = 0;
            this.lblnamelogin.Text = "Username";
            // 
            // txtnamelogin
            // 
            this.txtnamelogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnamelogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtnamelogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamelogin.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamelogin.Location = new System.Drawing.Point(53, 32);
            this.txtnamelogin.MaxLength = 30000;
            this.txtnamelogin.Multiline = true;
            this.txtnamelogin.Name = "txtnamelogin";
            this.txtnamelogin.Size = new System.Drawing.Size(300, 30);
            this.txtnamelogin.TabIndex = 0;
            this.txtnamelogin.Tag = "Username";
            this.txtnamelogin.TextChanged += new System.EventHandler(this.txtnamelogin_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblpassword);
            this.panel3.Controls.Add(this.txtpassword);
            this.panel3.Location = new System.Drawing.Point(3, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 72);
            this.panel3.TabIndex = 1;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(53, -1);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 22);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Google Sans Flex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(53, 25);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(300, 30);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Tag = "Username";
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Font = new System.Drawing.Font("Google Sans Flex", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(76, 162);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(262, 48);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Sign Up";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 222);
            this.panel1.TabIndex = 0;
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 310);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblnamelogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtnamelogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panel1;
    }
}

