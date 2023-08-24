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
using UI.Screens;

namespace UI.Components
{
    public partial class SceneList : UserControl
    {
        private string _name;
        private string _description;
        private IRouter _router;
        private RenderLogic _renderLogic;
        private SceneManager _sceneManager;
        private UserManager _userManager;

        public SceneList(IRouter router, string name, string description, RenderLogic renderLogic, SceneManager sm, UserManager um)
        {
            _router = router;
            _name = name;
            _description = description;
            _renderLogic = renderLogic;
            _sceneManager = sm;
            _userManager = um;
            InitializeComponent();
            lblElementName.Text = name;
            lblElementInfo.Text = description;
            ShowScenePreview(name);
        }

        private void BtnDeleteElement_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteScene();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteScene()
        {
            _sceneManager.DeleteScene(_name, _userManager.GetActiveUserName());
            _router.ShowScreen(SceneScreen.ScreenName);
        }

        private void ShowScenePreview(string name)
        {
            string preview = _sceneManager.GetScenePreview(name, _userManager.GetActiveUserName());
            bool thereIsNoPreviewAvailable = preview.Equals("null");
            if (thereIsNoPreviewAvailable)
            {
                ShowNoAvailablePreview();
            }
            else
            {
                ShowPreviewImage(preview);
            }
        }

        private void ShowPreviewImage(string preview)
        {
            imgPreview.Image = _renderLogic.ShowImage(preview);
        }

        private void ShowNoAvailablePreview()
        {
            imgPreview.Image = Properties.Resources.NoPreview;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _sceneManager.ActiveScene = _sceneManager.GetScene(lblElementName.Text, _userManager.ActiveUser.UserName);
            _router.ShowScreen(EditSceneScreen.ScreenName);
        }
    }
}
