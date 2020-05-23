namespace EFTApp.Forms
{
    partial class FormProfile
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
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_passwordRepeat = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_emailData = new System.Windows.Forms.Label();
            this.lbl_usernameData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_resetPassword = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel_error = new System.Windows.Forms.Panel();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_error.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_login.Controls.Add(this.lbl_email);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.panel3);
            this.panel_login.Controls.Add(this.panel4);
            this.panel_login.Controls.Add(this.txt_passwordRepeat);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.lbl_emailData);
            this.panel_login.Controls.Add(this.lbl_usernameData);
            this.panel_login.Controls.Add(this.panel2);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Controls.Add(this.btn_resetPassword);
            this.panel_login.Location = new System.Drawing.Point(348, 139);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(350, 352);
            this.panel_login.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(23, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 1);
            this.panel4.TabIndex = 13;
            // 
            // txt_passwordRepeat
            // 
            this.txt_passwordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_passwordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwordRepeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordRepeat.ForeColor = System.Drawing.Color.White;
            this.txt_passwordRepeat.Location = new System.Drawing.Point(23, 264);
            this.txt_passwordRepeat.Name = "txt_passwordRepeat";
            this.txt_passwordRepeat.Size = new System.Drawing.Size(263, 21);
            this.txt_passwordRepeat.TabIndex = 3;
            this.txt_passwordRepeat.Text = "Repeat Password";
            this.txt_passwordRepeat.Click += new System.EventHandler(this.txt_passwordRepeat_Click);
            this.txt_passwordRepeat.Enter += new System.EventHandler(this.txt_passwordRepeat_Enter);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(23, 207);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(263, 21);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // lbl_emailData
            // 
            this.lbl_emailData.AutoSize = true;
            this.lbl_emailData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailData.ForeColor = System.Drawing.Color.White;
            this.lbl_emailData.Location = new System.Drawing.Point(69, 96);
            this.lbl_emailData.Name = "lbl_emailData";
            this.lbl_emailData.Size = new System.Drawing.Size(51, 21);
            this.lbl_emailData.TabIndex = 1;
            this.lbl_emailData.Text = "Email";
            // 
            // lbl_usernameData
            // 
            this.lbl_usernameData.AutoSize = true;
            this.lbl_usernameData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameData.ForeColor = System.Drawing.Color.White;
            this.lbl_usernameData.Location = new System.Drawing.Point(105, 39);
            this.lbl_usernameData.Name = "lbl_usernameData";
            this.lbl_usernameData.Size = new System.Drawing.Size(87, 21);
            this.lbl_usernameData.TabIndex = 0;
            this.lbl_usernameData.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(24, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 3;
            // 
            // btn_resetPassword
            // 
            this.btn_resetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btn_resetPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_resetPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_resetPassword.FlatAppearance.BorderSize = 0;
            this.btn_resetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetPassword.ForeColor = System.Drawing.Color.White;
            this.btn_resetPassword.Location = new System.Drawing.Point(0, 301);
            this.btn_resetPassword.Name = "btn_resetPassword";
            this.btn_resetPassword.Size = new System.Drawing.Size(350, 51);
            this.btn_resetPassword.TabIndex = 4;
            this.btn_resetPassword.Text = "Reset Password";
            this.btn_resetPassword.UseVisualStyleBackColor = false;
            this.btn_resetPassword.Click += new System.EventHandler(this.btn_resetPassword_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(348, 567);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(350, 51);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(19, 39);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(91, 21);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(19, 96);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 21);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email:";
            // 
            // panel_error
            // 
            this.panel_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            this.panel_error.Controls.Add(this.lbl_errorMessage);
            this.panel_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_error.Location = new System.Drawing.Point(0, 0);
            this.panel_error.Name = "panel_error";
            this.panel_error.Size = new System.Drawing.Size(1060, 57);
            this.panel_error.TabIndex = 2;
            this.panel_error.Visible = false;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_errorMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.White;
            this.lbl_errorMessage.Location = new System.Drawing.Point(0, 0);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(1060, 57);
            this.lbl_errorMessage.TabIndex = 0;
            this.lbl_errorMessage.Text = "Error Message";
            this.lbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProfile
            // 
            this.AcceptButton = this.btn_resetPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.panel_error);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "User";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_error.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_resetPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_emailData;
        private System.Windows.Forms.Label lbl_usernameData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_passwordRepeat;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_error;
        private System.Windows.Forms.Label lbl_errorMessage;
    }
}