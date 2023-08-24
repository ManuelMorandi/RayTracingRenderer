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

namespace UI.Screens
{
    public partial class AddSceneScreen : UserControl
    {
        public const string ScreenName = "AddSceneScreen";
        private IRouter _router;
        private UserManager _userManager;
        private SceneManager _sceneManager;

        public AddSceneScreen(IRouter router, UserManager um, SceneManager sm)
        {
            _router = router;
            _userManager = um;
            _sceneManager = sm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
        }

        private void BtnCloseTab_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void BtnSaveScene_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtSceneName.Text;
                string username = _userManager.GetActiveUserName();
                SceneDTO scene = new SceneDTO(username, name);
                AddScene(scene);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddScene(SceneDTO scene)
        {
            _sceneManager.AddScene(scene);
            _router.ShowScreen(SceneScreen.ScreenName);
        }
    }
}
