namespace EFTApp.Forms
{
    partial class FormLoadout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.cbox_primaryWeapon = new System.Windows.Forms.ComboBox();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbox_bodyArmour = new System.Windows.Forms.ComboBox();
            this.gearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_backpack = new System.Windows.Forms.Label();
            this.lbl_rig = new System.Windows.Forms.Label();
            this.lbl_holsterWeapon = new System.Windows.Forms.Label();
            this.cbox_backpack = new System.Windows.Forms.ComboBox();
            this.cbox_rig = new System.Windows.Forms.ComboBox();
            this.cbox_holsterWeapon = new System.Windows.Forms.ComboBox();
            this.lbl_secondaryWeapon = new System.Windows.Forms.Label();
            this.cbox_secondaryWeapon = new System.Windows.Forms.ComboBox();
            this.cbox_headwear = new System.Windows.Forms.ComboBox();
            this.cbox_earpiece = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_earpiece = new System.Windows.Forms.Label();
            this.lbl_headwear = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_bodyArmour = new System.Windows.Forms.Label();
            this.lbl_primaryWeapon = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgv_loadouts = new System.Windows.Forms.DataGridView();
            this.col_loadoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_earpieceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earpiece = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_headwearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Headwear = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_bodyArmourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyArmour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_primaryWeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryWeapon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_secondaryWeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryWeapon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_holsterWeaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolsterWeapon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_rigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rig = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_backpackID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backpack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.loadoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_edit);
            this.panel1.Controls.Add(this.dgv_loadouts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 600);
            this.panel1.TabIndex = 9;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_edit.Controls.Add(this.cbox_primaryWeapon);
            this.panel_edit.Controls.Add(this.cbox_bodyArmour);
            this.panel_edit.Controls.Add(this.lbl_backpack);
            this.panel_edit.Controls.Add(this.lbl_rig);
            this.panel_edit.Controls.Add(this.lbl_holsterWeapon);
            this.panel_edit.Controls.Add(this.cbox_backpack);
            this.panel_edit.Controls.Add(this.cbox_rig);
            this.panel_edit.Controls.Add(this.cbox_holsterWeapon);
            this.panel_edit.Controls.Add(this.lbl_secondaryWeapon);
            this.panel_edit.Controls.Add(this.cbox_secondaryWeapon);
            this.panel_edit.Controls.Add(this.cbox_headwear);
            this.panel_edit.Controls.Add(this.cbox_earpiece);
            this.panel_edit.Controls.Add(this.label12);
            this.panel_edit.Controls.Add(this.lbl_name);
            this.panel_edit.Controls.Add(this.lbl_earpiece);
            this.panel_edit.Controls.Add(this.lbl_headwear);
            this.panel_edit.Controls.Add(this.txt_name);
            this.panel_edit.Controls.Add(this.lbl_bodyArmour);
            this.panel_edit.Controls.Add(this.lbl_primaryWeapon);
            this.panel_edit.Controls.Add(this.panel9);
            this.panel_edit.Location = new System.Drawing.Point(807, 12);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(241, 575);
            this.panel_edit.TabIndex = 0;
            // 
            // cbox_primaryWeapon
            // 
            this.cbox_primaryWeapon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_primaryWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_primaryWeapon.DataSource = this.weaponBindingSource;
            this.cbox_primaryWeapon.DisplayMember = "Name";
            this.cbox_primaryWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_primaryWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_primaryWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_primaryWeapon.ForeColor = System.Drawing.Color.White;
            this.cbox_primaryWeapon.FormattingEnabled = true;
            this.cbox_primaryWeapon.Location = new System.Drawing.Point(0, 242);
            this.cbox_primaryWeapon.Name = "cbox_primaryWeapon";
            this.cbox_primaryWeapon.Size = new System.Drawing.Size(230, 27);
            this.cbox_primaryWeapon.TabIndex = 4;
            this.cbox_primaryWeapon.ValueMember = "WeaponID";
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(EFTApp.Weapon);
            // 
            // cbox_bodyArmour
            // 
            this.cbox_bodyArmour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_bodyArmour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_bodyArmour.DataSource = this.gearBindingSource;
            this.cbox_bodyArmour.DisplayMember = "Name";
            this.cbox_bodyArmour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_bodyArmour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_bodyArmour.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_bodyArmour.ForeColor = System.Drawing.Color.White;
            this.cbox_bodyArmour.FormattingEnabled = true;
            this.cbox_bodyArmour.Location = new System.Drawing.Point(0, 191);
            this.cbox_bodyArmour.Name = "cbox_bodyArmour";
            this.cbox_bodyArmour.Size = new System.Drawing.Size(230, 27);
            this.cbox_bodyArmour.TabIndex = 3;
            this.cbox_bodyArmour.ValueMember = "GearID";
            // 
            // gearBindingSource
            // 
            this.gearBindingSource.DataSource = typeof(EFTApp.Gear);
            // 
            // lbl_backpack
            // 
            this.lbl_backpack.AutoSize = true;
            this.lbl_backpack.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backpack.ForeColor = System.Drawing.Color.White;
            this.lbl_backpack.Location = new System.Drawing.Point(-3, 426);
            this.lbl_backpack.Name = "lbl_backpack";
            this.lbl_backpack.Size = new System.Drawing.Size(67, 19);
            this.lbl_backpack.TabIndex = 14;
            this.lbl_backpack.Text = "Backpack";
            // 
            // lbl_rig
            // 
            this.lbl_rig.AutoSize = true;
            this.lbl_rig.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rig.ForeColor = System.Drawing.Color.White;
            this.lbl_rig.Location = new System.Drawing.Point(-3, 374);
            this.lbl_rig.Name = "lbl_rig";
            this.lbl_rig.Size = new System.Drawing.Size(28, 19);
            this.lbl_rig.TabIndex = 14;
            this.lbl_rig.Text = "Rig";
            // 
            // lbl_holsterWeapon
            // 
            this.lbl_holsterWeapon.AutoSize = true;
            this.lbl_holsterWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_holsterWeapon.ForeColor = System.Drawing.Color.White;
            this.lbl_holsterWeapon.Location = new System.Drawing.Point(-3, 322);
            this.lbl_holsterWeapon.Name = "lbl_holsterWeapon";
            this.lbl_holsterWeapon.Size = new System.Drawing.Size(108, 19);
            this.lbl_holsterWeapon.TabIndex = 14;
            this.lbl_holsterWeapon.Text = "Holster Weapon";
            // 
            // cbox_backpack
            // 
            this.cbox_backpack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_backpack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_backpack.DataSource = this.gearBindingSource;
            this.cbox_backpack.DisplayMember = "Name";
            this.cbox_backpack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_backpack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_backpack.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_backpack.ForeColor = System.Drawing.Color.White;
            this.cbox_backpack.FormattingEnabled = true;
            this.cbox_backpack.Location = new System.Drawing.Point(0, 448);
            this.cbox_backpack.Name = "cbox_backpack";
            this.cbox_backpack.Size = new System.Drawing.Size(231, 27);
            this.cbox_backpack.TabIndex = 8;
            this.cbox_backpack.ValueMember = "GearID";
            // 
            // cbox_rig
            // 
            this.cbox_rig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_rig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_rig.DataSource = this.gearBindingSource;
            this.cbox_rig.DisplayMember = "Name";
            this.cbox_rig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_rig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_rig.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_rig.ForeColor = System.Drawing.Color.White;
            this.cbox_rig.FormattingEnabled = true;
            this.cbox_rig.Location = new System.Drawing.Point(0, 396);
            this.cbox_rig.Name = "cbox_rig";
            this.cbox_rig.Size = new System.Drawing.Size(231, 27);
            this.cbox_rig.TabIndex = 7;
            this.cbox_rig.ValueMember = "GearID";
            // 
            // cbox_holsterWeapon
            // 
            this.cbox_holsterWeapon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_holsterWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_holsterWeapon.DataSource = this.weaponBindingSource;
            this.cbox_holsterWeapon.DisplayMember = "Name";
            this.cbox_holsterWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_holsterWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_holsterWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_holsterWeapon.ForeColor = System.Drawing.Color.White;
            this.cbox_holsterWeapon.FormattingEnabled = true;
            this.cbox_holsterWeapon.Location = new System.Drawing.Point(0, 344);
            this.cbox_holsterWeapon.Name = "cbox_holsterWeapon";
            this.cbox_holsterWeapon.Size = new System.Drawing.Size(231, 27);
            this.cbox_holsterWeapon.TabIndex = 6;
            this.cbox_holsterWeapon.ValueMember = "WeaponID";
            // 
            // lbl_secondaryWeapon
            // 
            this.lbl_secondaryWeapon.AutoSize = true;
            this.lbl_secondaryWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondaryWeapon.ForeColor = System.Drawing.Color.White;
            this.lbl_secondaryWeapon.Location = new System.Drawing.Point(-2, 271);
            this.lbl_secondaryWeapon.Name = "lbl_secondaryWeapon";
            this.lbl_secondaryWeapon.Size = new System.Drawing.Size(129, 19);
            this.lbl_secondaryWeapon.TabIndex = 14;
            this.lbl_secondaryWeapon.Text = "Secondary Weapon";
            // 
            // cbox_secondaryWeapon
            // 
            this.cbox_secondaryWeapon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_secondaryWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_secondaryWeapon.DataSource = this.weaponBindingSource;
            this.cbox_secondaryWeapon.DisplayMember = "Name";
            this.cbox_secondaryWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_secondaryWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_secondaryWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_secondaryWeapon.ForeColor = System.Drawing.Color.White;
            this.cbox_secondaryWeapon.FormattingEnabled = true;
            this.cbox_secondaryWeapon.Location = new System.Drawing.Point(0, 292);
            this.cbox_secondaryWeapon.Name = "cbox_secondaryWeapon";
            this.cbox_secondaryWeapon.Size = new System.Drawing.Size(231, 27);
            this.cbox_secondaryWeapon.TabIndex = 5;
            this.cbox_secondaryWeapon.ValueMember = "WeaponID";
            // 
            // cbox_headwear
            // 
            this.cbox_headwear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_headwear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_headwear.DataSource = this.gearBindingSource;
            this.cbox_headwear.DisplayMember = "Name";
            this.cbox_headwear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_headwear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_headwear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_headwear.ForeColor = System.Drawing.Color.White;
            this.cbox_headwear.FormattingEnabled = true;
            this.cbox_headwear.Location = new System.Drawing.Point(0, 139);
            this.cbox_headwear.Name = "cbox_headwear";
            this.cbox_headwear.Size = new System.Drawing.Size(230, 27);
            this.cbox_headwear.TabIndex = 2;
            this.cbox_headwear.ValueMember = "GearID";
            // 
            // cbox_earpiece
            // 
            this.cbox_earpiece.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_earpiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_earpiece.DataSource = this.gearBindingSource;
            this.cbox_earpiece.DisplayMember = "Name";
            this.cbox_earpiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_earpiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_earpiece.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_earpiece.ForeColor = System.Drawing.Color.White;
            this.cbox_earpiece.FormattingEnabled = true;
            this.cbox_earpiece.Location = new System.Drawing.Point(0, 91);
            this.cbox_earpiece.Name = "cbox_earpiece";
            this.cbox_earpiece.Size = new System.Drawing.Size(230, 27);
            this.cbox_earpiece.TabIndex = 1;
            this.cbox_earpiece.ValueMember = "GearID";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(64, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Add / Edit";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(-4, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 19);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_earpiece
            // 
            this.lbl_earpiece.AutoSize = true;
            this.lbl_earpiece.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_earpiece.ForeColor = System.Drawing.Color.White;
            this.lbl_earpiece.Location = new System.Drawing.Point(-4, 71);
            this.lbl_earpiece.Name = "lbl_earpiece";
            this.lbl_earpiece.Size = new System.Drawing.Size(60, 19);
            this.lbl_earpiece.TabIndex = 7;
            this.lbl_earpiece.Text = "Earpiece";
            // 
            // lbl_headwear
            // 
            this.lbl_headwear.AutoSize = true;
            this.lbl_headwear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headwear.ForeColor = System.Drawing.Color.White;
            this.lbl_headwear.Location = new System.Drawing.Point(-4, 120);
            this.lbl_headwear.Name = "lbl_headwear";
            this.lbl_headwear.Size = new System.Drawing.Size(70, 19);
            this.lbl_headwear.TabIndex = 7;
            this.lbl_headwear.Text = "Headwear";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(1, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(227, 16);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_bodyArmour
            // 
            this.lbl_bodyArmour.AutoSize = true;
            this.lbl_bodyArmour.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bodyArmour.ForeColor = System.Drawing.Color.White;
            this.lbl_bodyArmour.Location = new System.Drawing.Point(-4, 169);
            this.lbl_bodyArmour.Name = "lbl_bodyArmour";
            this.lbl_bodyArmour.Size = new System.Drawing.Size(91, 19);
            this.lbl_bodyArmour.TabIndex = 7;
            this.lbl_bodyArmour.Text = "Body Armour";
            // 
            // lbl_primaryWeapon
            // 
            this.lbl_primaryWeapon.AutoSize = true;
            this.lbl_primaryWeapon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primaryWeapon.ForeColor = System.Drawing.Color.White;
            this.lbl_primaryWeapon.Location = new System.Drawing.Point(-4, 221);
            this.lbl_primaryWeapon.Name = "lbl_primaryWeapon";
            this.lbl_primaryWeapon.Size = new System.Drawing.Size(111, 19);
            this.lbl_primaryWeapon.TabIndex = 7;
            this.lbl_primaryWeapon.Text = "Primary Weapon";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 69);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(228, 1);
            this.panel9.TabIndex = 5;
            // 
            // dgv_loadouts
            // 
            this.dgv_loadouts.AllowUserToAddRows = false;
            this.dgv_loadouts.AllowUserToDeleteRows = false;
            this.dgv_loadouts.AutoGenerateColumns = false;
            this.dgv_loadouts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.dgv_loadouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_loadouts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_loadouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loadouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_loadoutID,
            this.nameDataGridViewTextBoxColumn,
            this.col_userID,
            this.col_earpieceID,
            this.Earpiece,
            this.col_headwearID,
            this.Headwear,
            this.col_bodyArmourID,
            this.BodyArmour,
            this.col_primaryWeaponID,
            this.PrimaryWeapon,
            this.col_secondaryWeaponID,
            this.SecondaryWeapon,
            this.col_holsterWeaponID,
            this.HolsterWeapon,
            this.col_rigID,
            this.Rig,
            this.col_backpackID,
            this.Backpack});
            this.dgv_loadouts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_loadouts.DataSource = this.loadoutBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_loadouts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_loadouts.Location = new System.Drawing.Point(12, 12);
            this.dgv_loadouts.MultiSelect = false;
            this.dgv_loadouts.Name = "dgv_loadouts";
            this.dgv_loadouts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_loadouts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_loadouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loadouts.ShowCellErrors = false;
            this.dgv_loadouts.ShowCellToolTips = false;
            this.dgv_loadouts.ShowEditingIcon = false;
            this.dgv_loadouts.ShowRowErrors = false;
            this.dgv_loadouts.Size = new System.Drawing.Size(783, 575);
            this.dgv_loadouts.TabIndex = 0;
            this.dgv_loadouts.DoubleClick += new System.EventHandler(this.dgv_weapons_DoubleClick);
            // 
            // col_loadoutID
            // 
            this.col_loadoutID.DataPropertyName = "LoadoutID";
            this.col_loadoutID.HeaderText = "LoadoutID";
            this.col_loadoutID.Name = "col_loadoutID";
            this.col_loadoutID.ReadOnly = true;
            this.col_loadoutID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col_userID
            // 
            this.col_userID.DataPropertyName = "UserID";
            this.col_userID.HeaderText = "UserID";
            this.col_userID.Name = "col_userID";
            this.col_userID.ReadOnly = true;
            this.col_userID.Visible = false;
            // 
            // col_earpieceID
            // 
            this.col_earpieceID.DataPropertyName = "EarpieceID";
            this.col_earpieceID.HeaderText = "EarpieceID";
            this.col_earpieceID.Name = "col_earpieceID";
            this.col_earpieceID.ReadOnly = true;
            this.col_earpieceID.Visible = false;
            // 
            // Earpiece
            // 
            this.Earpiece.DataPropertyName = "EarpieceID";
            this.Earpiece.DataSource = this.gearBindingSource;
            this.Earpiece.DisplayMember = "Name";
            this.Earpiece.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Earpiece.HeaderText = "Earpiece";
            this.Earpiece.Name = "Earpiece";
            this.Earpiece.ReadOnly = true;
            this.Earpiece.ValueMember = "GearID";
            this.Earpiece.Width = 150;
            // 
            // col_headwearID
            // 
            this.col_headwearID.DataPropertyName = "HeadwearID";
            this.col_headwearID.HeaderText = "HeadwearID";
            this.col_headwearID.Name = "col_headwearID";
            this.col_headwearID.ReadOnly = true;
            this.col_headwearID.Visible = false;
            // 
            // Headwear
            // 
            this.Headwear.DataPropertyName = "HeadwearID";
            this.Headwear.DataSource = this.gearBindingSource;
            this.Headwear.DisplayMember = "Name";
            this.Headwear.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Headwear.HeaderText = "Headwear";
            this.Headwear.Name = "Headwear";
            this.Headwear.ReadOnly = true;
            this.Headwear.ValueMember = "GearID";
            this.Headwear.Width = 150;
            // 
            // col_bodyArmourID
            // 
            this.col_bodyArmourID.DataPropertyName = "BodyArmourID";
            this.col_bodyArmourID.HeaderText = "BodyArmourID";
            this.col_bodyArmourID.Name = "col_bodyArmourID";
            this.col_bodyArmourID.ReadOnly = true;
            this.col_bodyArmourID.Visible = false;
            this.col_bodyArmourID.Width = 150;
            // 
            // BodyArmour
            // 
            this.BodyArmour.DataPropertyName = "BodyArmourID";
            this.BodyArmour.DataSource = this.gearBindingSource;
            this.BodyArmour.DisplayMember = "Name";
            this.BodyArmour.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BodyArmour.HeaderText = "Body Armour";
            this.BodyArmour.Name = "BodyArmour";
            this.BodyArmour.ReadOnly = true;
            this.BodyArmour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BodyArmour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BodyArmour.ValueMember = "GearID";
            this.BodyArmour.Width = 200;
            // 
            // col_primaryWeaponID
            // 
            this.col_primaryWeaponID.DataPropertyName = "PrimaryWeaponID";
            this.col_primaryWeaponID.HeaderText = "PrimaryWeaponID";
            this.col_primaryWeaponID.Name = "col_primaryWeaponID";
            this.col_primaryWeaponID.ReadOnly = true;
            this.col_primaryWeaponID.Visible = false;
            this.col_primaryWeaponID.Width = 170;
            // 
            // PrimaryWeapon
            // 
            this.PrimaryWeapon.DataPropertyName = "PrimaryWeaponID";
            this.PrimaryWeapon.DataSource = this.weaponBindingSource;
            this.PrimaryWeapon.DisplayMember = "Name";
            this.PrimaryWeapon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PrimaryWeapon.HeaderText = "Primary Weapon";
            this.PrimaryWeapon.Name = "PrimaryWeapon";
            this.PrimaryWeapon.ReadOnly = true;
            this.PrimaryWeapon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrimaryWeapon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrimaryWeapon.ValueMember = "WeaponID";
            this.PrimaryWeapon.Width = 200;
            // 
            // col_secondaryWeaponID
            // 
            this.col_secondaryWeaponID.DataPropertyName = "SecondaryWeaponID";
            this.col_secondaryWeaponID.HeaderText = "SecondaryWeaponID";
            this.col_secondaryWeaponID.Name = "col_secondaryWeaponID";
            this.col_secondaryWeaponID.ReadOnly = true;
            this.col_secondaryWeaponID.Visible = false;
            this.col_secondaryWeaponID.Width = 180;
            // 
            // SecondaryWeapon
            // 
            this.SecondaryWeapon.DataPropertyName = "SecondaryWeaponID";
            this.SecondaryWeapon.DataSource = this.weaponBindingSource;
            this.SecondaryWeapon.DisplayMember = "Name";
            this.SecondaryWeapon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SecondaryWeapon.HeaderText = "Secondary Weapon";
            this.SecondaryWeapon.Name = "SecondaryWeapon";
            this.SecondaryWeapon.ReadOnly = true;
            this.SecondaryWeapon.ValueMember = "WeaponID";
            this.SecondaryWeapon.Width = 200;
            // 
            // col_holsterWeaponID
            // 
            this.col_holsterWeaponID.DataPropertyName = "HolsterWeaponID";
            this.col_holsterWeaponID.HeaderText = "HolsterWeaponID";
            this.col_holsterWeaponID.Name = "col_holsterWeaponID";
            this.col_holsterWeaponID.ReadOnly = true;
            this.col_holsterWeaponID.Visible = false;
            this.col_holsterWeaponID.Width = 160;
            // 
            // HolsterWeapon
            // 
            this.HolsterWeapon.DataPropertyName = "HolsterWeaponID";
            this.HolsterWeapon.DataSource = this.weaponBindingSource;
            this.HolsterWeapon.DisplayMember = "Name";
            this.HolsterWeapon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.HolsterWeapon.HeaderText = "Holster Weapon";
            this.HolsterWeapon.Name = "HolsterWeapon";
            this.HolsterWeapon.ReadOnly = true;
            this.HolsterWeapon.ValueMember = "WeaponID";
            this.HolsterWeapon.Width = 160;
            // 
            // col_rigID
            // 
            this.col_rigID.DataPropertyName = "RigID";
            this.col_rigID.HeaderText = "RigID";
            this.col_rigID.Name = "col_rigID";
            this.col_rigID.ReadOnly = true;
            this.col_rigID.Visible = false;
            // 
            // Rig
            // 
            this.Rig.DataPropertyName = "RigID";
            this.Rig.DataSource = this.gearBindingSource;
            this.Rig.DisplayMember = "Name";
            this.Rig.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Rig.HeaderText = "Rig";
            this.Rig.Name = "Rig";
            this.Rig.ReadOnly = true;
            this.Rig.ValueMember = "GearID";
            this.Rig.Width = 150;
            // 
            // col_backpackID
            // 
            this.col_backpackID.DataPropertyName = "BackpackID";
            this.col_backpackID.HeaderText = "BackpackID";
            this.col_backpackID.Name = "col_backpackID";
            this.col_backpackID.ReadOnly = true;
            this.col_backpackID.Visible = false;
            // 
            // Backpack
            // 
            this.Backpack.DataPropertyName = "BackpackID";
            this.Backpack.DataSource = this.gearBindingSource;
            this.Backpack.DisplayMember = "Name";
            this.Backpack.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Backpack.HeaderText = "Backpack";
            this.Backpack.Name = "Backpack";
            this.Backpack.ReadOnly = true;
            this.Backpack.ValueMember = "GearID";
            this.Backpack.Width = 150;
            // 
            // loadoutBindingSource
            // 
            this.loadoutBindingSource.DataSource = typeof(EFTApp.Loadout);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(795, 600);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(265, 90);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(530, 600);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(265, 90);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(265, 600);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(265, 90);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 600);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(265, 90);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FormLoadout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoadout";
            this.Text = "Loadout";
            this.panel1.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loadouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.ComboBox cbox_primaryWeapon;
        private System.Windows.Forms.ComboBox cbox_bodyArmour;
        private System.Windows.Forms.Label lbl_secondaryWeapon;
        private System.Windows.Forms.ComboBox cbox_secondaryWeapon;
        private System.Windows.Forms.ComboBox cbox_headwear;
        private System.Windows.Forms.ComboBox cbox_earpiece;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_earpiece;
        private System.Windows.Forms.Label lbl_headwear;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_bodyArmour;
        private System.Windows.Forms.Label lbl_primaryWeapon;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgv_loadouts;
        private System.Windows.Forms.BindingSource loadoutBindingSource;
        private System.Windows.Forms.Label lbl_holsterWeapon;
        private System.Windows.Forms.ComboBox cbox_holsterWeapon;
        private System.Windows.Forms.Label lbl_backpack;
        private System.Windows.Forms.Label lbl_rig;
        private System.Windows.Forms.ComboBox cbox_backpack;
        private System.Windows.Forms.ComboBox cbox_rig;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.BindingSource gearBindingSource;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loadoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_earpieceID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Earpiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_headwearID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Headwear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bodyArmourID;
        private System.Windows.Forms.DataGridViewComboBoxColumn BodyArmour;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_primaryWeaponID;
        private System.Windows.Forms.DataGridViewComboBoxColumn PrimaryWeapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_secondaryWeaponID;
        private System.Windows.Forms.DataGridViewComboBoxColumn SecondaryWeapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_holsterWeaponID;
        private System.Windows.Forms.DataGridViewComboBoxColumn HolsterWeapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rigID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rig;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_backpackID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Backpack;
    }
}