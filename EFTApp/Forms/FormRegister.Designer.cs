namespace EFTApp.Forms
{
    partial class FormRegister
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
            this.panel_error = new System.Windows.Forms.Panel();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_email = new FontAwesome.Sharp.IconPictureBox();
            this.icon_passwordRepeat = new FontAwesome.Sharp.IconPictureBox();
            this.icon_password = new FontAwesome.Sharp.IconPictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.icon_username = new FontAwesome.Sharp.IconPictureBox();
            this.txt_passwordRepeat = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_error.SuspendLayout();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_passwordRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_error
            // 
            this.panel_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            this.panel_error.Controls.Add(this.lbl_errorMessage);
            this.panel_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_error.Location = new System.Drawing.Point(0, 0);
            this.panel_error.Name = "panel_error";
            this.panel_error.Size = new System.Drawing.Size(1060, 57);
            this.panel_error.TabIndex = 3;
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
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_login.Controls.Add(this.panel4);
            this.panel_login.Controls.Add(this.btn_register);
            this.panel_login.Controls.Add(this.panel2);
            this.panel_login.Controls.Add(this.panel3);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Controls.Add(this.icon_email);
            this.panel_login.Controls.Add(this.icon_passwordRepeat);
            this.panel_login.Controls.Add(this.icon_password);
            this.panel_login.Controls.Add(this.txt_email);
            this.panel_login.Controls.Add(this.icon_username);
            this.panel_login.Controls.Add(this.txt_passwordRepeat);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.Location = new System.Drawing.Point(356, 152);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(350, 334);
            this.panel_login.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(25, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 1);
            this.panel4.TabIndex = 3;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(0, 283);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(350, 51);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(25, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(25, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 1);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 1);
            this.panel1.TabIndex = 3;
            // 
            // icon_email
            // 
            this.icon_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.icon_email.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.icon_email.IconColor = System.Drawing.Color.White;
            this.icon_email.Location = new System.Drawing.Point(25, 205);
            this.icon_email.Name = "icon_email";
            this.icon_email.Size = new System.Drawing.Size(32, 32);
            this.icon_email.TabIndex = 2;
            this.icon_email.TabStop = false;
            // 
            // icon_passwordRepeat
            // 
            this.icon_passwordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.icon_passwordRepeat.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.icon_passwordRepeat.IconColor = System.Drawing.Color.White;
            this.icon_passwordRepeat.Location = new System.Drawing.Point(25, 148);
            this.icon_passwordRepeat.Name = "icon_passwordRepeat";
            this.icon_passwordRepeat.Size = new System.Drawing.Size(32, 32);
            this.icon_passwordRepeat.TabIndex = 2;
            this.icon_passwordRepeat.TabStop = false;
            // 
            // icon_password
            // 
            this.icon_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.icon_password.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.icon_password.IconColor = System.Drawing.Color.White;
            this.icon_password.Location = new System.Drawing.Point(25, 90);
            this.icon_password.Name = "icon_password";
            this.icon_password.Size = new System.Drawing.Size(32, 32);
            this.icon_password.TabIndex = 2;
            this.icon_password.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(63, 214);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(263, 20);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "Email";
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            // 
            // icon_username
            // 
            this.icon_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.icon_username.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icon_username.IconColor = System.Drawing.Color.White;
            this.icon_username.Location = new System.Drawing.Point(25, 33);
            this.icon_username.Name = "icon_username";
            this.icon_username.Size = new System.Drawing.Size(32, 32);
            this.icon_username.TabIndex = 2;
            this.icon_username.TabStop = false;
            // 
            // txt_passwordRepeat
            // 
            this.txt_passwordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_passwordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwordRepeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordRepeat.ForeColor = System.Drawing.Color.White;
            this.txt_passwordRepeat.Location = new System.Drawing.Point(63, 157);
            this.txt_passwordRepeat.Name = "txt_passwordRepeat";
            this.txt_passwordRepeat.Size = new System.Drawing.Size(263, 20);
            this.txt_passwordRepeat.TabIndex = 2;
            this.txt_passwordRepeat.Text = "Password Repeat";
            this.txt_passwordRepeat.Click += new System.EventHandler(this.txt_passwordRepeat_Click);
            this.txt_passwordRepeat.Enter += new System.EventHandler(this.txt_passwordRepeat_Enter);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(63, 99);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(263, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "Password";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(63, 42);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(263, 20);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(356, 511);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(350, 51);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(518, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "OR";
            // 
            // FormRegister
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel_error);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "Register";
            this.panel_error.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_passwordRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_error;
        private System.Windows.Forms.Label lbl_errorMessage;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox icon_email;
        private FontAwesome.Sharp.IconPictureBox icon_passwordRepeat;
        private FontAwesome.Sharp.IconPictureBox icon_password;
        private System.Windows.Forms.TextBox txt_email;
        private FontAwesome.Sharp.IconPictureBox icon_username;
        private System.Windows.Forms.TextBox txt_passwordRepeat;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
    }
}