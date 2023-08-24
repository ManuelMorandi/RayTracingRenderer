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
    public partial class FigureScreen : UserControl
    {
        public const string ScreenName = "FigureScreen";
        private IRouter _router;
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private SphereManager _sphereManager;

        public FigureScreen(IRouter router, RenderLogic renderLogic, UserManager um, SphereManager sphereManagement)
        {
            _router = router;
            _renderLogic = renderLogic;
            _userManager = um;
            _sphereManager = sphereManagement;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
            pnlList.Controls.AddRange(_sphereManager.GetUsersSpheres(_userManager.GetActiveUserName())
                .Select(shape => new ListElement(_router, shape.Name, shape.GetDescription(), "Shape", _renderLogic, _userManager, _sphereManager, null, null)).ToArray());
        }

        private void BtnAddFigure_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(AddFigureScreen.ScreenName);
        }
    }
}
