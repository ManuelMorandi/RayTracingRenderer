using Services;
using UI.Screens;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Controllers;
using DataAccess;

namespace UI
{
    public partial class MainForm : MaterialForm, IRouter
    {
        private RenderLogic _renderLogic;
        private UserManager _userManager;
        private SphereManager _sphereManager;
        private MaterialManager _materialManager;
        private ModelManager _modelManager;
        private SceneManager _sceneManager;
        private VectorManager _vectorManager;

        public MainForm()
        {
            _renderLogic = new RenderLogic();
            InitializeComponent();

            var repoMaterial = new RepoMaterial();
            var repoSphere = new RepoSphere();
            var repoModel = new RepoModel();
            var repoScene = new RepoScene();
            var repoUser = new RepoUser();
            var repoUsedModel = new RepoUsedModel();
            _userManager = new UserManager(repoUser); 
            _sphereManager = new SphereManager(repoSphere, _userManager);
            _materialManager = new MaterialManager(repoMaterial, _userManager);
            _modelManager = new ModelManager(repoModel, _userManager, _sphereManager, _materialManager);
            _sceneManager = new SceneManager(repoScene, repoUsedModel, _userManager);
            _vectorManager = new VectorManager();
    }

        public void GoBack()
        {
            if (AreTherePreviousScreens())
            {
                this.mainPanel.Controls.RemoveAt(0);
                this.mainPanel.Refresh();
            }
        }

        public void ShowScreen(string screen)
        {
            UserControl newScreen = new LogInScreen(this, _userManager);
            switch (screen)
            {
                case SignUpScreen.ScreenName:
                    newScreen = new SignUpScreen(this, _userManager);
                    break;
                case FigureScreen.ScreenName:
                    newScreen = new FigureScreen(this, _renderLogic, _userManager, _sphereManager);
                    break;
                case AddFigureScreen.ScreenName:
                    newScreen = new AddFigureScreen(this, _userManager, _sphereManager);
                    break;
                case MaterialScreen.ScreenName:
                    newScreen = new MaterialScreen(this, _renderLogic, _userManager, _materialManager);
                    break;
                case AddLambertianScreen.ScreenName:
                    newScreen = new AddLambertianScreen(this, _userManager, _materialManager, _vectorManager);
                    break;
                case AddMetallicScreen.ScreenName:
                    newScreen = new AddMetallicScreen(this, _userManager, _materialManager, _vectorManager);
                    break;
                case ModelScreen.ScreenName:
                    newScreen = new ModelScreen(this, _renderLogic, _userManager, _modelManager);
                    break;
                case AddModelScreen.ScreenName:
                    newScreen = new AddModelScreen(this, _userManager, _sphereManager, _materialManager, _modelManager);
                    break;
                case SceneScreen.ScreenName:
                    newScreen = new SceneScreen(this, _renderLogic, _sceneManager, _userManager);
                    break;
                case AddSceneScreen.ScreenName:
                    newScreen = new AddSceneScreen(this, _userManager, _sceneManager);
                    break;
                case EditSceneScreen.ScreenName:
                    newScreen = new EditSceneScreen(this, _renderLogic, _userManager, _modelManager, _sceneManager, _vectorManager);
                    break;
                case PositionElementScreen.ScreenName:
                    newScreen = new PositionElementScreen(this, _userManager, _modelManager, _sceneManager, _vectorManager);
                    break;
                default:
                    break;
            }
            this.mainPanel.Controls.Add(newScreen);
            this.mainPanel.Controls.SetChildIndex(newScreen, 0);
            Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowScreen("LogInMenu");
        }

        private bool AreTherePreviousScreens()
        {
            return this.mainPanel.Controls.Count > 0;
        }
    }
}
