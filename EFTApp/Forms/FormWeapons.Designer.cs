namespace EFTApp.Forms
{
    partial class FormWeapons
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
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dgv_weapons = new System.Windows.Forms.DataGridView();
            this.col_weaponID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalRecoilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horizontalRecoilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ergonomicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.burstDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_caliberId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.caliberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CaliberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.lbl_caliber = new System.Windows.Forms.Label();
            this.cbox_caliberID = new System.Windows.Forms.ComboBox();
            this.cbox_slot = new System.Windows.Forms.ComboBox();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.chk_auto = new System.Windows.Forms.CheckBox();
            this.chk_burst = new System.Windows.Forms.CheckBox();
            this.chk_single = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_verticalRecoil = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_horizontalRecoil = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_ergonomics = new System.Windows.Forms.Label();
            this.lbl_range = new System.Windows.Forms.Label();
            this.txt_horizontalRecoil = new System.Windows.Forms.TextBox();
            this.txt_verticalRecoil = new System.Windows.Forms.TextBox();
            this.lbl_fireRate = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ergonomics = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txt_range = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txt_fireRate = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caliberBindingSource)).BeginInit();
            this.panel_edit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(EFTApp.Weapon);
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
            // dgv_weapons
            // 
            this.dgv_weapons.AllowUserToAddRows = false;
            this.dgv_weapons.AllowUserToDeleteRows = false;
            this.dgv_weapons.AutoGenerateColumns = false;
            this.dgv_weapons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.dgv_weapons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_weapons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_weapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_weapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_weaponID,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.slotDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.verticalRecoilDataGridViewTextBoxColumn,
            this.horizontalRecoilDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.ergonomicsDataGridViewTextBoxColumn,
            this.fireRateDataGridViewTextBoxColumn,
            this.singleDataGridViewCheckBoxColumn,
            this.burstDataGridViewCheckBoxColumn,
            this.autoDataGridViewCheckBoxColumn,
            this.col_caliberId,
            this.CaliberName});
            this.dgv_weapons.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_weapons.DataSource = this.weaponBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_weapons.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_weapons.Location = new System.Drawing.Point(12, 24);
            this.dgv_weapons.MultiSelect = false;
            this.dgv_weapons.Name = "dgv_weapons";
            this.dgv_weapons.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_weapons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_weapons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_weapons.ShowCellErrors = false;
            this.dgv_weapons.ShowCellToolTips = false;
            this.dgv_weapons.ShowEditingIcon = false;
            this.dgv_weapons.ShowRowErrors = false;
            this.dgv_weapons.Size = new System.Drawing.Size(783, 548);
            this.dgv_weapons.TabIndex = 0;
            this.dgv_weapons.DoubleClick += new System.EventHandler(this.dgv_weapons_DoubleClick);
            // 
            // col_weaponID
            // 
            this.col_weaponID.DataPropertyName = "WeaponID";
            this.col_weaponID.HeaderText = "WeaponID";
            this.col_weaponID.Name = "col_weaponID";
            this.col_weaponID.ReadOnly = true;
            this.col_weaponID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 170;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slotDataGridViewTextBoxColumn
            // 
            this.slotDataGridViewTextBoxColumn.DataPropertyName = "Slot";
            this.slotDataGridViewTextBoxColumn.HeaderText = "Slot";
            this.slotDataGridViewTextBoxColumn.Name = "slotDataGridViewTextBoxColumn";
            this.slotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verticalRecoilDataGridViewTextBoxColumn
            // 
            this.verticalRecoilDataGridViewTextBoxColumn.DataPropertyName = "VerticalRecoil";
            this.verticalRecoilDataGridViewTextBoxColumn.HeaderText = "Vertical Recoil";
            this.verticalRecoilDataGridViewTextBoxColumn.Name = "verticalRecoilDataGridViewTextBoxColumn";
            this.verticalRecoilDataGridViewTextBoxColumn.ReadOnly = true;
            this.verticalRecoilDataGridViewTextBoxColumn.Width = 150;
            // 
            // horizontalRecoilDataGridViewTextBoxColumn
            // 
            this.horizontalRecoilDataGridViewTextBoxColumn.DataPropertyName = "HorizontalRecoil";
            this.horizontalRecoilDataGridViewTextBoxColumn.HeaderText = "Horizontal Recoil";
            this.horizontalRecoilDataGridViewTextBoxColumn.Name = "horizontalRecoilDataGridViewTextBoxColumn";
            this.horizontalRecoilDataGridViewTextBoxColumn.ReadOnly = true;
            this.horizontalRecoilDataGridViewTextBoxColumn.Width = 160;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ergonomicsDataGridViewTextBoxColumn
            // 
            this.ergonomicsDataGridViewTextBoxColumn.DataPropertyName = "Ergonomics";
            this.ergonomicsDataGridViewTextBoxColumn.HeaderText = "Ergonomics";
            this.ergonomicsDataGridViewTextBoxColumn.Name = "ergonomicsDataGridViewTextBoxColumn";
            this.ergonomicsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fireRateDataGridViewTextBoxColumn
            // 
            this.fireRateDataGridViewTextBoxColumn.DataPropertyName = "FireRate";
            this.fireRateDataGridViewTextBoxColumn.HeaderText = "Rate of fire";
            this.fireRateDataGridViewTextBoxColumn.Name = "fireRateDataGridViewTextBoxColumn";
            this.fireRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fireRateDataGridViewTextBoxColumn.Width = 120;
            // 
            // singleDataGridViewCheckBoxColumn
            // 
            this.singleDataGridViewCheckBoxColumn.DataPropertyName = "Single";
            this.singleDataGridViewCheckBoxColumn.HeaderText = "Single Fire";
            this.singleDataGridViewCheckBoxColumn.Name = "singleDataGridViewCheckBoxColumn";
            this.singleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // burstDataGridViewCheckBoxColumn
            // 
            this.burstDataGridViewCheckBoxColumn.DataPropertyName = "Burst";
            this.burstDataGridViewCheckBoxColumn.HeaderText = "Burst Fire";
            this.burstDataGridViewCheckBoxColumn.Name = "burstDataGridViewCheckBoxColumn";
            this.burstDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // autoDataGridViewCheckBoxColumn
            // 
            this.autoDataGridViewCheckBoxColumn.DataPropertyName = "Auto";
            this.autoDataGridViewCheckBoxColumn.HeaderText = "Automatic";
            this.autoDataGridViewCheckBoxColumn.Name = "autoDataGridViewCheckBoxColumn";
            this.autoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // col_caliberId
            // 
            this.col_caliberId.DataPropertyName = "CaliberID";
            this.col_caliberId.DataSource = this.caliberBindingSource;
            this.col_caliberId.DisplayMember = "CaliberID";
            this.col_caliberId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_caliberId.HeaderText = "CaliberID";
            this.col_caliberId.Name = "col_caliberId";
            this.col_caliberId.ReadOnly = true;
            this.col_caliberId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_caliberId.ValueMember = "CaliberID";
            this.col_caliberId.Visible = false;
            // 
            // caliberBindingSource
            // 
            this.caliberBindingSource.DataSource = typeof(EFTApp.Caliber);
            // 
            // CaliberName
            // 
            this.CaliberName.DataPropertyName = "CaliberID";
            this.CaliberName.DataSource = this.caliberBindingSource;
            this.CaliberName.DisplayMember = "Name";
            this.CaliberName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CaliberName.HeaderText = "Caliber Name";
            this.CaliberName.Name = "CaliberName";
            this.CaliberName.ReadOnly = true;
            this.CaliberName.ValueMember = "CaliberID";
            this.CaliberName.Width = 150;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_edit.Controls.Add(this.lbl_caliber);
            this.panel_edit.Controls.Add(this.cbox_caliberID);
            this.panel_edit.Controls.Add(this.cbox_slot);
            this.panel_edit.Controls.Add(this.cbox_type);
            this.panel_edit.Controls.Add(this.chk_auto);
            this.panel_edit.Controls.Add(this.chk_burst);
            this.panel_edit.Controls.Add(this.chk_single);
            this.panel_edit.Controls.Add(this.label12);
            this.panel_edit.Controls.Add(this.lbl_name);
            this.panel_edit.Controls.Add(this.lbl_type);
            this.panel_edit.Controls.Add(this.lbl_slot);
            this.panel_edit.Controls.Add(this.txt_name);
            this.panel_edit.Controls.Add(this.lbl_weight);
            this.panel_edit.Controls.Add(this.lbl_verticalRecoil);
            this.panel_edit.Controls.Add(this.txt_weight);
            this.panel_edit.Controls.Add(this.lbl_horizontalRecoil);
            this.panel_edit.Controls.Add(this.panel9);
            this.panel_edit.Controls.Add(this.lbl_ergonomics);
            this.panel_edit.Controls.Add(this.lbl_range);
            this.panel_edit.Controls.Add(this.txt_horizontalRecoil);
            this.panel_edit.Controls.Add(this.txt_verticalRecoil);
            this.panel_edit.Controls.Add(this.lbl_fireRate);
            this.panel_edit.Controls.Add(this.panel13);
            this.panel_edit.Controls.Add(this.panel2);
            this.panel_edit.Controls.Add(this.txt_ergonomics);
            this.panel_edit.Controls.Add(this.panel14);
            this.panel_edit.Controls.Add(this.txt_range);
            this.panel_edit.Controls.Add(this.panel15);
            this.panel_edit.Controls.Add(this.panel16);
            this.panel_edit.Controls.Add(this.txt_fireRate);
            this.panel_edit.Controls.Add(this.panel18);
            this.panel_edit.Location = new System.Drawing.Point(807, 24);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(241, 548);
            this.panel_edit.TabIndex = 0;
            // 
            // lbl_caliber
            // 
            this.lbl_caliber.AutoSize = true;
            this.lbl_caliber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caliber.ForeColor = System.Drawing.Color.White;
            this.lbl_caliber.Location = new System.Drawing.Point(-1, 414);
            this.lbl_caliber.Name = "lbl_caliber";
            this.lbl_caliber.Size = new System.Drawing.Size(51, 19);
            this.lbl_caliber.TabIndex = 14;
            this.lbl_caliber.Text = "Caliber";
            // 
            // cbox_caliberID
            // 
            this.cbox_caliberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_caliberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_caliberID.DataSource = this.caliberBindingSource;
            this.cbox_caliberID.DisplayMember = "Name";
            this.cbox_caliberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_caliberID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_caliberID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_caliberID.ForeColor = System.Drawing.Color.White;
            this.cbox_caliberID.FormattingEnabled = true;
            this.cbox_caliberID.Location = new System.Drawing.Point(0, 433);
            this.cbox_caliberID.Name = "cbox_caliberID";
            this.cbox_caliberID.Size = new System.Drawing.Size(231, 28);
            this.cbox_caliberID.TabIndex = 9;
            this.cbox_caliberID.ValueMember = "CaliberID";
            // 
            // cbox_slot
            // 
            this.cbox_slot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_slot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_slot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_slot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_slot.ForeColor = System.Drawing.Color.White;
            this.cbox_slot.FormattingEnabled = true;
            this.cbox_slot.Items.AddRange(new object[] {
            "Primary",
            "Secondary"});
            this.cbox_slot.Location = new System.Drawing.Point(0, 137);
            this.cbox_slot.Name = "cbox_slot";
            this.cbox_slot.Size = new System.Drawing.Size(230, 27);
            this.cbox_slot.TabIndex = 2;
            // 
            // cbox_type
            // 
            this.cbox_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_type.ForeColor = System.Drawing.Color.White;
            this.cbox_type.FormattingEnabled = true;
            this.cbox_type.Items.AddRange(new object[] {
            "Assault rifle",
            "Assault carbine",
            "Light machine gun",
            "Submachine gun",
            "Shotgun",
            "Designated marksman rifle",
            "Sniper rifle",
            "Pistol"});
            this.cbox_type.Location = new System.Drawing.Point(0, 94);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(230, 27);
            this.cbox_type.TabIndex = 1;
            // 
            // chk_auto
            // 
            this.chk_auto.AutoSize = true;
            this.chk_auto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_auto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_auto.ForeColor = System.Drawing.Color.White;
            this.chk_auto.Location = new System.Drawing.Point(-1, 513);
            this.chk_auto.Name = "chk_auto";
            this.chk_auto.Size = new System.Drawing.Size(90, 23);
            this.chk_auto.TabIndex = 12;
            this.chk_auto.Text = "Automatic";
            this.chk_auto.UseVisualStyleBackColor = true;
            // 
            // chk_burst
            // 
            this.chk_burst.AutoSize = true;
            this.chk_burst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_burst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_burst.ForeColor = System.Drawing.Color.White;
            this.chk_burst.Location = new System.Drawing.Point(-1, 490);
            this.chk_burst.Name = "chk_burst";
            this.chk_burst.Size = new System.Drawing.Size(84, 23);
            this.chk_burst.TabIndex = 11;
            this.chk_burst.Text = "Burst Fire";
            this.chk_burst.UseVisualStyleBackColor = true;
            // 
            // chk_single
            // 
            this.chk_single.AutoSize = true;
            this.chk_single.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_single.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_single.ForeColor = System.Drawing.Color.White;
            this.chk_single.Location = new System.Drawing.Point(-1, 467);
            this.chk_single.Name = "chk_single";
            this.chk_single.Size = new System.Drawing.Size(89, 23);
            this.chk_single.TabIndex = 10;
            this.chk_single.Text = "Single Fire";
            this.chk_single.UseVisualStyleBackColor = true;
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
            this.lbl_name.Location = new System.Drawing.Point(-4, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 19);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.White;
            this.lbl_type.Location = new System.Drawing.Point(-4, 76);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(38, 19);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "Type";
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot.ForeColor = System.Drawing.Color.White;
            this.lbl_slot.Location = new System.Drawing.Point(-4, 118);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(33, 19);
            this.lbl_slot.TabIndex = 7;
            this.lbl_slot.Text = "Slot";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(1, 56);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(227, 16);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.ForeColor = System.Drawing.Color.White;
            this.lbl_weight.Location = new System.Drawing.Point(-4, 163);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(53, 19);
            this.lbl_weight.TabIndex = 7;
            this.lbl_weight.Text = "Weight";
            // 
            // lbl_verticalRecoil
            // 
            this.lbl_verticalRecoil.AutoSize = true;
            this.lbl_verticalRecoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verticalRecoil.ForeColor = System.Drawing.Color.White;
            this.lbl_verticalRecoil.Location = new System.Drawing.Point(-4, 206);
            this.lbl_verticalRecoil.Name = "lbl_verticalRecoil";
            this.lbl_verticalRecoil.Size = new System.Drawing.Size(95, 19);
            this.lbl_verticalRecoil.TabIndex = 7;
            this.lbl_verticalRecoil.Text = "Vertical Recoil";
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.ForeColor = System.Drawing.Color.White;
            this.txt_weight.Location = new System.Drawing.Point(1, 184);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(227, 16);
            this.txt_weight.TabIndex = 3;
            // 
            // lbl_horizontalRecoil
            // 
            this.lbl_horizontalRecoil.AutoSize = true;
            this.lbl_horizontalRecoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horizontalRecoil.ForeColor = System.Drawing.Color.White;
            this.lbl_horizontalRecoil.Location = new System.Drawing.Point(-4, 248);
            this.lbl_horizontalRecoil.Name = "lbl_horizontalRecoil";
            this.lbl_horizontalRecoil.Size = new System.Drawing.Size(112, 19);
            this.lbl_horizontalRecoil.TabIndex = 7;
            this.lbl_horizontalRecoil.Text = "Horizontal Recoil";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 74);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(228, 1);
            this.panel9.TabIndex = 5;
            // 
            // lbl_ergonomics
            // 
            this.lbl_ergonomics.AutoSize = true;
            this.lbl_ergonomics.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ergonomics.ForeColor = System.Drawing.Color.White;
            this.lbl_ergonomics.Location = new System.Drawing.Point(-4, 333);
            this.lbl_ergonomics.Name = "lbl_ergonomics";
            this.lbl_ergonomics.Size = new System.Drawing.Size(81, 19);
            this.lbl_ergonomics.TabIndex = 7;
            this.lbl_ergonomics.Text = "Ergonomics";
            // 
            // lbl_range
            // 
            this.lbl_range.AutoSize = true;
            this.lbl_range.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_range.ForeColor = System.Drawing.Color.White;
            this.lbl_range.Location = new System.Drawing.Point(-4, 291);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(47, 19);
            this.lbl_range.TabIndex = 7;
            this.lbl_range.Text = "Range";
            // 
            // txt_horizontalRecoil
            // 
            this.txt_horizontalRecoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_horizontalRecoil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_horizontalRecoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horizontalRecoil.ForeColor = System.Drawing.Color.White;
            this.txt_horizontalRecoil.Location = new System.Drawing.Point(0, 269);
            this.txt_horizontalRecoil.Name = "txt_horizontalRecoil";
            this.txt_horizontalRecoil.Size = new System.Drawing.Size(227, 16);
            this.txt_horizontalRecoil.TabIndex = 5;
            // 
            // txt_verticalRecoil
            // 
            this.txt_verticalRecoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_verticalRecoil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_verticalRecoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verticalRecoil.ForeColor = System.Drawing.Color.White;
            this.txt_verticalRecoil.Location = new System.Drawing.Point(1, 226);
            this.txt_verticalRecoil.Name = "txt_verticalRecoil";
            this.txt_verticalRecoil.Size = new System.Drawing.Size(227, 16);
            this.txt_verticalRecoil.TabIndex = 4;
            // 
            // lbl_fireRate
            // 
            this.lbl_fireRate.AutoSize = true;
            this.lbl_fireRate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fireRate.ForeColor = System.Drawing.Color.White;
            this.lbl_fireRate.Location = new System.Drawing.Point(-4, 373);
            this.lbl_fireRate.Name = "lbl_fireRate";
            this.lbl_fireRate.Size = new System.Drawing.Size(77, 19);
            this.lbl_fireRate.TabIndex = 7;
            this.lbl_fireRate.Text = "Rate of fire";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(0, 202);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(228, 1);
            this.panel13.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 1);
            this.panel2.TabIndex = 5;
            // 
            // txt_ergonomics
            // 
            this.txt_ergonomics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_ergonomics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ergonomics.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ergonomics.ForeColor = System.Drawing.Color.White;
            this.txt_ergonomics.Location = new System.Drawing.Point(1, 353);
            this.txt_ergonomics.Name = "txt_ergonomics";
            this.txt_ergonomics.Size = new System.Drawing.Size(227, 16);
            this.txt_ergonomics.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(0, 244);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(228, 1);
            this.panel14.TabIndex = 5;
            // 
            // txt_range
            // 
            this.txt_range.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_range.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_range.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_range.ForeColor = System.Drawing.Color.White;
            this.txt_range.Location = new System.Drawing.Point(1, 311);
            this.txt_range.Name = "txt_range";
            this.txt_range.Size = new System.Drawing.Size(227, 16);
            this.txt_range.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(0, 371);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(228, 1);
            this.panel15.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(0, 329);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(228, 1);
            this.panel16.TabIndex = 5;
            // 
            // txt_fireRate
            // 
            this.txt_fireRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_fireRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fireRate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fireRate.ForeColor = System.Drawing.Color.White;
            this.txt_fireRate.Location = new System.Drawing.Point(3, 393);
            this.txt_fireRate.Name = "txt_fireRate";
            this.txt_fireRate.Size = new System.Drawing.Size(225, 16);
            this.txt_fireRate.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(2, 411);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(228, 1);
            this.panel18.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_edit);
            this.panel1.Controls.Add(this.dgv_weapons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 600);
            this.panel1.TabIndex = 8;
            // 
            // FormWeapons
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
            this.Name = "FormWeapons";
            this.Text = "Weapons";
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caliberBindingSource)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_weapons;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.ComboBox cbox_slot;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.CheckBox chk_auto;
        private System.Windows.Forms.CheckBox chk_burst;
        private System.Windows.Forms.CheckBox chk_single;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_verticalRecoil;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_horizontalRecoil;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_ergonomics;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.TextBox txt_verticalRecoil;
        private System.Windows.Forms.Label lbl_fireRate;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txt_ergonomics;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txt_range;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txt_fireRate;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_horizontalRecoil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_caliber;
        private System.Windows.Forms.ComboBox cbox_caliberID;
        private System.Windows.Forms.BindingSource caliberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_weaponID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalRecoilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horizontalRecoilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ergonomicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fireRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn singleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn burstDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_caliberId;
        private System.Windows.Forms.DataGridViewComboBoxColumn CaliberName;
    }
}