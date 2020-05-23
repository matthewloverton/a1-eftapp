using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTApp.Forms
{
    public partial class FormWeapons : Form
    {
        private FormMainMenu mainMenu;
        private User currentUser;
        private int currentID;

        public FormWeapons()
        {
            InitializeComponent();
        }
        
        // Add a new constructor for passing in the main menu form and currently logged in user.
        public FormWeapons(Form callingForm, User user)
        {
            mainMenu = callingForm as FormMainMenu;
            currentUser = user;
            InitializeComponent();
            LoadData();
        }

        // Load the data into the DbContext and bind it to the appropriate dataSources for use in the datagridview and comboboxes.
        private void LoadData()
        {
            using (EFTDBEntities context = new EFTDBEntities())
            {
                // Query the appropriate tables and store the results in the DBContext.
                context.Weapons.Load();
                context.Calibers.Load();
                // Bind the data to the DataSource.
                weaponBindingSource.DataSource = context.Weapons.Local.ToBindingList();
                caliberBindingSource.DataSource = context.Calibers.Local.ToBindingList();
                // Manually hide columns (for some reason just setting the column.visible to false in the designer doesn't work).
                dgv_weapons.Columns["col_weaponID"].Visible = false;
                dgv_weapons.Columns["col_caliberId"].Visible = false;
            }
        }

        // Iterate over all of the controls and reset them.
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

        // Check that the input data is of the correct format, if any data is found incorrect highlight it and notify the user.
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
            if (!int.TryParse(txt_verticalRecoil.Text, out int penetration))
            {
                lbl_verticalRecoil.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_horizontalRecoil.Text, out int armourDamage))
            {
                lbl_horizontalRecoil.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_range.Text, out int accuracy))
            {
                lbl_range.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_ergonomics.Text, out int recoil))
            {
                lbl_ergonomics.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_fireRate.Text, out int speed))
            {
                lbl_fireRate.ForeColor = Color.Red;
                success = false;
            }

            if (!success)
                MessageBox.Show("Unable to complete operation, check your input data.");

            return success;
        }

        // If the data is valid create a new instance of the DBContext and add the entity.
        // When the changes are saved the database will insert the row using a standard INSERT query.
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    int caliberID = context.Calibers.Where(c => c.Name == cbox_caliberID.Text).FirstOrDefault().CaliberID;
                    Weapon weapon = new Weapon()
                    {
                        Name = txt_name.Text,
                        Type = cbox_type.Text,
                        Slot = cbox_slot.Text,
                        Weight = decimal.Parse(txt_weight.Text),
                        VerticalRecoil = int.Parse(txt_verticalRecoil.Text),
                        HorizontalRecoil = int.Parse(txt_horizontalRecoil.Text),
                        Range = int.Parse(txt_range.Text),
                        Ergonomics = int.Parse(txt_ergonomics.Text),
                        FireRate = int.Parse(txt_fireRate.Text),
                        Single = chk_single.Checked,
                        Burst = chk_burst.Checked,
                        Auto = chk_auto.Checked,
                        CaliberID = caliberID
                    };
                    // Add the new entity to the context with the Added state.
                    context.Weapons.Add(weapon);
                    // Save changes made to the context to the database.
                    context.SaveChanges();
                    // Reload the datasources.
                    LoadData();
                    MessageBox.Show($"Added {weapon.Name} successfully!");
                }
                Clear();
            }
        }

        // Check if the user is sure about deleting, then get the itemID from the currentID and change the entity state to Deleted in the context.
        // When the changes are saved the database will delete the row using a standard DELETE query.
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to Delete {txt_name.Text}?", "SQL deletion operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Weapon weapon = new Weapon();
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    weapon = context.Weapons.Where(w => w.WeaponID == currentID).FirstOrDefault();
                    var entry = context.Entry(weapon);
                    // Make sure the entity is being tracked by the context.
                    if (entry.State == EntityState.Detached)
                    {
                        context.Weapons.Attach(weapon);
                    }
                    // Change the entities state to deleted. 
                    context.Weapons.Remove(weapon);
                    // Save changes made to the context (removing the deleted entity) to the database.
                    context.SaveChanges();
                    // Reload the datasources.
                    LoadData();
                }
                Clear();
            }
            // Enable/Disable appropriate buttons.
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
            btn_add.Enabled = true;
        }

        // If the data is valid, create a new instance of the appropriate entity and input the data. Change the entity state to Modified in the context
        // When the changes are saved the database will update the row using a standard UPDATE query.
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    int caliberID = context.Calibers.Where(c => c.Name == cbox_caliberID.Text).FirstOrDefault().CaliberID;
                    Weapon weapon = new Weapon()
                    {
                        WeaponID = currentID,
                        Name = txt_name.Text,
                        Type = cbox_type.Text,
                        Slot = cbox_slot.Text,
                        Weight = decimal.Parse(txt_weight.Text),
                        VerticalRecoil = int.Parse(txt_verticalRecoil.Text),
                        HorizontalRecoil = int.Parse(txt_horizontalRecoil.Text),
                        Range = int.Parse(txt_range.Text),
                        Ergonomics = int.Parse(txt_ergonomics.Text),
                        FireRate = int.Parse(txt_fireRate.Text),
                        Single = chk_single.Checked,
                        Burst = chk_burst.Checked,
                        Auto = chk_auto.Checked,
                        CaliberID = caliberID
                    };

                    context.Entry(weapon).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Updated {weapon.Name} successfully!");
                }
                Clear();
                btn_save.Enabled = false;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        // Clear fields and Enable/Disable appropriate buttons.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }

        // When a row in the datagridview is clicked, check to make sure it's not the header then store the row's itemID in the currentID variable
        // Query the database to find the appropriate item and populate the fields with it's data. In the case of comboboxes match the Index with the name.
        private void dgv_weapons_DoubleClick(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if (dgv_weapons.CurrentRow.Index != -1)
            {
                Weapon weapon = new Weapon();
                currentID = Convert.ToInt32(dgv_weapons.CurrentRow.Cells["col_weaponID"].Value);
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    weapon = context.Weapons.Where(w => w.WeaponID == currentID).FirstOrDefault();
                    string caliberName = context.Calibers.Where(c => c.CaliberID == weapon.CaliberID).FirstOrDefault().Name;

                    txt_name.Text = weapon.Name;
                    cbox_type.SelectedIndex = cbox_type.FindStringExact(weapon.Type);
                    cbox_slot.SelectedIndex = cbox_slot.FindStringExact(weapon.Slot);
                    txt_weight.Text = weapon.Weight.ToString();
                    txt_verticalRecoil.Text = weapon.VerticalRecoil.ToString();
                    txt_horizontalRecoil.Text = weapon.HorizontalRecoil.ToString();
                    txt_range.Text = weapon.Range.ToString();
                    txt_ergonomics.Text = weapon.Ergonomics.ToString();
                    txt_fireRate.Text = weapon.FireRate.ToString();                  
                    chk_single.Checked = (bool)weapon.Single;
                    chk_burst.Checked = (bool)weapon.Burst;
                    chk_auto.Checked = (bool)weapon.Auto;
                    cbox_caliberID.SelectedIndex = cbox_caliberID.FindStringExact(caliberName);
                }
                btn_delete.Enabled = true;
                btn_add.Enabled = false;
            }
        }
    }
}
