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
    public partial class FormLogin : Form
    {
        private FormMainMenu mainMenu = null;

        public FormLogin()
        {
            InitializeComponent();
        }
        
        public FormLogin(Form callingForm, string message = "")
        {
            mainMenu = callingForm as FormMainMenu;
            InitializeComponent();
            // If a message is sent when opening the form, display it.
            if (message != "")
            {
                lbl_errorMessage.Text = message;
                panel_error.Visible = true;
            }
        }

        // Check the name of the control, set the appropriate styling.
        private void FocusControl(Control control)
        {
            switch (control.Name)
            {
                case "txt_username":
                    txt_username.Clear();
                    txt_username.ForeColor = FormMainMenu.RGBColors.peach;
                    icon_username.ForeColor = FormMainMenu.RGBColors.peach;

                    icon_password.ForeColor = Color.White;
                    txt_password.ForeColor = Color.White;
                    break;
                case "txt_password":
                    txt_password.Clear();
                    txt_password.ForeColor = FormMainMenu.RGBColors.peach;
                    icon_password.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_password.PasswordChar = '●';

                    txt_username.ForeColor = Color.White;
                    icon_username.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        // Take the control clicked and send it to the FocusControl() function to be styled.
        private void txt_username_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        // Manage this event for using Tab to navigate fields.
        private void txt_username_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        // Check if the user is already in the database and if the passwords match. Show errors if appropriate.
        private void btn_login_Click(object sender, EventArgs e)
        {
            using (EFTDBEntities context = new EFTDBEntities())
            {
                User user = context.Users.Where(u => u.Username == txt_username.Text).FirstOrDefault<User>();
                if (user == null)
                {
                    lbl_errorMessage.Text = "User not found.";
                    panel_error.Visible = true;

                    return;
                }
                else if (txt_password.Text != user.Password)
                {
                    lbl_errorMessage.Text = "Incorrect username or password.";
                    panel_error.Visible = true;

                    return;
                }
                else
                {
                    // Call the login function on the main menu form.
                    mainMenu.Login(user);
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            mainMenu.ShowRegister();
        }
    }
}
