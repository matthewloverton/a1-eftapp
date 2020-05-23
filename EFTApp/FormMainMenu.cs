using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFTApp.Forms;
using FontAwesome.Sharp;

namespace EFTApp
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool loggedIn;
        private User currentUser;

        // Create a struct to hold commonly used colours.
        public struct RGBColors
        {
            // UI Colors
            public static Color highlight = Color.FromArgb(46, 46, 102);
            public static Color bright = Color.FromArgb(82, 199, 242);
            public static Color normal = Color.FromArgb(32, 32, 72);
            public static Color dark = Color.FromArgb(26, 26, 64);

            // Other Colors
            public static Color pink = Color.FromArgb(249, 88, 155);
            public static Color blue = Color.FromArgb(24, 161, 251);
            public static Color peach = Color.FromArgb(253, 138, 114);
            public static Color lilac = Color.FromArgb(172, 126, 241);
            public static Color green = Color.FromArgb(138, 253, 114);
            public static Color yellow = Color.FromArgb(232, 212, 120);
        }

        public FormMainMenu()
        {
            InitializeComponent();
            loggedIn = false;
            // Create a panel to act as an 'active selection' for the buttons.
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 78);
            panel_menu.Controls.Add(leftBorderBtn);
        }

        // Importing some OS DLLs to allow custom form dragging.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Disable the current button, set the current button to the new button and apply styles.
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.highlight;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Form
                icon_currentForm.IconChar = currentBtn.IconChar;
                icon_currentForm.IconColor = color;
            }
        }

        // Remove styles from button.
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.normal;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Close the currently open form and open the form passed inside the desktop panel after styling.
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_titleCurrentForm.Text = childForm.Text;
        }

        // Disable all buttons and set the close the currently open child form.
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_currentForm.IconChar = IconChar.Home;
            icon_currentForm.IconColor = RGBColors.lilac;
            lbl_titleCurrentForm.Text = "Home";
        }

        // Set the login state to true, reveal appropriate buttons/controls and open the profile form.
        public void Login(User user)
        {
            loggedIn = true;
            currentUser = user;
            btn_logout.Visible = true;
            if (user.Admin)
            {
                btn_admin.Visible = true;
            }
            btn_loadout.Visible = true;
            btn_gear.Visible = true;
            btn_ammunition.Visible = true;
            btn_weapons.Visible = true;

            btn_login.Text = user.Username;

            ActivateButton(btn_login, RGBColors.peach);
            // Send an instance of the main menu form so I can access public variables and methods.
            // send the currentUser accross to populate the fields on the form.
            OpenChildForm(new FormProfile(this, currentUser));
        }

        // Set the login state to false and clear the current user, hide appropriate buttons/controls.
        public void Logout(string message = "Logged out successfully.")
        {
            currentUser = null;
            loggedIn = false;
            btn_logout.Visible = false;
            btn_admin.Visible = false;
            btn_loadout.Visible = false;
            btn_gear.Visible = false;
            btn_ammunition.Visible = false;
            btn_weapons.Visible = false;

            btn_login.Text = "Login/Register";

            ActivateButton(btn_login, RGBColors.peach);
            OpenChildForm(new FormLogin(this, message));
        }

        // Open the login form and pass a message accross to be displayed.
        public void Register()
        { 
            ActivateButton(btn_login, RGBColors.peach);
            OpenChildForm(new FormLogin(this, "Registered new user successfully, please log in."));
        }

        public void ShowLogin()
        {
            OpenChildForm(new FormLogin(this));
        }

        public void ShowRegister()
        {
            OpenChildForm(new FormRegister(this));
        }

        // Open the login or profile form depending on the login state.
        private void btn_login_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.peach);
            if (loggedIn)
            {
                OpenChildForm(new FormProfile(this, currentUser));
            }
            else
            {
                OpenChildForm(new FormLogin(this));
            }
        }

        // Open the appropriate forms and activate the buttons with differing colours.
        private void btn_weapons_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.lilac);
            OpenChildForm(new FormWeapons(this, currentUser));
        }

        private void btn_gear_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.pink);
            OpenChildForm(new Forms.FormGear(this, currentUser));
        }

        private void btn_ammunition_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.yellow);
            OpenChildForm(new FormAmmunition(this, currentUser));
        }

        private void btn_loadout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.blue);
            OpenChildForm(new FormLoadout(this, currentUser));
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.green);
            OpenChildForm(new FormAdmin(this, currentUser));
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        // When you click and drag the top bar use the DLLs imported earlier.
        private void panel_titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Exit the application when the X is clicked.
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
