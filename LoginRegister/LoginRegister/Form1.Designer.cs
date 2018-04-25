namespace LoginRegister
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Location = new System.Drawing.Point(69, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 832);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 55);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifrənin təkrarı";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(37, 618);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(548, 62);
            this.txtConfirmPassword.TabIndex = 12;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifrə";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(37, 418);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(548, 62);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "İstifadəçi adı";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(37, 217);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(548, 62);
            this.txtUserName.TabIndex = 8;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(27, 27);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(406, 55);
            this.lblRegistration.TabIndex = 7;
            this.lblRegistration.Text = "Qeydiyyatdan keç";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(37, 718);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(548, 80);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Qeydiyyatdan keç";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPasswordLogin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUserNameLogin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1961, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 832);
            this.panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(37, 718);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(548, 80);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Daxil ol";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifrə";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(37, 618);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(548, 62);
            this.txtPasswordLogin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 55);
            this.label6.TabIndex = 9;
            this.label6.Text = "İstifadəçi adı";
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.Location = new System.Drawing.Point(37, 418);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(548, 62);
            this.txtUserNameLogin.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 55);
            this.label7.TabIndex = 7;
            this.label7.Text = "Daxil ol";
            // 
            // dgwUser
            // 
            this.dgwUser.AllowUserToAddRows = false;
            this.dgwUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwUser.Location = new System.Drawing.Point(874, 89);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.RowTemplate.Height = 46;
            this.dgwUser.Size = new System.Drawing.Size(1003, 832);
            this.dgwUser.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Istifadeci adi";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sifre";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2649, 1039);
            this.Controls.Add(this.dgwUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

