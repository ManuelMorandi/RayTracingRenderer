using Services;
using Services.Controllers;
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
    public partial class LogInScreen : UserControl
    {
        public const string ScreenName = "LogInScreen";
        private IRouter _router;
        private UserManager _userManager;

        public LogInScreen(IRouter router, UserManager userManagement)
        {
            _router = router;
            _userManager = userManagement;
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            _router.ShowScreen("SignUpScreen");
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LogIn();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void LogIn()
        {
            _userManager.LogIn(txtUsername.Text, txtPassword.Text);
            _router.ShowScreen("FigureScreen");
        }
    }
}
