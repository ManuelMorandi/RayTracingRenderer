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

namespace UI
{
    public partial class ListElement : UserControl
    {
        private String _name;
        private String _description;
        private String _type;
        private IRouter _router;
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private SphereManager _sphereManager;
        private MaterialManager _materialManager;
        private ModelManager _modelManager;

        public ListElement(IRouter router, String name, String description, String type, RenderLogic renderLogic, UserManager um, SphereManager sm, MaterialManager mm, ModelManager modelManager)
        {
            _router = router;
            _renderLogic = renderLogic;
            _name = name;
            _description = description;
            _type = type;
            _userManager = um;
            _sphereManager = sm;
            _materialManager = mm;
            _modelManager = modelManager;
            InitializeComponent();
            imgColor.BackColor = Color.Transparent;
            imgColor.SendToBack();

            lblElementName.Text = name;
            lblElementInfo.Text = description;
            switch (_type)
            {
                case "Shape":
                    ShowSphereImage();
                    break;
                case "Material":
                    ShowColorImage(description);
                    break;
                case "Model":
                    ShowModelPreview(name, description);
                    break;
                default:
                    break;
            }
            _modelManager = modelManager;
        }

        private void BtnDeleteElement_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteElement();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("No es posible borrar porque el elemento está en uso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteElement()
        {
            switch (_type)
            {
                case "Shape":
                    DeleteShape();
                    break;
                case "Material":
                    DeleteMaterial();
                    break;
                case "Model":
                    DeleteModel();
                    break;
                default:
                    break;
            }
        }

        private void DeleteModel()
        {
            var username = _userManager.GetActiveUserName();
            _modelManager.DeleteModel(_name, username);
            _router.ShowScreen(ModelScreen.ScreenName);
        }

        private void DeleteMaterial()
        {
            var username = _userManager.GetActiveUserName();
            _materialManager.DeleteMaterial(_name, username);
            _router.ShowScreen(MaterialScreen.ScreenName);
        }

        private void DeleteShape()
        {
            var username = _userManager.GetActiveUserName();
            _sphereManager.DeleteSphere(_name, username);
            _router.ShowScreen(FigureScreen.ScreenName);
        }

        private void ShowSphereImage()
        {
            imgShape.Image = Properties.Resources.Sphere;
        }

        private void ShowColorImage(string description)
        {
            var color = _materialManager.GetMaterialColor(description);
            int red = Convert.ToInt32(color.Red());
            int green = Convert.ToInt32(color.Green());
            int blue = Convert.ToInt32(color.Blue());
            imgShape.BackColor = Color.FromArgb(red, green, blue);
        }

        private void ShowModelPreview(string name, string description)
        {
            string preview = _modelManager.GetModelPreview(name, _userManager.GetActiveUserName());
            bool thereIsNoPreviewAvailable = preview.Equals("null");
            if (thereIsNoPreviewAvailable)
            {
                ShowNoAvailablePreview(description);
            }
            else
            {
                ShowPreviewImage(preview);
            }
        }

        private void ShowPreviewImage(string preview)
        {
            imgShape.Image = _renderLogic.ShowImage(preview);
        }

        private void ShowNoAvailablePreview(string modelDescription)
        {
            imgShape.Image = Properties.Resources.Sphere;
            var materialName = GetMaterialName(modelDescription);
            var username = _userManager.GetActiveUserName();
            var color = _modelManager.GetMaterialColor(username, materialName);
            int red = Convert.ToInt32(color.Red());
            int green = Convert.ToInt32(color.Green());
            int blue = Convert.ToInt32(color.Blue());
            imgColor.BringToFront();
            imgColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private string GetMaterialName(string modelDescription)
        {
            string[] separators = new string[] { ", Material: " };
            var split = modelDescription.Split(separators, StringSplitOptions.None);
            return split[1];
        }
    }
}
