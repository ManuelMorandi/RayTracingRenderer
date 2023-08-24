using Domain;
using Services;
using Services.Controllers;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SignUpScreen : UserControl
    {
        public const string ScreenName = "SignUpScreen";
        private IRouter _router;
        private UserManager _userManager;

        public SignUpScreen(IRouter router, UserManager userManagement)
        {
            _router = router;
            _userManager = userManagement;
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (PasswordIsConfirmed())
            {
                try
                {
                    CreateUser();
                    LogIn(); 
                }
                catch (Exception ex)
                {
                    lblExceptions.Text = ex.Message;
                }
            }
            else
            {
                lblExceptions.Text = "Las contraseñas deben ser iguales";
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void CreateUser()
        {
            UserDTO user = new UserDTO(txtUsername.Text, txtPassword.Text);
            _userManager.AddUser(user);
        }

        private void LogIn()
        {
            _userManager.LogIn(txtUsername.Text, txtPassword.Text);
            _router.GoBack();
            _router.ShowScreen("FigureScreen");
        }

        private void ValidateUserName()
        {
            try
            {
                CheckUsernameValidity();
            }
            catch(Exception e)
            {
                lblExceptions.Text = e.Message;
            }
        }

        private void ValidatePassword()
        {
            try
            {
                CheckPasswordValidity();
            }
            catch (Exception e)
            {
                lblExceptions.Text = e.Message;
            }
        }

        public void CheckUsernameValidity()
        {
            _userManager.CheckNameValidity(txtUsername.Text);
            lblExceptions.Text = " ";
        }

        private void CheckPasswordValidity()
        {
            _userManager.CheckPasswordValidity(txtPassword.Text);
            lblExceptions.Text = " ";
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateUserName();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            ValidatePassword();
        }

        private bool PasswordIsConfirmed()
        {
            return txtPassword.Text.Equals(txtConfimPassword.Text);
        }
    }
}
