namespace EFTApp
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_admin = new FontAwesome.Sharp.IconButton();
            this.btn_loadout = new FontAwesome.Sharp.IconButton();
            this.btn_ammunition = new FontAwesome.Sharp.IconButton();
            this.btn_gear = new FontAwesome.Sharp.IconButton();
            this.btn_weapons = new FontAwesome.Sharp.IconButton();
            this.btn_login = new FontAwesome.Sharp.IconButton();
            this.panel_home = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.lbl_titleCurrentForm = new System.Windows.Forms.Label();
            this.icon_currentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panel_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentForm)).BeginInit();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_menu.Controls.Add(this.btn_logout);
            this.panel_menu.Controls.Add(this.btn_admin);
            this.panel_menu.Controls.Add(this.btn_loadout);
            this.panel_menu.Controls.Add(this.btn_ammunition);
            this.panel_menu.Controls.Add(this.btn_gear);
            this.panel_menu.Controls.Add(this.btn_weapons);
            this.panel_menu.Controls.Add(this.btn_login);
            this.panel_menu.Controls.Add(this.panel_home);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(220, 720);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.White;
            this.btn_logout.IconSize = 32;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 608);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_logout.Rotation = 0D;
            this.btn_logout.Size = new System.Drawing.Size(220, 78);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_admin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btn_admin.IconColor = System.Drawing.Color.White;
            this.btn_admin.IconSize = 32;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.Location = new System.Drawing.Point(0, 530);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_admin.Rotation = 0D;
            this.btn_admin.Size = new System.Drawing.Size(220, 78);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Visible = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_loadout
            // 
            this.btn_loadout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_loadout.FlatAppearance.BorderSize = 0;
            this.btn_loadout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_loadout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_loadout.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.btn_loadout.IconColor = System.Drawing.Color.White;
            this.btn_loadout.IconSize = 32;
            this.btn_loadout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loadout.Location = new System.Drawing.Point(0, 452);
            this.btn_loadout.Name = "btn_loadout";
            this.btn_loadout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_loadout.Rotation = 0D;
            this.btn_loadout.Size = new System.Drawing.Size(220, 78);
            this.btn_loadout.TabIndex = 4;
            this.btn_loadout.Text = "Loadout";
            this.btn_loadout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loadout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_loadout.UseVisualStyleBackColor = true;
            this.btn_loadout.Visible = false;
            this.btn_loadout.Click += new System.EventHandler(this.btn_loadout_Click);
            // 
            // btn_ammunition
            // 
            this.btn_ammunition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ammunition.FlatAppearance.BorderSize = 0;
            this.btn_ammunition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ammunition.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ammunition.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ammunition.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ammunition.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btn_ammunition.IconColor = System.Drawing.Color.White;
            this.btn_ammunition.IconSize = 32;
            this.btn_ammunition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ammunition.Location = new System.Drawing.Point(0, 374);
            this.btn_ammunition.Name = "btn_ammunition";
            this.btn_ammunition.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_ammunition.Rotation = 0D;
            this.btn_ammunition.Size = new System.Drawing.Size(220, 78);
            this.btn_ammunition.TabIndex = 2;
            this.btn_ammunition.Text = "Ammunition";
            this.btn_ammunition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ammunition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ammunition.UseVisualStyleBackColor = true;
            this.btn_ammunition.Visible = false;
            this.btn_ammunition.Click += new System.EventHandler(this.btn_ammunition_Click);
            // 
            // btn_gear
            // 
            this.btn_gear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_gear.FlatAppearance.BorderSize = 0;
            this.btn_gear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_gear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gear.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_gear.IconChar = FontAwesome.Sharp.IconChar.Hiking;
            this.btn_gear.IconColor = System.Drawing.Color.White;
            this.btn_gear.IconSize = 32;
            this.btn_gear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gear.Location = new System.Drawing.Point(0, 296);
            this.btn_gear.Name = "btn_gear";
            this.btn_gear.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_gear.Rotation = 0D;
            this.btn_gear.Size = new System.Drawing.Size(220, 78);
            this.btn_gear.TabIndex = 3;
            this.btn_gear.Text = "Gear";
            this.btn_gear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gear.UseVisualStyleBackColor = true;
            this.btn_gear.Visible = false;
            this.btn_gear.Click += new System.EventHandler(this.btn_gear_Click);
            // 
            // btn_weapons
            // 
            this.btn_weapons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_weapons.FlatAppearance.BorderSize = 0;
            this.btn_weapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_weapons.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_weapons.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weapons.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_weapons.IconChar = FontAwesome.Sharp.IconChar.FistRaised;
            this.btn_weapons.IconColor = System.Drawing.Color.White;
            this.btn_weapons.IconSize = 32;
            this.btn_weapons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_weapons.Location = new System.Drawing.Point(0, 218);
            this.btn_weapons.Name = "btn_weapons";
            this.btn_weapons.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_weapons.Rotation = 0D;
            this.btn_weapons.Size = new System.Drawing.Size(220, 78);
            this.btn_weapons.TabIndex = 1;
            this.btn_weapons.Text = "Weapons";
            this.btn_weapons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_weapons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_weapons.UseVisualStyleBackColor = true;
            this.btn_weapons.Visible = false;
            this.btn_weapons.Click += new System.EventHandler(this.btn_weapons_Click);
            // 
            // btn_login
            // 
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_login.IconColor = System.Drawing.Color.White;
            this.btn_login.IconSize = 32;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(0, 140);
            this.btn_login.Name = "btn_login";
            this.btn_login.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_login.Rotation = 0D;
            this.btn_login.Size = new System.Drawing.Size(220, 78);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login/Register";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.btn_home);
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(220, 140);
            this.panel_home.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(193, 110);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panel_titleBar.Controls.Add(this.btn_close);
            this.panel_titleBar.Controls.Add(this.lbl_titleCurrentForm);
            this.panel_titleBar.Controls.Add(this.icon_currentForm);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(1280, 32);
            this.panel_titleBar.TabIndex = 0;
            this.panel_titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_close.IconColor = System.Drawing.Color.DarkRed;
            this.btn_close.IconSize = 32;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1219, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(61, 32);
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_titleCurrentForm
            // 
            this.lbl_titleCurrentForm.AutoSize = true;
            this.lbl_titleCurrentForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleCurrentForm.ForeColor = System.Drawing.Color.White;
            this.lbl_titleCurrentForm.Location = new System.Drawing.Point(41, 9);
            this.lbl_titleCurrentForm.Name = "lbl_titleCurrentForm";
            this.lbl_titleCurrentForm.Size = new System.Drawing.Size(40, 16);
            this.lbl_titleCurrentForm.TabIndex = 1;
            this.lbl_titleCurrentForm.Text = "Home";
            // 
            // icon_currentForm
            // 
            this.icon_currentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.icon_currentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.icon_currentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon_currentForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.icon_currentForm.Location = new System.Drawing.Point(3, 3);
            this.icon_currentForm.Name = "icon_currentForm";
            this.icon_currentForm.Size = new System.Drawing.Size(32, 32);
            this.icon_currentForm.TabIndex = 0;
            this.icon_currentForm.TabStop = false;
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.panel_desktop);
            this.panel_content.Controls.Add(this.panel_menu);
            this.panel_content.Location = new System.Drawing.Point(0, 30);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1280, 720);
            this.panel_content.TabIndex = 3;
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_desktop.Location = new System.Drawing.Point(220, 0);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1060, 690);
            this.panel_desktop.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_titleBar);
            this.Controls.Add(this.panel_content);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = " ";
            this.panel_menu.ResumeLayout(false);
            this.panel_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentForm)).EndInit();
            this.panel_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private FontAwesome.Sharp.IconButton btn_loadout;
        private FontAwesome.Sharp.IconButton btn_gear;
        private FontAwesome.Sharp.IconButton btn_weapons;
        private System.Windows.Forms.Panel panel_home;
        private FontAwesome.Sharp.IconButton btn_login;
        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Panel panel_titleBar;
        private FontAwesome.Sharp.IconPictureBox icon_currentForm;
        private System.Windows.Forms.Label lbl_titleCurrentForm;
        private System.Windows.Forms.Panel panel_content;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Panel panel_desktop;
        private FontAwesome.Sharp.IconButton btn_admin;
        private FontAwesome.Sharp.IconButton btn_ammunition;
        private FontAwesome.Sharp.IconButton btn_logout;
    }
}

