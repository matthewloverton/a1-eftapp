using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EFTApp.Forms
{
    public partial class FormGear : Form
    {
        public FormGear()
        {
            InitializeComponent();
        }

        private FormMainMenu mainMenu;
        private User currentUser;
        private int currentID;
        public FormGear(Form callingForm, User user)
        {
            mainMenu = callingForm as FormMainMenu;
            currentUser = user;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (EFTDBEntities context = new EFTDBEntities())
            {
                context.Gears.Load();
                gearBindingSource.DataSource = context.Gears.Local.ToBindingList();
                dgv_gear.Columns["col_gearId"].Visible = false;
            }
        }

        private void Clear()
        {
            IEnumerable<TextBox> textBoxes = panel_edit.Controls.OfType<TextBox>();
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }

            IEnumerable<Label> labels = panel_edit.Controls.OfType<Label>();
            foreach (Label label in labels)
            {
                label.ForeColor = Color.White;
            }
        }

        private bool ValidateData()
        {
            bool success = true;
            if (txt_name.Text == "")
            {
                lbl_name.ForeColor = Color.Red;
                success = false;
            }
            if (!decimal.TryParse(txt_weight.Text, out decimal weight))
            {
                lbl_weight.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_durability.Text, out int durability))
            {
                lbl_durability.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_slots.Text, out int slots))
            {
                lbl_slots.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_movementSpeed.Text, out int movementSpeed))
            {
                lbl_movementSpeed.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_turnSpeed.Text, out int turnSpeed))
            {
                lbl_turnSpeed.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_ergonomics.Text, out int ergonomics))
            {
                lbl_ergonomics.ForeColor = Color.Red;
                success = false;
            }
            if (!float.TryParse(txt_ricochetChance.Text, out float ricochetChance))
            {
                lbl_ricochetChance.ForeColor = Color.Red;
                success = false;
            }

            if (!success)
                MessageBox.Show("Unable to complete operation, check your input data.");

            return success;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    Gear gear = new Gear()
                    {
                        Name = txt_name.Text,
                        Type = cbox_type.Text,
                        Slot = cbox_slot.Text,
                        Weight = decimal.Parse(txt_weight.Text),
                        Material = txt_material.Text,
                        Class = int.Parse(cbox_class.Text),
                        Durability = int.Parse(txt_durability.Text),
                        Slots = int.Parse(txt_slots.Text),
                        MovementSpeed = int.Parse(txt_movementSpeed.Text),
                        TurnSpeed = int.Parse(txt_turnSpeed.Text),
                        Ergonomics = int.Parse(txt_ergonomics.Text),
                        RicochetChance = float.Parse(txt_ricochetChance.Text),
                        SoundReduction = cbox_soundReduction.Text,
                        BlocksEarpiece = chk_blocksEarpiece.Checked,
                        BlocksEyewear = chk_blocksEyewear.Checked,
                        BlocksFaceCover = chk_blocksFaceCover.Checked,
                        BlocksHeadwear = chk_blocksHeadwear.Checked,
                        BlocksArmour = chk_blocksArmour.Checked
                    };

                    context.Gears.Add(gear);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Added {gear.Name} successfully!");
                }
                Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to Delete {txt_name.Text}?", "SQL deletion operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Gear gear = new Gear();
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    gear = context.Gears.Where(g => g.GearID == currentID).FirstOrDefault();
                    var entry = context.Entry(gear);
                    if (entry.State == EntityState.Detached)
                    {
                        context.Gears.Attach(gear);
                    }
                    context.Gears.Remove(gear);
                    context.SaveChanges();
                    LoadData();
                }
                Clear();
            }
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
            btn_add.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    Gear gear = new Gear()
                    {
                        GearID = currentID,
                        Name = txt_name.Text,
                        Type = cbox_type.Text,
                        Slot = cbox_slot.Text,
                        Weight = decimal.Parse(txt_weight.Text),
                        Material = txt_material.Text,
                        Class = int.Parse(cbox_class.Text),
                        Durability = int.Parse(txt_durability.Text),
                        Slots = int.Parse(txt_slots.Text),
                        MovementSpeed = int.Parse(txt_movementSpeed.Text),
                        TurnSpeed = int.Parse(txt_turnSpeed.Text),
                        Ergonomics = int.Parse(txt_ergonomics.Text),
                        RicochetChance = float.Parse(txt_ricochetChance.Text),
                        SoundReduction = cbox_soundReduction.Text,
                        BlocksEarpiece = chk_blocksEarpiece.Checked,
                        BlocksEyewear = chk_blocksEyewear.Checked,
                        BlocksFaceCover = chk_blocksFaceCover.Checked,
                        BlocksHeadwear = chk_blocksHeadwear.Checked,
                        BlocksArmour = chk_blocksArmour.Checked
                    };

                    context.Entry(gear).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Updated {gear.Name} successfully!");
                }
                Clear();
                btn_save.Enabled = false;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }

        private void dgv_ammunition_DoubleClick(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if (dgv_gear.CurrentRow.Index != -1)
            {
                Gear gear = new Gear();
                currentID = Convert.ToInt32(dgv_gear.CurrentRow.Cells["col_gearId"].Value);
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    gear = context.Gears.Where(g => g.GearID == currentID).FirstOrDefault();

                    txt_name.Text = gear.Name;
                    cbox_type.SelectedIndex = cbox_type.FindStringExact(gear.Type);
                    cbox_slot.SelectedIndex = cbox_slot.FindStringExact(gear.Slot);
                    txt_weight.Text = gear.Weight.ToString();
                    txt_material.Text = gear.Material;
                    cbox_class.SelectedIndex = cbox_class.FindStringExact(gear.Class.ToString());
                    txt_durability.Text = gear.Durability.ToString();
                    txt_slots.Text = gear.Slots.ToString();
                    txt_movementSpeed.Text = gear.MovementSpeed.ToString();
                    txt_turnSpeed.Text = gear.TurnSpeed.ToString();
                    txt_ergonomics.Text = gear.Ergonomics.ToString();
                    txt_ricochetChance.Text = gear.RicochetChance.ToString();
                    cbox_soundReduction.SelectedIndex = cbox_soundReduction.FindStringExact(gear.SoundReduction);
                    chk_blocksEarpiece.Checked = (bool)gear.BlocksEarpiece;
                    chk_blocksEyewear.Checked = (bool)gear.BlocksEyewear;
                    chk_blocksFaceCover.Checked = (bool)gear.BlocksFaceCover;
                    chk_blocksHeadwear.Checked = (bool)gear.BlocksHeadwear;
                    chk_blocksArmour.Checked = (bool)gear.BlocksArmour;
                }
                btn_delete.Enabled = true;
                btn_add.Enabled = false;
            }
        }
    }
}
