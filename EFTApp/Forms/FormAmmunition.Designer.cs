namespace EFTApp.Forms
{
    partial class FormAmmunition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ammunition = new System.Windows.Forms.DataGridView();
            this.col_ammunitionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_penetration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_armourDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_recoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fragmentationChance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ricochetChance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_caliberId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.caliberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_caliberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ammunitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_damage = new System.Windows.Forms.Label();
            this.lbl_penetration = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_armourDamage = new System.Windows.Forms.Label();
            this.txt_damage = new System.Windows.Forms.TextBox();
            this.lbl_accuracy = new System.Windows.Forms.Label();
            this.txt_penetration = new System.Windows.Forms.TextBox();
            this.lbl_recoil = new System.Windows.Forms.Label();
            this.txt_armourDamage = new System.Windows.Forms.TextBox();
            this.lbl_fragmentationChance = new System.Windows.Forms.Label();
            this.txt_accuracy = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_ricochetChance = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_recoil = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_fragmentationChance = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_caliber = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_ricochetChance = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbox_caliberID = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ammunition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caliberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammunitionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ammunition
            // 
            this.dgv_ammunition.AllowUserToAddRows = false;
            this.dgv_ammunition.AllowUserToDeleteRows = false;
            this.dgv_ammunition.AutoGenerateColumns = false;
            this.dgv_ammunition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.dgv_ammunition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ammunition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ammunition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ammunition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ammunitionID,
            this.col_name,
            this.col_damage,
            this.col_penetration,
            this.col_armourDamage,
            this.col_accuracy,
            this.col_recoil,
            this.col_fragmentationChance,
            this.col_ricochetChance,
            this.col_speed,
            this.col_caliberId,
            this.col_caliberName});
            this.dgv_ammunition.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_ammunition.DataSource = this.ammunitionBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ammunition.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ammunition.Location = new System.Drawing.Point(12, 34);
            this.dgv_ammunition.MultiSelect = false;
            this.dgv_ammunition.Name = "dgv_ammunition";
            this.dgv_ammunition.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ammunition.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ammunition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ammunition.Size = new System.Drawing.Size(783, 535);
            this.dgv_ammunition.TabIndex = 0;
            this.dgv_ammunition.DoubleClick += new System.EventHandler(this.dgv_ammunition_DoubleClick);
            // 
            // col_ammunitionID
            // 
            this.col_ammunitionID.DataPropertyName = "AmmunitionID";
            this.col_ammunitionID.HeaderText = "AmmunitionID";
            this.col_ammunitionID.Name = "col_ammunitionID";
            this.col_ammunitionID.ReadOnly = true;
            this.col_ammunitionID.Visible = false;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "Name";
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_damage
            // 
            this.col_damage.DataPropertyName = "Damage";
            this.col_damage.HeaderText = "Damage";
            this.col_damage.Name = "col_damage";
            this.col_damage.ReadOnly = true;
            this.col_damage.Width = 90;
            // 
            // col_penetration
            // 
            this.col_penetration.DataPropertyName = "Penetration";
            this.col_penetration.HeaderText = "Penetration";
            this.col_penetration.Name = "col_penetration";
            this.col_penetration.ReadOnly = true;
            this.col_penetration.Width = 110;
            // 
            // col_armourDamage
            // 
            this.col_armourDamage.DataPropertyName = "ArmourDamage";
            this.col_armourDamage.HeaderText = "Armour Damage";
            this.col_armourDamage.Name = "col_armourDamage";
            this.col_armourDamage.ReadOnly = true;
            this.col_armourDamage.Width = 160;
            // 
            // col_accuracy
            // 
            this.col_accuracy.DataPropertyName = "Accuracy";
            this.col_accuracy.HeaderText = "Accuracy";
            this.col_accuracy.Name = "col_accuracy";
            this.col_accuracy.ReadOnly = true;
            // 
            // col_recoil
            // 
            this.col_recoil.DataPropertyName = "Recoil";
            this.col_recoil.HeaderText = "Recoil";
            this.col_recoil.Name = "col_recoil";
            this.col_recoil.ReadOnly = true;
            this.col_recoil.Width = 80;
            // 
            // col_fragmentationChance
            // 
            this.col_fragmentationChance.DataPropertyName = "FragmentationChance";
            this.col_fragmentationChance.HeaderText = "Fragmentation Chance";
            this.col_fragmentationChance.Name = "col_fragmentationChance";
            this.col_fragmentationChance.ReadOnly = true;
            this.col_fragmentationChance.Width = 200;
            // 
            // col_ricochetChance
            // 
            this.col_ricochetChance.DataPropertyName = "RicochetChance";
            this.col_ricochetChance.HeaderText = "Ricochet Chance";
            this.col_ricochetChance.Name = "col_ricochetChance";
            this.col_ricochetChance.ReadOnly = true;
            this.col_ricochetChance.Width = 180;
            // 
            // col_speed
            // 
            this.col_speed.DataPropertyName = "Speed";
            this.col_speed.HeaderText = "Speed";
            this.col_speed.Name = "col_speed";
            this.col_speed.ReadOnly = true;
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
            this.col_caliberId.ValueMember = "CaliberID";
            this.col_caliberId.Visible = false;
            // 
            // caliberBindingSource
            // 
            this.caliberBindingSource.DataSource = typeof(EFTApp.Caliber);
            // 
            // col_caliberName
            // 
            this.col_caliberName.DataPropertyName = "CaliberID";
            this.col_caliberName.DataSource = this.caliberBindingSource;
            this.col_caliberName.DisplayMember = "Name";
            this.col_caliberName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_caliberName.HeaderText = "Caliber Name";
            this.col_caliberName.Name = "col_caliberName";
            this.col_caliberName.ReadOnly = true;
            this.col_caliberName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_caliberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_caliberName.ValueMember = "CaliberID";
            this.col_caliberName.Width = 160;
            // 
            // ammunitionBindingSource
            // 
            this.ammunitionBindingSource.DataSource = typeof(EFTApp.Ammunition);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Caliber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Caliber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Caliber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Caliber Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_edit);
            this.panel1.Controls.Add(this.dgv_ammunition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 600);
            this.panel1.TabIndex = 1;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_edit.Controls.Add(this.label11);
            this.panel_edit.Controls.Add(this.lbl_name);
            this.panel_edit.Controls.Add(this.lbl_damage);
            this.panel_edit.Controls.Add(this.lbl_penetration);
            this.panel_edit.Controls.Add(this.txt_name);
            this.panel_edit.Controls.Add(this.lbl_armourDamage);
            this.panel_edit.Controls.Add(this.txt_damage);
            this.panel_edit.Controls.Add(this.lbl_accuracy);
            this.panel_edit.Controls.Add(this.txt_penetration);
            this.panel_edit.Controls.Add(this.lbl_recoil);
            this.panel_edit.Controls.Add(this.txt_armourDamage);
            this.panel_edit.Controls.Add(this.lbl_fragmentationChance);
            this.panel_edit.Controls.Add(this.txt_accuracy);
            this.panel_edit.Controls.Add(this.panel10);
            this.panel_edit.Controls.Add(this.lbl_ricochetChance);
            this.panel_edit.Controls.Add(this.panel9);
            this.panel_edit.Controls.Add(this.txt_recoil);
            this.panel_edit.Controls.Add(this.panel8);
            this.panel_edit.Controls.Add(this.lbl_speed);
            this.panel_edit.Controls.Add(this.panel7);
            this.panel_edit.Controls.Add(this.txt_fragmentationChance);
            this.panel_edit.Controls.Add(this.panel6);
            this.panel_edit.Controls.Add(this.lbl_caliber);
            this.panel_edit.Controls.Add(this.panel5);
            this.panel_edit.Controls.Add(this.txt_ricochetChance);
            this.panel_edit.Controls.Add(this.panel4);
            this.panel_edit.Controls.Add(this.cbox_caliberID);
            this.panel_edit.Controls.Add(this.panel2);
            this.panel_edit.Controls.Add(this.txt_speed);
            this.panel_edit.Controls.Add(this.panel11);
            this.panel_edit.Location = new System.Drawing.Point(805, 34);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(243, 535);
            this.panel_edit.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(65, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Add / Edit";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(-4, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 19);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_damage
            // 
            this.lbl_damage.AutoSize = true;
            this.lbl_damage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_damage.ForeColor = System.Drawing.Color.White;
            this.lbl_damage.Location = new System.Drawing.Point(-4, 102);
            this.lbl_damage.Name = "lbl_damage";
            this.lbl_damage.Size = new System.Drawing.Size(60, 19);
            this.lbl_damage.TabIndex = 7;
            this.lbl_damage.Text = "Damage";
            // 
            // lbl_penetration
            // 
            this.lbl_penetration.AutoSize = true;
            this.lbl_penetration.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_penetration.ForeColor = System.Drawing.Color.White;
            this.lbl_penetration.Location = new System.Drawing.Point(-4, 144);
            this.lbl_penetration.Name = "lbl_penetration";
            this.lbl_penetration.Size = new System.Drawing.Size(80, 19);
            this.lbl_penetration.TabIndex = 7;
            this.lbl_penetration.Text = "Penetration";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(1, 82);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(237, 16);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_armourDamage
            // 
            this.lbl_armourDamage.AutoSize = true;
            this.lbl_armourDamage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_armourDamage.ForeColor = System.Drawing.Color.White;
            this.lbl_armourDamage.Location = new System.Drawing.Point(-4, 189);
            this.lbl_armourDamage.Name = "lbl_armourDamage";
            this.lbl_armourDamage.Size = new System.Drawing.Size(111, 19);
            this.lbl_armourDamage.TabIndex = 7;
            this.lbl_armourDamage.Text = "Armour Damage";
            // 
            // txt_damage
            // 
            this.txt_damage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_damage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_damage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_damage.ForeColor = System.Drawing.Color.White;
            this.txt_damage.Location = new System.Drawing.Point(1, 123);
            this.txt_damage.Name = "txt_damage";
            this.txt_damage.Size = new System.Drawing.Size(237, 16);
            this.txt_damage.TabIndex = 4;
            // 
            // lbl_accuracy
            // 
            this.lbl_accuracy.AutoSize = true;
            this.lbl_accuracy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accuracy.ForeColor = System.Drawing.Color.White;
            this.lbl_accuracy.Location = new System.Drawing.Point(-4, 234);
            this.lbl_accuracy.Name = "lbl_accuracy";
            this.lbl_accuracy.Size = new System.Drawing.Size(66, 19);
            this.lbl_accuracy.TabIndex = 7;
            this.lbl_accuracy.Text = "Accuracy";
            // 
            // txt_penetration
            // 
            this.txt_penetration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_penetration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_penetration.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penetration.ForeColor = System.Drawing.Color.White;
            this.txt_penetration.Location = new System.Drawing.Point(1, 165);
            this.txt_penetration.Name = "txt_penetration";
            this.txt_penetration.Size = new System.Drawing.Size(237, 16);
            this.txt_penetration.TabIndex = 4;
            // 
            // lbl_recoil
            // 
            this.lbl_recoil.AutoSize = true;
            this.lbl_recoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recoil.ForeColor = System.Drawing.Color.White;
            this.lbl_recoil.Location = new System.Drawing.Point(-4, 276);
            this.lbl_recoil.Name = "lbl_recoil";
            this.lbl_recoil.Size = new System.Drawing.Size(45, 19);
            this.lbl_recoil.TabIndex = 7;
            this.lbl_recoil.Text = "Recoil";
            // 
            // txt_armourDamage
            // 
            this.txt_armourDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_armourDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_armourDamage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_armourDamage.ForeColor = System.Drawing.Color.White;
            this.txt_armourDamage.Location = new System.Drawing.Point(1, 210);
            this.txt_armourDamage.Name = "txt_armourDamage";
            this.txt_armourDamage.Size = new System.Drawing.Size(237, 16);
            this.txt_armourDamage.TabIndex = 4;
            // 
            // lbl_fragmentationChance
            // 
            this.lbl_fragmentationChance.AutoSize = true;
            this.lbl_fragmentationChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fragmentationChance.ForeColor = System.Drawing.Color.White;
            this.lbl_fragmentationChance.Location = new System.Drawing.Point(-4, 318);
            this.lbl_fragmentationChance.Name = "lbl_fragmentationChance";
            this.lbl_fragmentationChance.Size = new System.Drawing.Size(149, 19);
            this.lbl_fragmentationChance.TabIndex = 7;
            this.lbl_fragmentationChance.Text = "Fragmentation Chance";
            // 
            // txt_accuracy
            // 
            this.txt_accuracy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_accuracy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_accuracy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accuracy.ForeColor = System.Drawing.Color.White;
            this.txt_accuracy.Location = new System.Drawing.Point(1, 255);
            this.txt_accuracy.Name = "txt_accuracy";
            this.txt_accuracy.Size = new System.Drawing.Size(237, 16);
            this.txt_accuracy.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(0, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(230, 1);
            this.panel10.TabIndex = 5;
            // 
            // lbl_ricochetChance
            // 
            this.lbl_ricochetChance.AutoSize = true;
            this.lbl_ricochetChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ricochetChance.ForeColor = System.Drawing.Color.White;
            this.lbl_ricochetChance.Location = new System.Drawing.Point(-4, 361);
            this.lbl_ricochetChance.Name = "lbl_ricochetChance";
            this.lbl_ricochetChance.Size = new System.Drawing.Size(112, 19);
            this.lbl_ricochetChance.TabIndex = 7;
            this.lbl_ricochetChance.Text = "Ricochet Chance";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 141);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(230, 1);
            this.panel9.TabIndex = 5;
            // 
            // txt_recoil
            // 
            this.txt_recoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_recoil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recoil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recoil.ForeColor = System.Drawing.Color.White;
            this.txt_recoil.Location = new System.Drawing.Point(1, 297);
            this.txt_recoil.Name = "txt_recoil";
            this.txt_recoil.Size = new System.Drawing.Size(237, 16);
            this.txt_recoil.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(0, 183);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(230, 1);
            this.panel8.TabIndex = 5;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.White;
            this.lbl_speed.Location = new System.Drawing.Point(-2, 402);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(47, 19);
            this.lbl_speed.TabIndex = 7;
            this.lbl_speed.Text = "Speed";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 228);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 1);
            this.panel7.TabIndex = 5;
            // 
            // txt_fragmentationChance
            // 
            this.txt_fragmentationChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_fragmentationChance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fragmentationChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fragmentationChance.ForeColor = System.Drawing.Color.White;
            this.txt_fragmentationChance.Location = new System.Drawing.Point(1, 339);
            this.txt_fragmentationChance.Name = "txt_fragmentationChance";
            this.txt_fragmentationChance.Size = new System.Drawing.Size(237, 16);
            this.txt_fragmentationChance.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 273);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 5;
            // 
            // lbl_caliber
            // 
            this.lbl_caliber.AutoSize = true;
            this.lbl_caliber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caliber.ForeColor = System.Drawing.Color.White;
            this.lbl_caliber.Location = new System.Drawing.Point(-3, 446);
            this.lbl_caliber.Name = "lbl_caliber";
            this.lbl_caliber.Size = new System.Drawing.Size(51, 19);
            this.lbl_caliber.TabIndex = 7;
            this.lbl_caliber.Text = "Caliber";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 1);
            this.panel5.TabIndex = 5;
            // 
            // txt_ricochetChance
            // 
            this.txt_ricochetChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_ricochetChance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ricochetChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ricochetChance.ForeColor = System.Drawing.Color.White;
            this.txt_ricochetChance.Location = new System.Drawing.Point(1, 382);
            this.txt_ricochetChance.Name = "txt_ricochetChance";
            this.txt_ricochetChance.Size = new System.Drawing.Size(237, 16);
            this.txt_ricochetChance.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 1);
            this.panel4.TabIndex = 5;
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
            this.cbox_caliberID.Location = new System.Drawing.Point(1, 465);
            this.cbox_caliberID.Name = "cbox_caliberID";
            this.cbox_caliberID.Size = new System.Drawing.Size(231, 28);
            this.cbox_caliberID.TabIndex = 6;
            this.cbox_caliberID.ValueMember = "CaliberID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 5;
            // 
            // txt_speed
            // 
            this.txt_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_speed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_speed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speed.ForeColor = System.Drawing.Color.White;
            this.txt_speed.Location = new System.Drawing.Point(3, 423);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(237, 16);
            this.txt_speed.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(2, 441);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(230, 1);
            this.panel11.TabIndex = 5;
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
            this.btn_add.TabIndex = 3;
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
            this.btn_delete.TabIndex = 4;
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
            this.btn_save.TabIndex = 5;
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
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormAmmunition
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
            this.Name = "FormAmmunition";
            this.Text = "Ammunition";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ammunition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caliberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammunitionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ammunition;
        private System.Windows.Forms.BindingSource ammunitionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource caliberBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbox_caliberID;
        private System.Windows.Forms.Label lbl_caliber;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_damage;
        private System.Windows.Forms.Label lbl_penetration;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_armourDamage;
        private System.Windows.Forms.TextBox txt_damage;
        private System.Windows.Forms.Label lbl_accuracy;
        private System.Windows.Forms.TextBox txt_penetration;
        private System.Windows.Forms.Label lbl_recoil;
        private System.Windows.Forms.TextBox txt_armourDamage;
        private System.Windows.Forms.Label lbl_fragmentationChance;
        private System.Windows.Forms.TextBox txt_accuracy;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_ricochetChance;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_recoil;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_fragmentationChance;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_ricochetChance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ammunitionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_penetration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_armourDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_recoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fragmentationChance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ricochetChance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_speed;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_caliberId;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_caliberName;
    }
}