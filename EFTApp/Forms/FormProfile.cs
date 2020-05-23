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
    public partial class FormProfile : Form
    {
        private FormMainMenu mainMenu;
        private User currentUser;

        public FormProfile()
        {
            InitializeComponent();
        }
        
        public FormProfile(Form callingForm, User user)
        {
            mainMenu = callingForm as FormMainMenu;
            currentUser = user;
            InitializeComponent();
            this.Text = user.Username;
            // Populate fields with current user passed to the form.
            lbl_usernameData.Text = user.Username;
            lbl_emailData.Text = user.Email;
        }

        // Check the name of the control, set the appropriate styling.
        private void FocusControl(Control control)
        {
            switch (control.Name)
            {
                case "txt_password":
                    txt_password.Clear();
                    txt_password.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_password.PasswordChar = '●';

                    txt_passwordRepeat.ForeColor = Color.White;
                    break;
                case "txt_passwordRepeat":
                    txt_passwordRepeat.Clear();
                    txt_passwordRepeat.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_passwordRepeat.PasswordChar = '●';

                    txt_password.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            mainMenu.Logout();
        }

        // Perform some validation on the fields then send an UPDATE query to the database with Entity Framework.
        // Send a message to the user with the result.
        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "" || txt_passwordRepeat.Text == "")
            {
                lbl_errorMessage.Text = "Password cannot be empty.";
                panel_error.Visible = true;
                return;
            }
            else if (txt_password.Text != txt_passwordRepeat.Text)
            {
                lbl_errorMessage.Text = "Passwords do not match.";
                panel_error.Visible = true;
                return;
            }
            using (EFTDBEntities context = new EFTDBEntities())
            {
                User user = new User()
                {
                    UserID = currentUser.UserID,
                    Username = currentUser.Username,
                    Password = txt_password.Text,
                    Email = currentUser.Email,
                    Admin = currentUser.Admin
                };

                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
            mainMenu.Logout("Password changed successfully, please log in.");
        }

        // Take the control clicked and send it to the FocusControl() function to be styled.
        private void txt_password_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_passwordRepeat_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        // Manage this event for using Tab to navigate fields.
        private void txt_password_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_passwordRepeat_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }
    }
}
