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
    public partial class FormAdmin : Form
    {
        private FormMainMenu mainMenu;
        private User currentUser;
        private int currentID;

        public FormAdmin()
        {
            InitializeComponent();
        }
        
        // Add a new constructor for passing in the main menu form and currently logged in user.
        public FormAdmin(Form callingForm, User user)
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
                context.Users.Load();
                // Bind the data to the DataSource.
                userBindingSource.DataSource = context.Users.Local.ToBindingList();
            }
        }

        // Check that the input data is of the correct format, if any data is found incorrect highlight it and notify the user.
        private bool ValidateData()
        {
            bool success = true;

            if (txt_username.Text == "")
            {
                lbl_username.ForeColor = Color.Red;
                success = false;
            }
            if (txt_email.Text == "")
            {
                lbl_email.ForeColor = Color.Red;
                success = false;
            }

            if (!success)
                MessageBox.Show("Unable to complete operation, check your input data.");

            return success;
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

        // Check if the user is sure about deleting, then get the itemID from the currentID and change the entity state to Deleted in the context.
        // When the changes are saved the database will delete the row using a standard DELETE query.
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to Delete {txt_username.Text}?", "SQL deletion operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User user = new User();
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    user = context.Users.Where(u => u.UserID == currentID).FirstOrDefault();
                    var entry = context.Entry(user);
                    if (entry.State == EntityState.Detached)
                    {
                        context.Users.Attach(user);
                    }
                    context.Users.Remove(user);
                    context.SaveChanges();
                    LoadData();
                }
                Clear();
            }
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }

        // If the data is valid, create a new instance of the appropriate entity and input the data. Change the entity state to Modified in the context
        // When the changes are saved the database will update the row using a standard UPDATE query.
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    User currentUser = context.Users.AsNoTracking().Where(cu => cu.UserID == currentID).FirstOrDefault();
                    User user = new User()
                    {
                        UserID = currentID,
                        Username = txt_username.Text,
                        Password = currentUser.Password,
                        Email = txt_email.Text,
                        Admin = chk_admin.Checked
                    };

                    context.Entry(user).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"Updated {user.Username} successfully!");
                }
                Clear();
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
            }
        }

        // Clear fields and Enable/Disable appropriate buttons.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }

        // When a row in the datagridview is clicked, check to make sure it's not the header then store the row's itemID in the currentID variable
        // Query the database to find the appropriate item and populate the fields with it's data. In the case of comboboxes match the Index with the name.
        private void dgv_weapons_DoubleClick(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if (dgv_users.CurrentRow.Index != -1)
            {
                User user = new User();
                currentID = Convert.ToInt32(dgv_users.CurrentRow.Cells["col_userID"].Value);
                Console.WriteLine(currentID.ToString());
                using (EFTDBEntities context = new EFTDBEntities())
                {
                    user = context.Users.Where(u => u.UserID == currentID).FirstOrDefault();

                    txt_username.Text = user.Username;
                    txt_email.Text = user.Email;
                    chk_admin.Checked = user.Admin;
                }
                btn_delete.Enabled = true;
            }
        }
    }
}
