using Domain;
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
    public partial class PositionedModelElement : UserControl
    {
        IRouter _router;
        UsedModel _model;
        RenderLogic _renderLogic;
        SceneManager _sceneManager;

        public PositionedModelElement(IRouter router, UsedModel model, RenderLogic renderLogic, SceneManager sm)
        {
            _model = model;
            _router = router;
            _renderLogic = renderLogic;
            _sceneManager = sm;
            InitializeComponent();
            lblName.Text = _model.SelectedModel.Name;
            lblPosition.Text = _model.Place.ToString();
            ShowModelPreview(_model.SelectedModel);
        }

        private void ShowModelPreview(Model model)
        {
            bool thereIsNoPreviewAvailable = model.Preview.Equals("null");
            if (thereIsNoPreviewAvailable)
            {
                ShowNoAvailablePreview();
            }
            else
            {
                ShowPreviewImage(model.Preview);
            }
        }

        private void ShowNoAvailablePreview()
        {
            imgPreview.Image = Properties.Resources.NoPreview;
        }

        private void ShowPreviewImage(string preview)
        {
            imgPreview.Image = _renderLogic.ShowImage(preview);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteModel(_model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteModel(UsedModel model)
        {
            _sceneManager.DeleteUsedModel(model);
            _sceneManager.ActiveSceneUpdated();
            _router.ShowScreen(EditSceneScreen.ScreenName);
        }
    }
}
