using Domain;
using Services.Interfaces;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Controllers
{
    public class SceneManager
    {
        public IDbSceneRepository _sceneRepository;
        public IDbUserRepository _userRepository;
        public IDbUsedModelRepository _usedModelRepository;
        public Scene _activeScene;

        public SceneManager(IDbSceneRepository sr, IDbUsedModelRepository umr, UserManager um)
        {
            var userRepository = um.UserRepository;
            _sceneRepository = sr;
            _userRepository = userRepository;
            _usedModelRepository = umr;
            _activeScene = null;
        }

        public IDbSceneRepository SceneRepository { get { return _sceneRepository; } }
        public IDbUserRepository UserRepository { get { return _userRepository; } }
        public Scene ActiveScene { get { return _activeScene; } set { _activeScene = value; } }

        public void AddScene(SceneDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Scene scene = new Scene()
                {
                    Owner = user,
                    Name = dto.Name
                };
                _sceneRepository.AddScene(scene);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }



        public Scene GetScene(string name, string owner)
        {
            try
            {
                return _sceneRepository.GetScene(name, owner, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void DeleteScene(string name, string owner)
        {
            try
            {
                var scene = GetScene(name, owner);
                foreach (var model in _usedModelRepository.GetSceneModels(name, owner))
                {
                    _usedModelRepository.DeleteUsedModel(model, scene);
                }
                _sceneRepository.DeleteScene(scene);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void AddUsedModel(UsedModelDTO dto)
        {
            try
            {
                UsedModel usedModel = new UsedModel()
                {
                    SelectedModel = dto.Model,
                    Place = dto.Place
                };
                _usedModelRepository.AddUsedModel(usedModel, ActiveScene);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void DeleteUsedModel(UsedModel usedModel)
        {
            try
            {
                _usedModelRepository.DeleteUsedModel(usedModel, ActiveScene);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public UsedModel CreateUsedModel(UsedModelDTO dto)
        {
            try
            {
                return new UsedModel()
                {
                    SelectedModel = dto.Model,
                    Place = dto.Place
                };
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public List<Scene> GetUsersScenes(string username)
        {
            try
            {
                return _sceneRepository.GetUsersScenes(username, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void UpdateScene(UpdateSceneDTO dto)
        {
            try
            {
                ActiveScene.LastRenderDate = dto.Render;
                ActiveScene.LookFrom = dto.LookFrom;
                ActiveScene.LookAt = dto.LookAt;
                ActiveScene.Fov = dto.Fov;
                ActiveScene.Render = dto.RenderImage;
                ActiveScene.Preview = dto.PreviewImage;
                ActiveScene.Aperture = dto.Aperture;
                ActiveScene.Blurred = dto.Blurred;
                ActiveSceneUpdated();
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void ActiveSceneRendered()
        {
            try
            {
                ActiveScene.LastRenderDate = DateTime.Now;
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void ActiveSceneUpdated()
        {
            try
            {
                ActiveScene.LastModificationDate = DateTime.Now;
                UpdateActiveScene();
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public List<UsedModel> GetActiveSceneModels()
        {
            try
            {
                var user = ActiveScene.Owner.UserName;
                var scene = ActiveScene.Name;
                return _usedModelRepository.GetSceneModels(scene, user);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public string GetScenePreview(string name, string owner)
        {
            try
            {
                var scene = GetScene(name, owner);
                return scene.Preview;
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        private void UpdateActiveScene()
        {
            try
            {
                _sceneRepository.UpdateScene(ActiveScene);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }
    }
}
