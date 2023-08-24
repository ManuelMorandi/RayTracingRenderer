using Services;
using Services.Controllers;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Components;

namespace UI.Screens
{
    public partial class EditSceneScreen : UserControl
    {
        public const string ScreenName = "EditSceneScreen";
        private IRouter _router;
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private ModelManager _modelManager;
        private SceneManager _sceneManager;
        private VectorManager _vectorManager;

        public EditSceneScreen(IRouter router, RenderLogic renderLogic, UserManager um, ModelManager mm, SceneManager sm, VectorManager vm)
        {
            _router = router;
            _renderLogic = renderLogic;
            _userManager = um;
            _modelManager = mm;
            _sceneManager = sm;
            _vectorManager = vm;
            InitializeComponent();
            SetSceneInfo();
            btnPPM.Checked = true;
            pnlMenu.Controls.Add(new Menu(router, _userManager));
            pnlAvailableModels.Controls.AddRange(_modelManager.GetUsersModels(um.GetActiveUserName()).Select(model => new AvailableModelElement(model, _renderLogic)).ToArray());
            pnlPositionedModels.Controls.AddRange(_sceneManager.GetActiveSceneModels().Select(model => new PositionedModelElement(_router, model, _renderLogic, _sceneManager)).ToArray());
        }

        private void SetSceneInfo()
        {
            lblName.Text = _sceneManager.ActiveScene.Name;
            lblLastModification.Text = "Última modificación: " + _sceneManager.ActiveScene.LastModificationDate;
            txtLookFrom.Text = _sceneManager.ActiveScene.LookFrom.X + " " + _sceneManager.ActiveScene.LookFrom.Y + " " + _sceneManager.ActiveScene.LookFrom.Z;
            txtLookAt.Text = _sceneManager.ActiveScene.LookAt.X + " " + _sceneManager.ActiveScene.LookAt.Y + " " + _sceneManager.ActiveScene.LookAt.Z;
            txtFov.Text = _sceneManager.ActiveScene.Fov.ToString();
            txtAperture.Text = _sceneManager.ActiveScene.Aperture.ToString();
            chkBlur.Checked = _sceneManager.ActiveScene.Blurred;
            bool sceneHasARender = !_sceneManager.ActiveScene.Render.Equals("null");
            if (sceneHasARender)
                imgRender.Image = _renderLogic.ShowImage(_sceneManager.ActiveScene.Render);
            bool sceneHasBeenRendered = !_sceneManager.ActiveScene.LastRenderDate.Equals(_sceneManager.ActiveScene.CreationDate);
            if (sceneHasBeenRendered)
                lblLastRender.Text = "Última renderización: " + _sceneManager.ActiveScene.LastRenderDate;
            bool renderIsOutdated = _sceneManager.ActiveScene.LastModificationDate > _sceneManager.ActiveScene.LastRenderDate;
            if (renderIsOutdated)
                lblOutdatedRender.Text = "ATENCIÓN: El render está desactualizado";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _router.GoBack();
            _router.ShowScreen(SceneScreen.ScreenName);
        }

        private void BtnRender_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCameraValues();
                const int xResolution = 300;
                const int yResolution = 200;
                var vectorDTO = new VectorDTO(0, 1, 0);
                var defaultUp = _vectorManager.CreateVector(vectorDTO);
                _sceneManager.ActiveScene.Models = _sceneManager.GetActiveSceneModels();
                RendererDTO rendererDTO = new RendererDTO(xResolution, yResolution, defaultUp, _sceneManager.ActiveScene);
                var renderer = _renderLogic.CreateRenderer(rendererDTO);
                _renderLogic.SetSceneRenderer(renderer, _sceneManager.ActiveScene);
                imgRender.Image = _renderLogic.ShowImage(_sceneManager.ActiveScene.Render);
                _sceneManager.ActiveSceneRendered();
                lblLastRender.Text = "Último renderizado: " + _sceneManager.ActiveScene.LastRenderDate;
                lblOutdatedRender.Text = " ";
                const int xPreviewResolution = 111;
                const int yPreviewResolution = 74;
                rendererDTO = new RendererDTO(xPreviewResolution, yPreviewResolution, defaultUp, _sceneManager.ActiveScene);
                renderer = _renderLogic.CreateRenderer(rendererDTO);
                _renderLogic.SetScenePreview(renderer, _sceneManager.ActiveScene);
                UpdateCameraValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPlaceModel_Click(object sender, EventArgs e)
        {
            _router.ShowScreen(PositionElementScreen.ScreenName);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCameraValues();
                _sceneManager.ActiveSceneUpdated();
                lblOutdatedRender.Text = "ATENCIÓN: El render está desactualizado";
                _router.GoBack();
                _router.ShowScreen(EditSceneScreen.ScreenName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCameraValues()
        {
            string[] lookFromValues = txtLookFrom.Text.Split(' ');
            var vectorDTO1 = new VectorDTO(Convert.ToDouble(lookFromValues[0]), Convert.ToDouble(lookFromValues[1]), Convert.ToDouble(lookFromValues[2]));
            var lookFrom = _vectorManager.CreateVector(vectorDTO1);
            string[] lookAtValues = txtLookAt.Text.Split(' ');
            var vectorDTO2 = new VectorDTO(Convert.ToDouble(lookAtValues[0]), Convert.ToDouble(lookAtValues[1]), Convert.ToDouble(lookAtValues[2]));
            var lookAt = _vectorManager.CreateVector(vectorDTO2);
            int fov = Convert.ToInt32(txtFov.Text);
            double aperture = Convert.ToDouble(txtAperture.Text);
            bool blurred = chkBlur.Checked;
            var name = _sceneManager.ActiveScene.Name;
            var owner = _sceneManager.ActiveScene.Owner.UserName;
            var renderDate = _sceneManager.ActiveScene.LastRenderDate;
            var render = _sceneManager.ActiveScene.Render;
            var preview = _sceneManager.ActiveScene.Preview;
            UpdateSceneDTO dto = new UpdateSceneDTO(name, owner, renderDate, lookFrom, lookAt, fov, render, preview, aperture, blurred);
            _sceneManager.UpdateScene(dto);
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directory = GetDirectory();
            bool pathIsEmpty = directory.SelectedPath != "";
            if (pathIsEmpty)
            {
                SaveImage(directory);
            }
        }

        private FolderBrowserDialog GetDirectory()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                return fbd;
            }
        }

        private void SaveImage(FolderBrowserDialog directory)
        {
            var image = _sceneManager.ActiveScene.Render;
            var renderDoesntExist = image.Equals("null");
            if (renderDoesntExist)
            {
                MessageBox.Show("Debe renderizar la escena para poder descargar la foto");
            }
            else
            {
                Bitmap imageBitmap = _renderLogic.ShowImage(image);
                bool JPGCheck = btnJPG.Checked;
                if (JPGCheck) 
                    SaveJPG(directory, image);
                bool PNGChecked = btnPNG.Checked;
                if (PNGChecked)
                    SavePNG(directory, image);
                bool PPMChecked = btnPPM.Checked;
                if (PPMChecked)
                    SavePPM(directory, image);
                MessageBox.Show("El renderizado ha sido guardado");
            }
        }

        private void SaveJPG(FolderBrowserDialog directory, string imagePPM)
        {
            Bitmap imageBitmap = _renderLogic.ShowImage(imagePPM);
            imageBitmap.Save(directory.SelectedPath + "/" + _sceneManager.ActiveScene.Name + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void SavePNG(FolderBrowserDialog directory, string imagePPM)
        {
            Bitmap imageBitmap = _renderLogic.ShowImage(imagePPM);
            imageBitmap.Save(directory.SelectedPath + "/" + _sceneManager.ActiveScene.Name + ".png", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void SavePPM(FolderBrowserDialog directory, string imagePPM)
        {
            File.WriteAllText(directory.SelectedPath + "/" + _sceneManager.ActiveScene.Name + ".ppm", imagePPM);
        }
    }
}
