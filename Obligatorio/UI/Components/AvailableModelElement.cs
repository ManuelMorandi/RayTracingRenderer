using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Components
{
    public partial class AvailableModelElement : UserControl
    {
        Model _model;
        RenderLogic _renderLogic;

        public AvailableModelElement(Model model, RenderLogic renderLogic)
        {
            _model = model;
            _renderLogic = renderLogic;
            InitializeComponent();
            lblName.Text = _model.Name;
            ShowModelPreview(model);
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
    }
}
