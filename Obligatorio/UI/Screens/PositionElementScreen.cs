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
    public partial class PositionElementScreen : UserControl
    {
        public const string ScreenName = "PositionElementScreen";
        private IRouter _router;
        private UserManager _userManager;
        private ModelManager _modelManager;
        private SceneManager _sceneManager;
        private VectorManager _vectorManager;

        public PositionElementScreen(IRouter router, UserManager um, ModelManager mm, SceneManager sm, VectorManager vm)
        {
            _router = router;
            _userManager = um;
            _modelManager = mm;
            _sceneManager = sm;
            _vectorManager = vm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
        }

        private void BtnCloseTab_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void PositionElementScreen_Load(object sender, EventArgs e)
        {
            foreach (var model in _modelManager.GetUsersModels(_userManager.GetActiveUserName()))
            {
                cboxModels.Items.Add(model);
            }
        }

        private void BtnSaveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                AddModel();
                _router.ShowScreen(EditSceneScreen.ScreenName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddModel()
        {
            var selectedModelName = GetModelNameFromComboBox();
            var username = _userManager.GetActiveUserName();
            var model = _modelManager.GetModel(selectedModelName, username);
            var vectorDTO = new VectorDTO(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text), Convert.ToDouble(txtZ.Text));
            var place = _vectorManager.CreateVector(vectorDTO);
            var usedModelDTO = new UsedModelDTO(model, place);
            _sceneManager.AddUsedModel(usedModelDTO);
            _sceneManager.ActiveSceneUpdated();
        }

        private string GetModelNameFromComboBox() 
        {
            string modelName = "";
            int selectedModel = cboxModels.SelectedIndex;
            bool IsModelSelected = selectedModel > -1;
            if (IsModelSelected)
            {
                modelName = cboxModels.GetItemText(cboxModels.SelectedItem);
            }
            else
            {
                throw new UserException("Debe seleccionar un modelo");
            }
            return modelName;
        }
    }
}
