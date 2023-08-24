using Services;
using UI.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Controllers;

namespace UI
{
    public partial class Menu : UserControl
    {

        private IRouter _router;
        private UserManager _userManager;
        
        public Menu(IRouter router, UserManager um)
        {
            _router = router;
            _userManager = um;
            InitializeComponent();
            lblUserName.Text = _userManager.GetActiveUserName();
            imgUser.Image = Properties.Resources.User;
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            _userManager.LogOut();
            _router.ShowScreen(LogInScreen.ScreenName);
        }

        private void BtnFigure_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(FigureScreen.ScreenName);
        }

        private void BtnMaterial_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(MaterialScreen.ScreenName);
        }

        private void BtnModel_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(ModelScreen.ScreenName);
        }

        private void btnScene_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(SceneScreen.ScreenName);
        }
    }
}
