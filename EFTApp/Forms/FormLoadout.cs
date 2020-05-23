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
    public partial class FormLoadout : Form
    {
        private FormMainMenu mainMenu;
        private User currentUser;
        private int currentID;

        public FormLoadout()
        {
            InitializeComponent();
        }
                
        // Add a new constructor for passing in the main menu form and currently logged in user.
        public FormLoadout(Form callingForm, User user)
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
                context.Gears.Load();
                context.Weapons.Load();
                context.Loadouts.Load();

                // Bind the data to the DataSource.
                loadoutBindingSource.DataSource = context.Loadouts.Where(l => l.UserID == currentUser.UserID).ToList();
                gearBindingSource.DataSource = context.Gears.Local.ToBindingList();
                weaponBindingSource.DataSource = context.Weapons.Local.ToBindingList();

                // Create new datasources for each loadoout slot, use lambda expressions to query the database and save the rows that match.
                BindingSource backpacks = new BindingSource();
                backpacks.DataSource = context.Gears.Where(b => b.Slot == "Backpack").ToList();
                // Attach the datasource to the correct combobox. The combobox DisplayMember is set to display the Item.Name.
                cbox_backpack.DataSource = backpacks;

                BindingSource bodyArmour = new BindingSource();
                bodyArmour.DataSource = context.Gears.Where(ba => ba.Slot == "Body armour").ToList();
                cbox_bodyArmour.DataSource = bodyArmour;

                BindingSource earpiece = new BindingSource();
                earpiece.DataSource = context.Gears.Where(e => e.Slot == "Earpiece").ToList();
                cbox_earpiece.DataSource = earpiece;

                BindingSource chestRig = new BindingSource();
                chestRig.DataSource = context.Gears.Where(cr => cr.Slot == "Chest rig").ToList();
                cbox_rig.DataSource = chestRig;

                BindingSource headwear = new BindingSource();
                headwear.DataSource = context.Gears.Where(h => h.Slot == "Headwear").ToList();
                cbox_headwear.DataSource = headwear;

                BindingSource primaryWeapon = new BindingSource();
                primaryWeapon.DataSource = context.Weapons.Where(pw => pw.Slot == "Primary").ToList();
                cbox_primaryWeapon.DataSource = primaryWeapon;

                BindingSource secondaryWeapon = new BindingSource();
                secondaryWeapon.DataSource = context.Weapons.Where(sw => sw.Slot == "Primary").ToList();
                cbox_secondaryWeapon.DataSource = secondaryWeapon;

                BindingSource holsterWeapon = new BindingSource();
                holsterWeapon.DataSource = context.Weapons.Where(hw => hw.Slot == "Secondary").ToList();
                cbox_holsterWeapon.DataSource = holsterWeapon;

                dgv_loadouts.Columns["col_loadoutID"].Visible = false;
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
                    Loadout loadout = new Loadout()
                    {
                        Name = txt_name.Text,
                        UserID = currentUser.UserID,
                        // Get the ID of the appropriate gear using a lambda expression LINQ to Entity query.
                        EarpieceID = context.Gears.Where(earpiece => earpiece.Name == cbox_earpiece.Text).FirstOrDefault().GearID,
                        HeadwearID = context.Gears.Where(headwear => headwear.Name == cbox_headwear.Text).FirstOrDefault().GearID,
                        BodyArmourID = context.Gears.Where(bodyArmour => bodyArmour.Name == cbox_bodyArmour.Text).FirstOrDefault().GearID,
                        PrimaryWeaponID = context.Weapons.Where(primaryWeapon => primaryWeapon.Name == cbox_primaryWeapon.Text).FirstOrDefault().WeaponID,
                        SecondaryWeaponID = context.Weapons.Where(secondaryWeapon => secondaryWeapon.Name == cbox_secondaryWeapon.Text).FirstOrDefault().WeaponID,
                        HolsterWeaponID = context.Weapons.Where(holsterWeapon => holsterWeapon.Name == cbox_holsterWeapon.Text).FirstOrDefault().WeaponID,
                        RigID = context.Gears.Where(rig => rig.Name == cbox_rig.Text).FirstOrDefault().GearID,
                        BackpackID = context.Gears.Where(backpack => backpack.Name == cbox_backpack.Text).FirstOrDefault().GearID
                    };
                    context.Loadouts.Add(loadout);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Loadout '{loadout.Name}' added successfully!");
                }
            }
        }

        // Check if the user is sure about deleting, then get the itemID from the currentID and change the entity state to Deleted in the context.
        // When the changes are saved the database will delete the row using a standard DELETE query.
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to Delete {txt_name.Text}?", "SQL deletion operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Loadout loadout = new Loadout();
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    loadout = context.Loadouts.Where(l => l.LoadoutID == currentID).FirstOrDefault();
                    var entry = context.Entry(loadout);
                    // Make sure the entity is being tracked by the context.
                    if (entry.State == EntityState.Detached)
                    {
                        context.Loadouts.Attach(loadout);
                    }
                    // Change the entities state to deleted. 
                    context.Loadouts.Remove(loadout);
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
                    Loadout loadout = new Loadout()
                    {
                        LoadoutID = currentID,
                        Name = txt_name.Text,
                        UserID = currentUser.UserID,
                        EarpieceID = context.Gears.Where(earpiece => earpiece.Name == cbox_earpiece.Text).FirstOrDefault().GearID,
                        HeadwearID = context.Gears.Where(headwear => headwear.Name == cbox_headwear.Text).FirstOrDefault().GearID,
                        BodyArmourID = context.Gears.Where(bodyArmour => bodyArmour.Name == cbox_bodyArmour.Text).FirstOrDefault().GearID,
                        PrimaryWeaponID = context.Weapons.Where(primaryWeapon => primaryWeapon.Name == cbox_primaryWeapon.Text).FirstOrDefault().WeaponID,
                        SecondaryWeaponID = context.Weapons.Where(secondaryWeapon => secondaryWeapon.Name == cbox_secondaryWeapon.Text).FirstOrDefault().WeaponID,
                        HolsterWeaponID = context.Weapons.Where(holsterWeapon => holsterWeapon.Name == cbox_holsterWeapon.Text).FirstOrDefault().WeaponID,
                        RigID = context.Gears.Where(rig => rig.Name == cbox_rig.Text).FirstOrDefault().GearID,
                        BackpackID = context.Gears.Where(backpack => backpack.Name == cbox_backpack.Text).FirstOrDefault().GearID,
                    };

                    context.Entry(loadout).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Updated {loadout.Name} successfully!");
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
            if (dgv_loadouts.CurrentRow.Index != -1)
            {
                Loadout loadout = new Loadout();
                currentID = Convert.ToInt32(dgv_loadouts.CurrentRow.Cells["col_loadoutID"].Value);
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    loadout = context.Loadouts.Where(l => l.LoadoutID == currentID).FirstOrDefault();

                    txt_name.Text = loadout.Name;
                    // Search the database for the row with the corresponding ItemID, find the combobox index which matches the name of the Item.
                    cbox_earpiece.SelectedIndex = cbox_earpiece.FindStringExact(context.Gears.Where(earpiece => earpiece.GearID == loadout.EarpieceID).FirstOrDefault().Name);
                    cbox_headwear.SelectedIndex = cbox_headwear.FindStringExact(context.Gears.Where(headwear => headwear.GearID == loadout.HeadwearID).FirstOrDefault().Name);
                    cbox_bodyArmour.SelectedIndex = cbox_bodyArmour.FindStringExact(context.Gears.Where(bodyArmour => bodyArmour.GearID == loadout.BodyArmourID).FirstOrDefault().Name);
                    cbox_primaryWeapon.SelectedIndex = cbox_primaryWeapon.FindStringExact(context.Weapons.Where(primaryWeapon => primaryWeapon.WeaponID == loadout.PrimaryWeaponID).FirstOrDefault().Name);
                    cbox_secondaryWeapon.SelectedIndex = cbox_secondaryWeapon.FindStringExact(context.Weapons.Where(secondaryWeapon => secondaryWeapon.WeaponID == loadout.SecondaryWeaponID).FirstOrDefault().Name);
                    cbox_holsterWeapon.SelectedIndex = cbox_holsterWeapon.FindStringExact(context.Weapons.Where(holsterWeapon => holsterWeapon.WeaponID == loadout.HolsterWeaponID).FirstOrDefault().Name);
                    cbox_rig.SelectedIndex = cbox_rig.FindStringExact(context.Gears.Where(rig => rig.GearID == loadout.RigID).FirstOrDefault().Name);
                    cbox_backpack.SelectedIndex = cbox_backpack.FindStringExact(context.Gears.Where(backpack => backpack.GearID == loadout.BackpackID).FirstOrDefault().Name);
                }
                btn_delete.Enabled = true;
                btn_add.Enabled = false;
            }
        }
    }
}
