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
    public partial class FormAmmunition : Form
    {
        private FormMainMenu mainMenu;
        private User currentUser;
        private int currentID;

        public FormAmmunition()
        {
            InitializeComponent();
        }

        // Add a new constructor for passing in the main menu form and currently logged in user.
        public FormAmmunition(Form callingForm, User user)
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
                context.Ammunitions.Load();
                context.Calibers.Load();
                // Bind the data to the DataSource.
                ammunitionBindingSource.DataSource = context.Ammunitions.Local.ToBindingList();
                caliberBindingSource.DataSource = context.Calibers.Local.ToBindingList();
                // Manually hide columns (for some reason just setting the column.visible to false in the designer doesn't work).
                dgv_ammunition.Columns["col_ammunitionID"].Visible = false;
                dgv_ammunition.Columns["col_caliberId"].Visible = false;
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
            if (!int.TryParse(txt_damage.Text, out int damage))
            {
                lbl_damage.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_penetration.Text, out int penetration))
            {
                lbl_penetration.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_armourDamage.Text, out int armourDamage))
            {
                lbl_armourDamage.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_accuracy.Text, out int accuracy))
            {
                lbl_accuracy.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_recoil.Text, out int recoil))
            {
                lbl_recoil.ForeColor = Color.Red;
                success = false;
            }
            if (!decimal.TryParse(txt_fragmentationChance.Text, out decimal fragmentationChance))
            {
                lbl_fragmentationChance.ForeColor = Color.Red;
                success = false;
            }
            if (!decimal.TryParse(txt_ricochetChance.Text, out decimal ricochetChance))
            {
                lbl_ricochetChance.ForeColor = Color.Red;
                success = false;
            }
            if (!int.TryParse(txt_speed.Text, out int speed))
            {
                lbl_speed.ForeColor = Color.Red;
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
                    // Fetch the corresponding caliberID from the database by using a LINQ to Entity query, returning the first row or null.
                    int caliberID = context.Calibers.Where(c => c.Name == cbox_caliberID.Text).FirstOrDefault().CaliberID;
                    Ammunition ammunition = new Ammunition()
                    {
                        Name = txt_name.Text,
                        Damage = int.Parse(txt_damage.Text),
                        Penetration = int.Parse(txt_penetration.Text),
                        ArmourDamage = int.Parse(txt_armourDamage.Text),
                        Accuracy = int.Parse(txt_accuracy.Text),
                        Recoil = int.Parse(txt_recoil.Text),
                        FragmentationChance = decimal.Parse(txt_fragmentationChance.Text),
                        RicochetChance = decimal.Parse(txt_ricochetChance.Text),
                        Speed = int.Parse(txt_speed.Text),
                        CaliberID = caliberID
                    };

                    // Add the new entity to the context with the Added state.
                    context.Ammunitions.Add(ammunition);
                    // Save changes made to the context to the database.
                    context.SaveChanges();
                    // Reload the datasources.
                    LoadData();
                    MessageBox.Show($"Added {ammunition.Name} successfully!");
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
                Ammunition ammunition = new Ammunition();
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    ammunition = context.Ammunitions.Where(a => a.AmmunitionID == currentID).FirstOrDefault();
                    var entry = context.Entry(ammunition);
                    // Make sure the entity is being tracked by the context.
                    if (entry.State == EntityState.Detached)
                    {
                        context.Ammunitions.Attach(ammunition);
                    }
                    // Change the entities state to deleted. 
                    context.Ammunitions.Remove(ammunition);
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
                    Ammunition ammunition = new Ammunition()
                    {
                        AmmunitionID = currentID,
                        Name = txt_name.Text,
                        Damage = int.Parse(txt_damage.Text),
                        Penetration = int.Parse(txt_penetration.Text),
                        ArmourDamage = int.Parse(txt_armourDamage.Text),
                        Accuracy = int.Parse(txt_accuracy.Text),
                        Recoil = int.Parse(txt_recoil.Text),
                        FragmentationChance = decimal.Parse(txt_fragmentationChance.Text),
                        RicochetChance = decimal.Parse(txt_ricochetChance.Text),
                        Speed = int.Parse(txt_speed.Text),
                        CaliberID = caliberID
                    };

                    context.Entry(ammunition).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Updated {ammunition.Name} successfully!");
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
        private void dgv_ammunition_DoubleClick(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if(dgv_ammunition.CurrentRow.Index != -1)
            {
                Ammunition ammunition = new Ammunition();
                currentID = Convert.ToInt32(dgv_ammunition.CurrentRow.Cells["col_ammunitionID"].Value);
                using (EFTDBEntities context = new EFTDBEntities())
                { 
                    ammunition = context.Ammunitions.Where(a => a.AmmunitionID == currentID).FirstOrDefault();
                    string caliberName = context.Calibers.Where(c => c.CaliberID == ammunition.CaliberID).FirstOrDefault().Name;

                    txt_name.Text = ammunition.Name;
                    txt_damage.Text = ammunition.Damage.ToString();
                    txt_penetration.Text = ammunition.Penetration.ToString();
                    txt_armourDamage.Text = ammunition.ArmourDamage.ToString();
                    txt_accuracy.Text = ammunition.Accuracy.ToString();
                    txt_recoil.Text = ammunition.Recoil.ToString();
                    txt_fragmentationChance.Text = ammunition.FragmentationChance.ToString();
                    txt_ricochetChance.Text = ammunition.RicochetChance.ToString();
                    txt_speed.Text = ammunition.Speed.ToString();
                    cbox_caliberID.SelectedIndex = cbox_caliberID.FindStringExact(caliberName);
                }
                btn_delete.Enabled = true;
                btn_add.Enabled = false;
            }
        }
    }
}
