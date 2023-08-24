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
    public partial class AddLambertianScreen : UserControl
    {
        public const string ScreenName = "AddLambertianScreen";
        private IRouter _router;
        private UserManager _userManager;
        private MaterialManager _materialManager;
        private VectorManager _vectorManager;

        public AddLambertianScreen(IRouter router, UserManager um, MaterialManager mm, VectorManager vm)
        {
            _router = router;
            _userManager = um;
            _materialManager = mm;
            _vectorManager = vm;
            InitializeComponent();
            pnlMenu.Controls.Add(new Menu(router, _userManager));
        }

        private void BtnCloseTab_Click(object sender, EventArgs e)
        {
            _router.GoBack();
        }

        private void BtnSaveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                const int MaxColorValue = 255;
                double red = Convert.ToDouble(txtRed.Text) / MaxColorValue;
                double green = Convert.ToDouble(txtGreen.Text) / MaxColorValue;
                double blue = Convert.ToDouble(txtBlue.Text) / MaxColorValue;
                VectorDTO dtoVector = new VectorDTO(red, green, blue);
                var color = _vectorManager.CreateRGBVector(dtoVector);

                string username = _userManager.GetActiveUserName();
                LambertianDTO material = new LambertianDTO(username, txtFigureName.Text, color);
                AddLambertian(material);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddLambertian(LambertianDTO material)
        {
            _materialManager.CreateLambertian(material);
            _router.ShowScreen("MaterialScreen");
        }
    }
}
