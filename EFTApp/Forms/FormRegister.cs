using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTApp.Forms
{
    public partial class FormRegister : Form
    {
        private FormMainMenu mainMenu;

        public FormRegister()
        {
            InitializeComponent();
        }
        
        public FormRegister(Form callingForm)
        {
            mainMenu = callingForm as FormMainMenu;
            InitializeComponent();
        }

        // Check the name of the control, set the appropriate styling.
        private void FocusControl(Control control)
        {
            switch (control.Name)
            {
                case "txt_username":
                    txt_username.Clear();
                    icon_username.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_username.ForeColor = FormMainMenu.RGBColors.peach;

                    icon_password.ForeColor = Color.White;
                    txt_password.ForeColor = Color.White;
                    icon_passwordRepeat.ForeColor = Color.White;
                    txt_passwordRepeat.ForeColor = Color.White;
                    icon_email.ForeColor = Color.White;
                    txt_email.ForeColor = Color.White;
                    break;
                case "txt_password":
                    txt_password.Clear();
                    txt_password.PasswordChar = '●';
                    icon_password.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_password.ForeColor = FormMainMenu.RGBColors.peach;

                    icon_username.ForeColor = Color.White;
                    txt_username.ForeColor = Color.White;
                    icon_passwordRepeat.ForeColor = Color.White;
                    txt_passwordRepeat.ForeColor = Color.White;
                    icon_email.ForeColor = Color.White;
                    txt_email.ForeColor = Color.White;
                    break;
                case "txt_passwordRepeat":
                    txt_passwordRepeat.Clear();
                    txt_passwordRepeat.PasswordChar = '●';
                    icon_passwordRepeat.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_passwordRepeat.ForeColor = FormMainMenu.RGBColors.peach;

                    icon_username.ForeColor = Color.White;
                    txt_username.ForeColor = Color.White;
                    icon_password.ForeColor = Color.White;
                    txt_password.ForeColor = Color.White;
                    icon_email.ForeColor = Color.White;
                    txt_email.ForeColor = Color.White;
                    break;
                case "txt_email":
                    txt_email.Clear();
                    icon_email.ForeColor = FormMainMenu.RGBColors.peach;
                    txt_email.ForeColor = FormMainMenu.RGBColors.peach;

                    icon_username.ForeColor = Color.White;
                    txt_username.ForeColor = Color.White;
                    icon_password.ForeColor = Color.White;
                    txt_password.ForeColor = Color.White;
                    icon_passwordRepeat.ForeColor = Color.White;
                    txt_passwordRepeat.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            mainMenu.ShowLogin();
        }

        // Perform some validation, check the database for a user with the same username.
        // If validation succeeds add the new user to the database using an INSERT query from Entity Framework.
        private void btn_register_Click(object sender, EventArgs e)
        {
            using (EFTDBEntities context = new EFTDBEntities())
            {
                
                if (txt_username.Text == "Username" || txt_username.Text == "" || 
                    txt_password.Text == "Password" || txt_password.Text == "Password" ||
                    txt_passwordRepeat.Text == "Password Repeat" || txt_passwordRepeat.Text == "" ||
                    txt_email.Text == "Email" || txt_email.Text == "")
                {
                    lbl_errorMessage.Text = "Please make sure all fields are filled.";
                    panel_error.Visible = true;

                    return;
                }

                User user = context.Users.Where(u => u.Username == txt_username.Text).FirstOrDefault<User>();
                if (user != null)
                {
                    lbl_errorMessage.Text = "There's already an account with that username. Try logging in.";
                    panel_error.Visible = true;

                    return;
                }
                else if (txt_password.Text != txt_passwordRepeat.Text)
                {
                    lbl_errorMessage.Text = "Passwords do not match.";
                    panel_error.Visible = true;

                    return;
                }
                else
                {
                    User newUser = new User()
                    {
                        Username = txt_username.Text,
                        Password = txt_password.Text,
                        Email = txt_email.Text,
                        Admin = false
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }
            }
            mainMenu.Register();
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

        private void txt_passwordRepeat_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_passwordRepeat_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            FocusControl((Control)sender);
        }
    }
}
