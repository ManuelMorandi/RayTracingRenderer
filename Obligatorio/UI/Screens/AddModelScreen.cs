using Domain;
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
    public partial class AddModelScreen : UserControl
    {
        public const string ScreenName = "AddModelScreen";
        private IRouter _router;
        private UserManager _userManager;
        private SphereManager _sphereManager;
        private MaterialManager _materialManager;
        private ModelManager _modelManager;

        public AddModelScreen(IRouter router, UserManager ur, SphereManager sm, MaterialManager matm, ModelManager mm)
        {
            _router = router;
            _userManager = ur;
            _sphereManager = sm;
            _materialManager = matm;
            _modelManager = mm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
        }

        private void BtnCloseTab_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            try
            {
                CreateModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddModelScreen_Load(object sender, EventArgs e)
        {
            var username = _userManager.GetActiveUserName();
            foreach (Sphere shape in _sphereManager.GetUsersSpheres(username))
            {
                cboxShape.Items.Add(shape);
            }
            foreach (Material material in _materialManager.GetUsersMaterials(username))
            {
                cboxMaterial.Items.Add(material);
            }
        }

        private void CreateModel()
        {
            var owner = _userManager.GetActiveUserName();
            var name = txtModelName.Text;
            var shape = GetShapeFromComboBox().Name;
            var material = GetMaterialFromComboBox().Name;
            var generatePreview = chkPreview.Checked;
            ModelDTO modelDTO = new ModelDTO(owner, name, "null", material, shape);
            if (generatePreview)
            {
                SetPreview(modelDTO);
            }
            _modelManager.AddModel(modelDTO);
            _router.ShowScreen(ModelScreen.ScreenName);
        }

        private Sphere GetShapeFromComboBox()
        {
            Sphere shape;
            int selectedShape = cboxShape.SelectedIndex;
            if (SomethingIsSelected(selectedShape))
            {
                var shapeName = cboxShape.GetItemText(cboxShape.SelectedItem);
                var userName = _userManager.GetActiveUserName();
                shape = _sphereManager.GetShape(shapeName, userName);
            }
            else
            {
                throw new BusinessLogicException("Debe seleccionar una figura");
            }
            return shape;
        }

        private Material GetMaterialFromComboBox()
        {
            Material material;
            int selectedMaterial = cboxMaterial.SelectedIndex;
            if (SomethingIsSelected(selectedMaterial))
            {
                var materialName = cboxMaterial.GetItemText(cboxMaterial.SelectedItem);
                var userName = _userManager.GetActiveUserName();
                material = _materialManager.GetMaterial(materialName, userName);
            }
            else
            {
                throw new BusinessLogicException("Debe seleccionar un material");
            }
            return material;
        }

        private static bool SomethingIsSelected(int selectedMaterial)
        {
            return selectedMaterial > -1;
        }

        private UsedModel CreateUsedModel(ModelDTO modelDTO)
        {
            var model = _modelManager.CreateModel(modelDTO);
            UsedModel usedModel = new UsedModel()
            {
                SelectedModel = model,
                Place = new Vector(0, 0, 0)
            };
            return usedModel;
        }

        private Scene CreateScene()
        {
            Scene scene = new Scene()
            {
                LookAt = new Vector(0, 0, 0),
                LookFrom = new Vector(50, 50, 50),
            };
            return scene;
        }

        private Renderer CreateRenderer(Scene scene)
        {
            const int defaultPreviewResolution = 60;
            Vector defaultUp = new Vector(0, 1, 0);
            Renderer renderer = new Renderer(defaultPreviewResolution, defaultPreviewResolution, defaultUp, scene);
            return renderer;
        }

        private void SetPreview(ModelDTO model)
        {
            UsedModel usedModel = CreateUsedModel(model);
            Scene scene = CreateScene();
            scene.AddModel(usedModel);
            Renderer renderer = CreateRenderer(scene);
            model.Preview = renderer.Render();
        }
    }
}
