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
    public partial class MaterialScreen : UserControl
    {
        public const string ScreenName = "MaterialScreen";
        private IRouter _router;
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private MaterialManager _materialManager;

        public MaterialScreen(IRouter router, RenderLogic renderLogic, UserManager um, MaterialManager materialManager)
        {
            _router = router;
            _renderLogic = renderLogic;
            _userManager = um;
            _materialManager = materialManager;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
            pnlList.Controls.AddRange(_materialManager.GetUsersMaterials(_userManager.GetActiveUserName())
                .Select(material => new ListElement(_router, material.Name, material.GetDescription(), "Material", _renderLogic, _userManager, null, _materialManager, null)).ToArray());
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            const int lambertianIndex = 0;
            const int metallicIndex = 1;
            int selectedMaterial = cboxMaterial.SelectedIndex;
            bool isLambertian = selectedMaterial == lambertianIndex;
            bool isMetallic = selectedMaterial == metallicIndex;
            if (isLambertian)
            {
                _router.ShowScreen(AddLambertianScreen.ScreenName);
            }
            else if (isMetallic)
            {
                _router.ShowScreen(AddMetallicScreen.ScreenName);
            }
            else
            {
                throw new UserException("Debe seleccionar un tipo de material válido");
            }
        }
    }
}
