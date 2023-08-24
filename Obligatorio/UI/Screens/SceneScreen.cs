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
using UI.Components;

namespace UI.Screens
{
    public partial class SceneScreen : UserControl
    {
        public const string ScreenName = "SceneScreen";
        private IRouter _router;
        private RenderLogic _renderLogic;
        private SceneManager _sceneManager;
        private UserManager _userManager;

        public SceneScreen(IRouter router, RenderLogic renderLogic, SceneManager sm, UserManager um)
        {
            _router = router;
            _renderLogic = renderLogic;
            _sceneManager = sm;
            _userManager = um;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
            pnlList.Controls.AddRange(_sceneManager.GetUsersScenes(_userManager.GetActiveUserName())
                            .Select(scene => new SceneList(_router, scene.Name, scene.GetDescription(), _renderLogic, sm, um)).ToArray());
        }

        private void btnAddScene_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(AddSceneScreen.ScreenName);
        }
    }
}
