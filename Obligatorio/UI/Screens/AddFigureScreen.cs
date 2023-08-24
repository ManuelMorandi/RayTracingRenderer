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
    public partial class AddFigureScreen : UserControl
    {
        public const string ScreenName = "AddFigureScreen";
        private IRouter _router;
        private UserManager _userManager;
        private SphereManager _sphereManager;

        public AddFigureScreen(IRouter router, UserManager um, SphereManager sm )
        {
            _router = router;
            _userManager = um;
            _sphereManager = sm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
        }

        private void BtnCloseTab_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void BtnSaveFigure_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFigureName.Text;
                double radius = Convert.ToDouble(txtFigureRadius.Text);
                string username = _userManager.GetActiveUserName();
                SphereDTO shape = new SphereDTO(name, radius, username);
                AddSphere(shape);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSphere(SphereDTO shape)
        {
            _sphereManager.CreateSphere(shape);
            _router.ShowScreen("FigureScreen");
        }
    }
}
