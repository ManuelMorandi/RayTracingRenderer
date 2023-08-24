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

namespace UI.Screens
{
    public partial class ModelScreen : UserControl
    {
        public const string ScreenName = "ModelScreen";
        private IRouter _router;
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private ModelManager _modelManager;

        public ModelScreen(IRouter router, RenderLogic renderLogic, UserManager ur, ModelManager mm)
        {
            _router = router;
            _renderLogic = renderLogic;
            _userManager = ur;
            _modelManager = mm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
            pnlList.Controls.AddRange(_modelManager.GetUsersModels(_userManager.GetActiveUserName())
                .Select(model => new ListElement(_router, model.Name, model.GetDescription(), "Model", _renderLogic, _userManager, null, null, _modelManager)).ToArray());
        }

        private void BtnAddModel_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(AddModelScreen.ScreenName);
        }
    }
}
