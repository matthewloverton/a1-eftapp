namespace EFTApp.Forms
{
    partial class FormGear
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.cbox_slot = new System.Windows.Forms.ComboBox();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.cbox_soundReduction = new System.Windows.Forms.ComboBox();
            this.cbox_class = new System.Windows.Forms.ComboBox();
            this.chk_blocksArmour = new System.Windows.Forms.CheckBox();
            this.chk_blocksFaceCover = new System.Windows.Forms.CheckBox();
            this.chk_blocksHeadwear = new System.Windows.Forms.CheckBox();
            this.chk_blocksEyewear = new System.Windows.Forms.CheckBox();
            this.chk_blocksEarpiece = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_ergonomics = new System.Windows.Forms.Label();
            this.lbl_ricochetChance = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_soundReduction = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_ergonomics = new System.Windows.Forms.TextBox();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_ricochetChance = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_material = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lbl_slots = new System.Windows.Forms.Label();
            this.lbl_durability = new System.Windows.Forms.Label();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.lbl_turnSpeed = new System.Windows.Forms.Label();
            this.lbl_movementSpeed = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_slots = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_durability = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_turnSpeed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_movementSpeed = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgv_gear = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.col_gearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_durability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_slots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_movementSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_turnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ergonomics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ricochetChance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soundReduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blocksEarpiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blocksEyewear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blocksFaceCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blocksHeadwear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blocksArmour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_edit);
            this.panel1.Controls.Add(this.dgv_gear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 600);
            this.panel1.TabIndex = 2;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panel_edit.Controls.Add(this.cbox_slot);
            this.panel_edit.Controls.Add(this.cbox_type);
            this.panel_edit.Controls.Add(this.cbox_soundReduction);
            this.panel_edit.Controls.Add(this.cbox_class);
            this.panel_edit.Controls.Add(this.chk_blocksArmour);
            this.panel_edit.Controls.Add(this.chk_blocksFaceCover);
            this.panel_edit.Controls.Add(this.chk_blocksHeadwear);
            this.panel_edit.Controls.Add(this.chk_blocksEyewear);
            this.panel_edit.Controls.Add(this.chk_blocksEarpiece);
            this.panel_edit.Controls.Add(this.label11);
            this.panel_edit.Controls.Add(this.lbl_ergonomics);
            this.panel_edit.Controls.Add(this.lbl_ricochetChance);
            this.panel_edit.Controls.Add(this.lbl_name);
            this.panel_edit.Controls.Add(this.lbl_soundReduction);
            this.panel_edit.Controls.Add(this.lbl_type);
            this.panel_edit.Controls.Add(this.txt_ergonomics);
            this.panel_edit.Controls.Add(this.lbl_slot);
            this.panel_edit.Controls.Add(this.txt_name);
            this.panel_edit.Controls.Add(this.txt_ricochetChance);
            this.panel_edit.Controls.Add(this.lbl_weight);
            this.panel_edit.Controls.Add(this.lbl_material);
            this.panel_edit.Controls.Add(this.txt_weight);
            this.panel_edit.Controls.Add(this.lbl_class);
            this.panel_edit.Controls.Add(this.panel21);
            this.panel_edit.Controls.Add(this.panel10);
            this.panel_edit.Controls.Add(this.panel20);
            this.panel_edit.Controls.Add(this.lbl_slots);
            this.panel_edit.Controls.Add(this.lbl_durability);
            this.panel_edit.Controls.Add(this.txt_material);
            this.panel_edit.Controls.Add(this.lbl_turnSpeed);
            this.panel_edit.Controls.Add(this.lbl_movementSpeed);
            this.panel_edit.Controls.Add(this.panel6);
            this.panel_edit.Controls.Add(this.txt_slots);
            this.panel_edit.Controls.Add(this.panel5);
            this.panel_edit.Controls.Add(this.txt_durability);
            this.panel_edit.Controls.Add(this.panel4);
            this.panel_edit.Controls.Add(this.txt_turnSpeed);
            this.panel_edit.Controls.Add(this.panel2);
            this.panel_edit.Controls.Add(this.panel3);
            this.panel_edit.Controls.Add(this.txt_movementSpeed);
            this.panel_edit.Controls.Add(this.panel11);
            this.panel_edit.Location = new System.Drawing.Point(666, 24);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(384, 552);
            this.panel_edit.TabIndex = 0;
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
            "Earpiece",
            "Headwear",
            "Body armour",
            "Chest rig",
            "Backpack"});
            this.cbox_slot.Location = new System.Drawing.Point(0, 170);
            this.cbox_slot.Name = "cbox_slot";
            this.cbox_slot.Size = new System.Drawing.Size(172, 27);
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
            "Armored chest rig",
            "Armor vest",
            "Backpack",
            "Chest rig",
            "Headset",
            "Helmet"});
            this.cbox_type.Location = new System.Drawing.Point(0, 127);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(172, 27);
            this.cbox_type.TabIndex = 1;
            // 
            // cbox_soundReduction
            // 
            this.cbox_soundReduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_soundReduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_soundReduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_soundReduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_soundReduction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_soundReduction.ForeColor = System.Drawing.Color.White;
            this.cbox_soundReduction.FormattingEnabled = true;
            this.cbox_soundReduction.Items.AddRange(new object[] {
            "None",
            "Low",
            "Medium",
            "High"});
            this.cbox_soundReduction.Location = new System.Drawing.Point(205, 170);
            this.cbox_soundReduction.Name = "cbox_soundReduction";
            this.cbox_soundReduction.Size = new System.Drawing.Size(172, 27);
            this.cbox_soundReduction.TabIndex = 12;
            // 
            // cbox_class
            // 
            this.cbox_class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.cbox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_class.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_class.ForeColor = System.Drawing.Color.White;
            this.cbox_class.FormattingEnabled = true;
            this.cbox_class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbox_class.Location = new System.Drawing.Point(0, 299);
            this.cbox_class.Name = "cbox_class";
            this.cbox_class.Size = new System.Drawing.Size(172, 27);
            this.cbox_class.TabIndex = 5;
            // 
            // chk_blocksArmour
            // 
            this.chk_blocksArmour.AutoSize = true;
            this.chk_blocksArmour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_blocksArmour.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_blocksArmour.ForeColor = System.Drawing.Color.White;
            this.chk_blocksArmour.Location = new System.Drawing.Point(205, 294);
            this.chk_blocksArmour.Name = "chk_blocksArmour";
            this.chk_blocksArmour.Size = new System.Drawing.Size(116, 23);
            this.chk_blocksArmour.TabIndex = 17;
            this.chk_blocksArmour.Text = "Blocks Armour";
            this.chk_blocksArmour.UseVisualStyleBackColor = true;
            // 
            // chk_blocksFaceCover
            // 
            this.chk_blocksFaceCover.AutoSize = true;
            this.chk_blocksFaceCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_blocksFaceCover.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_blocksFaceCover.ForeColor = System.Drawing.Color.White;
            this.chk_blocksFaceCover.Location = new System.Drawing.Point(205, 248);
            this.chk_blocksFaceCover.Name = "chk_blocksFaceCover";
            this.chk_blocksFaceCover.Size = new System.Drawing.Size(137, 23);
            this.chk_blocksFaceCover.TabIndex = 15;
            this.chk_blocksFaceCover.Text = "Blocks Face Cover";
            this.chk_blocksFaceCover.UseVisualStyleBackColor = true;
            // 
            // chk_blocksHeadwear
            // 
            this.chk_blocksHeadwear.AutoSize = true;
            this.chk_blocksHeadwear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_blocksHeadwear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_blocksHeadwear.ForeColor = System.Drawing.Color.White;
            this.chk_blocksHeadwear.Location = new System.Drawing.Point(205, 271);
            this.chk_blocksHeadwear.Name = "chk_blocksHeadwear";
            this.chk_blocksHeadwear.Size = new System.Drawing.Size(130, 23);
            this.chk_blocksHeadwear.TabIndex = 16;
            this.chk_blocksHeadwear.Text = "Blocks Headwear";
            this.chk_blocksHeadwear.UseVisualStyleBackColor = true;
            // 
            // chk_blocksEyewear
            // 
            this.chk_blocksEyewear.AutoSize = true;
            this.chk_blocksEyewear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_blocksEyewear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_blocksEyewear.ForeColor = System.Drawing.Color.White;
            this.chk_blocksEyewear.Location = new System.Drawing.Point(205, 225);
            this.chk_blocksEyewear.Name = "chk_blocksEyewear";
            this.chk_blocksEyewear.Size = new System.Drawing.Size(119, 23);
            this.chk_blocksEyewear.TabIndex = 14;
            this.chk_blocksEyewear.Text = "Blocks Eyewear";
            this.chk_blocksEyewear.UseVisualStyleBackColor = true;
            // 
            // chk_blocksEarpiece
            // 
            this.chk_blocksEarpiece.AutoSize = true;
            this.chk_blocksEarpiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_blocksEarpiece.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_blocksEarpiece.ForeColor = System.Drawing.Color.White;
            this.chk_blocksEarpiece.Location = new System.Drawing.Point(205, 202);
            this.chk_blocksEarpiece.Name = "chk_blocksEarpiece";
            this.chk_blocksEarpiece.Size = new System.Drawing.Size(120, 23);
            this.chk_blocksEarpiece.TabIndex = 13;
            this.chk_blocksEarpiece.Text = "Blocks Earpiece";
            this.chk_blocksEarpiece.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(136, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Add / Edit";
            // 
            // lbl_ergonomics
            // 
            this.lbl_ergonomics.AutoSize = true;
            this.lbl_ergonomics.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ergonomics.ForeColor = System.Drawing.Color.White;
            this.lbl_ergonomics.Location = new System.Drawing.Point(201, 68);
            this.lbl_ergonomics.Name = "lbl_ergonomics";
            this.lbl_ergonomics.Size = new System.Drawing.Size(81, 19);
            this.lbl_ergonomics.TabIndex = 7;
            this.lbl_ergonomics.Text = "Ergonomics";
            // 
            // lbl_ricochetChance
            // 
            this.lbl_ricochetChance.AutoSize = true;
            this.lbl_ricochetChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ricochetChance.ForeColor = System.Drawing.Color.White;
            this.lbl_ricochetChance.Location = new System.Drawing.Point(201, 109);
            this.lbl_ricochetChance.Name = "lbl_ricochetChance";
            this.lbl_ricochetChance.Size = new System.Drawing.Size(112, 19);
            this.lbl_ricochetChance.TabIndex = 7;
            this.lbl_ricochetChance.Text = "Ricochet Chance";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(-4, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 19);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_soundReduction
            // 
            this.lbl_soundReduction.AutoSize = true;
            this.lbl_soundReduction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soundReduction.ForeColor = System.Drawing.Color.White;
            this.lbl_soundReduction.Location = new System.Drawing.Point(201, 151);
            this.lbl_soundReduction.Name = "lbl_soundReduction";
            this.lbl_soundReduction.Size = new System.Drawing.Size(115, 19);
            this.lbl_soundReduction.TabIndex = 7;
            this.lbl_soundReduction.Text = "Sound Reduction";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.White;
            this.lbl_type.Location = new System.Drawing.Point(-4, 109);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(38, 19);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "Type";
            // 
            // txt_ergonomics
            // 
            this.txt_ergonomics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_ergonomics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ergonomics.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ergonomics.ForeColor = System.Drawing.Color.White;
            this.txt_ergonomics.Location = new System.Drawing.Point(206, 89);
            this.txt_ergonomics.Name = "txt_ergonomics";
            this.txt_ergonomics.Size = new System.Drawing.Size(169, 16);
            this.txt_ergonomics.TabIndex = 10;
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot.ForeColor = System.Drawing.Color.White;
            this.lbl_slot.Location = new System.Drawing.Point(-4, 151);
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
            this.txt_name.Location = new System.Drawing.Point(1, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 16);
            this.txt_name.TabIndex = 0;
            // 
            // txt_ricochetChance
            // 
            this.txt_ricochetChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_ricochetChance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ricochetChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ricochetChance.ForeColor = System.Drawing.Color.White;
            this.txt_ricochetChance.Location = new System.Drawing.Point(206, 130);
            this.txt_ricochetChance.Name = "txt_ricochetChance";
            this.txt_ricochetChance.Size = new System.Drawing.Size(169, 16);
            this.txt_ricochetChance.TabIndex = 11;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.ForeColor = System.Drawing.Color.White;
            this.lbl_weight.Location = new System.Drawing.Point(-4, 196);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(53, 19);
            this.lbl_weight.TabIndex = 7;
            this.lbl_weight.Text = "Weight";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_material.ForeColor = System.Drawing.Color.White;
            this.lbl_material.Location = new System.Drawing.Point(-4, 239);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(59, 19);
            this.lbl_material.TabIndex = 7;
            this.lbl_material.Text = "Material";
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.ForeColor = System.Drawing.Color.White;
            this.txt_weight.Location = new System.Drawing.Point(1, 217);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(169, 16);
            this.txt_weight.TabIndex = 3;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.White;
            this.lbl_class.Location = new System.Drawing.Point(-4, 281);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(91, 19);
            this.lbl_class.TabIndex = 7;
            this.lbl_class.Text = "Armour Class";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Location = new System.Drawing.Point(205, 107);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(170, 1);
            this.panel21.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(0, 107);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(170, 1);
            this.panel10.TabIndex = 5;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.Location = new System.Drawing.Point(205, 148);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(170, 1);
            this.panel20.TabIndex = 5;
            // 
            // lbl_slots
            // 
            this.lbl_slots.AutoSize = true;
            this.lbl_slots.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slots.ForeColor = System.Drawing.Color.White;
            this.lbl_slots.Location = new System.Drawing.Point(-4, 366);
            this.lbl_slots.Name = "lbl_slots";
            this.lbl_slots.Size = new System.Drawing.Size(39, 19);
            this.lbl_slots.TabIndex = 7;
            this.lbl_slots.Text = "Slots";
            // 
            // lbl_durability
            // 
            this.lbl_durability.AutoSize = true;
            this.lbl_durability.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durability.ForeColor = System.Drawing.Color.White;
            this.lbl_durability.Location = new System.Drawing.Point(-4, 324);
            this.lbl_durability.Name = "lbl_durability";
            this.lbl_durability.Size = new System.Drawing.Size(68, 19);
            this.lbl_durability.TabIndex = 7;
            this.lbl_durability.Text = "Durability";
            // 
            // txt_material
            // 
            this.txt_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_material.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_material.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_material.ForeColor = System.Drawing.Color.White;
            this.txt_material.Location = new System.Drawing.Point(1, 259);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(169, 16);
            this.txt_material.TabIndex = 4;
            // 
            // lbl_turnSpeed
            // 
            this.lbl_turnSpeed.AutoSize = true;
            this.lbl_turnSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turnSpeed.ForeColor = System.Drawing.Color.White;
            this.lbl_turnSpeed.Location = new System.Drawing.Point(-3, 447);
            this.lbl_turnSpeed.Name = "lbl_turnSpeed";
            this.lbl_turnSpeed.Size = new System.Drawing.Size(79, 19);
            this.lbl_turnSpeed.TabIndex = 7;
            this.lbl_turnSpeed.Text = "Turn Speed";
            // 
            // lbl_movementSpeed
            // 
            this.lbl_movementSpeed.AutoSize = true;
            this.lbl_movementSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movementSpeed.ForeColor = System.Drawing.Color.White;
            this.lbl_movementSpeed.Location = new System.Drawing.Point(-4, 406);
            this.lbl_movementSpeed.Name = "lbl_movementSpeed";
            this.lbl_movementSpeed.Size = new System.Drawing.Size(118, 19);
            this.lbl_movementSpeed.TabIndex = 7;
            this.lbl_movementSpeed.Text = "Movement Speed";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 1);
            this.panel6.TabIndex = 5;
            // 
            // txt_slots
            // 
            this.txt_slots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_slots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_slots.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slots.ForeColor = System.Drawing.Color.White;
            this.txt_slots.Location = new System.Drawing.Point(1, 386);
            this.txt_slots.Name = "txt_slots";
            this.txt_slots.Size = new System.Drawing.Size(169, 16);
            this.txt_slots.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 277);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 1);
            this.panel5.TabIndex = 5;
            // 
            // txt_durability
            // 
            this.txt_durability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_durability.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_durability.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_durability.ForeColor = System.Drawing.Color.White;
            this.txt_durability.Location = new System.Drawing.Point(1, 344);
            this.txt_durability.Name = "txt_durability";
            this.txt_durability.Size = new System.Drawing.Size(169, 16);
            this.txt_durability.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 5;
            // 
            // txt_turnSpeed
            // 
            this.txt_turnSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_turnSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_turnSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_turnSpeed.ForeColor = System.Drawing.Color.White;
            this.txt_turnSpeed.Location = new System.Drawing.Point(2, 467);
            this.txt_turnSpeed.Name = "txt_turnSpeed";
            this.txt_turnSpeed.Size = new System.Drawing.Size(168, 16);
            this.txt_turnSpeed.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 5;
            // 
            // txt_movementSpeed
            // 
            this.txt_movementSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.txt_movementSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_movementSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_movementSpeed.ForeColor = System.Drawing.Color.White;
            this.txt_movementSpeed.Location = new System.Drawing.Point(3, 426);
            this.txt_movementSpeed.Name = "txt_movementSpeed";
            this.txt_movementSpeed.Size = new System.Drawing.Size(167, 16);
            this.txt_movementSpeed.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(2, 444);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(170, 1);
            this.panel11.TabIndex = 5;
            // 
            // dgv_gear
            // 
            this.dgv_gear.AllowUserToAddRows = false;
            this.dgv_gear.AllowUserToDeleteRows = false;
            this.dgv_gear.AutoGenerateColumns = false;
            this.dgv_gear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.dgv_gear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_gear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_gearId,
            this.col_name,
            this.col_type,
            this.col_slot,
            this.col_weight,
            this.col_material,
            this.col_class,
            this.col_durability,
            this.col_slots,
            this.col_movementSpeed,
            this.col_turnSpeed,
            this.col_Ergonomics,
            this.col_ricochetChance,
            this.col_soundReduction,
            this.col_blocksEarpiece,
            this.col_blocksEyewear,
            this.col_blocksFaceCover,
            this.col_blocksHeadwear,
            this.col_blocksArmour});
            this.dgv_gear.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_gear.DataSource = this.gearBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_gear.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_gear.Location = new System.Drawing.Point(12, 24);
            this.dgv_gear.MultiSelect = false;
            this.dgv_gear.Name = "dgv_gear";
            this.dgv_gear.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gear.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_gear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gear.ShowCellErrors = false;
            this.dgv_gear.ShowCellToolTips = false;
            this.dgv_gear.ShowEditingIcon = false;
            this.dgv_gear.ShowRowErrors = false;
            this.dgv_gear.Size = new System.Drawing.Size(644, 552);
            this.dgv_gear.TabIndex = 0;
            this.dgv_gear.DoubleClick += new System.EventHandler(this.dgv_ammunition_DoubleClick);
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
            // col_gearId
            // 
            this.col_gearId.DataPropertyName = "GearID";
            this.col_gearId.HeaderText = "GearID";
            this.col_gearId.Name = "col_gearId";
            this.col_gearId.ReadOnly = true;
            this.col_gearId.Visible = false;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "Name";
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_type
            // 
            this.col_type.DataPropertyName = "Type";
            this.col_type.HeaderText = "Type";
            this.col_type.Name = "col_type";
            this.col_type.ReadOnly = true;
            // 
            // col_slot
            // 
            this.col_slot.DataPropertyName = "Slot";
            this.col_slot.HeaderText = "Slot";
            this.col_slot.Name = "col_slot";
            this.col_slot.ReadOnly = true;
            // 
            // col_weight
            // 
            this.col_weight.DataPropertyName = "Weight";
            this.col_weight.HeaderText = "Weight";
            this.col_weight.Name = "col_weight";
            this.col_weight.ReadOnly = true;
            // 
            // col_material
            // 
            this.col_material.DataPropertyName = "Material";
            this.col_material.HeaderText = "Material";
            this.col_material.Name = "col_material";
            this.col_material.ReadOnly = true;
            // 
            // col_class
            // 
            this.col_class.DataPropertyName = "Class";
            this.col_class.HeaderText = "Class";
            this.col_class.Name = "col_class";
            this.col_class.ReadOnly = true;
            // 
            // col_durability
            // 
            this.col_durability.DataPropertyName = "Durability";
            this.col_durability.HeaderText = "Durability";
            this.col_durability.Name = "col_durability";
            this.col_durability.ReadOnly = true;
            // 
            // col_slots
            // 
            this.col_slots.DataPropertyName = "Slots";
            this.col_slots.HeaderText = "Slots";
            this.col_slots.Name = "col_slots";
            this.col_slots.ReadOnly = true;
            // 
            // col_movementSpeed
            // 
            this.col_movementSpeed.DataPropertyName = "MovementSpeed";
            this.col_movementSpeed.HeaderText = "Movement Speed";
            this.col_movementSpeed.Name = "col_movementSpeed";
            this.col_movementSpeed.ReadOnly = true;
            this.col_movementSpeed.Width = 180;
            // 
            // col_turnSpeed
            // 
            this.col_turnSpeed.DataPropertyName = "TurnSpeed";
            this.col_turnSpeed.HeaderText = "Turn Speed";
            this.col_turnSpeed.Name = "col_turnSpeed";
            this.col_turnSpeed.ReadOnly = true;
            this.col_turnSpeed.Width = 160;
            // 
            // col_Ergonomics
            // 
            this.col_Ergonomics.DataPropertyName = "Ergonomics";
            this.col_Ergonomics.HeaderText = "Ergonomics";
            this.col_Ergonomics.Name = "col_Ergonomics";
            this.col_Ergonomics.ReadOnly = true;
            // 
            // col_ricochetChance
            // 
            this.col_ricochetChance.DataPropertyName = "RicochetChance";
            this.col_ricochetChance.HeaderText = "Ricochet Chance";
            this.col_ricochetChance.Name = "col_ricochetChance";
            this.col_ricochetChance.ReadOnly = true;
            this.col_ricochetChance.Width = 180;
            // 
            // col_soundReduction
            // 
            this.col_soundReduction.DataPropertyName = "SoundReduction";
            this.col_soundReduction.HeaderText = "Sound Reduction";
            this.col_soundReduction.Name = "col_soundReduction";
            this.col_soundReduction.ReadOnly = true;
            this.col_soundReduction.Width = 180;
            // 
            // col_blocksEarpiece
            // 
            this.col_blocksEarpiece.DataPropertyName = "BlocksEarpiece";
            this.col_blocksEarpiece.HeaderText = "Blocks Earpiece";
            this.col_blocksEarpiece.Name = "col_blocksEarpiece";
            this.col_blocksEarpiece.ReadOnly = true;
            this.col_blocksEarpiece.Width = 180;
            // 
            // col_blocksEyewear
            // 
            this.col_blocksEyewear.DataPropertyName = "BlocksEyewear";
            this.col_blocksEyewear.HeaderText = "Blocks Eyewear";
            this.col_blocksEyewear.Name = "col_blocksEyewear";
            this.col_blocksEyewear.ReadOnly = true;
            this.col_blocksEyewear.Width = 180;
            // 
            // col_blocksFaceCover
            // 
            this.col_blocksFaceCover.DataPropertyName = "BlocksFaceCover";
            this.col_blocksFaceCover.HeaderText = "Blocks Face Cover";
            this.col_blocksFaceCover.Name = "col_blocksFaceCover";
            this.col_blocksFaceCover.ReadOnly = true;
            this.col_blocksFaceCover.Width = 180;
            // 
            // col_blocksHeadwear
            // 
            this.col_blocksHeadwear.DataPropertyName = "BlocksHeadwear";
            this.col_blocksHeadwear.HeaderText = "Blocks Headwear";
            this.col_blocksHeadwear.Name = "col_blocksHeadwear";
            this.col_blocksHeadwear.ReadOnly = true;
            this.col_blocksHeadwear.Width = 180;
            // 
            // col_blocksArmour
            // 
            this.col_blocksArmour.DataPropertyName = "BlocksArmour";
            this.col_blocksArmour.HeaderText = "Blocks Armour";
            this.col_blocksArmour.Name = "col_blocksArmour";
            this.col_blocksArmour.ReadOnly = true;
            this.col_blocksArmour.Width = 180;
            // 
            // gearBindingSource
            // 
            this.gearBindingSource.DataSource = typeof(EFTApp.Gear);
            // 
            // FormGear
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
            this.Name = "FormGear";
            this.Text = "Gear";
            this.panel1.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gearBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_material;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_durability;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.Label lbl_movementSpeed;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_durability;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_movementSpeed;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgv_gear;
        private System.Windows.Forms.Label lbl_turnSpeed;
        private System.Windows.Forms.TextBox txt_turnSpeed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckBox chk_blocksArmour;
        private System.Windows.Forms.CheckBox chk_blocksFaceCover;
        private System.Windows.Forms.CheckBox chk_blocksHeadwear;
        private System.Windows.Forms.CheckBox chk_blocksEyewear;
        private System.Windows.Forms.CheckBox chk_blocksEarpiece;
        private System.Windows.Forms.Label lbl_ergonomics;
        private System.Windows.Forms.Label lbl_ricochetChance;
        private System.Windows.Forms.Label lbl_soundReduction;
        private System.Windows.Forms.TextBox txt_ergonomics;
        private System.Windows.Forms.TextBox txt_ricochetChance;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ComboBox cbox_class;
        private System.Windows.Forms.ComboBox cbox_slot;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.ComboBox cbox_soundReduction;
        private System.Windows.Forms.Label lbl_slots;
        private System.Windows.Forms.TextBox txt_slots;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_durability;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_slots;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_movementSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_turnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ergonomics;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ricochetChance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soundReduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blocksEarpiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blocksEyewear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blocksFaceCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blocksHeadwear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blocksArmour;
    }
}