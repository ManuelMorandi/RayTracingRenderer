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
    public class ModelManager
    {
        public IDbModelRepository _modelRepository;
        public IDbUserRepository _userRepository;
        public IDbSphereRepository _sphereRepository;
        public IDbMaterialRepository _materialRepository;

        public ModelManager(IDbModelRepository mr, UserManager um, SphereManager sm, MaterialManager mm)
        {
            var userRepository = um.UserRepository;
            var sphereRepository = sm.SphereRepository;
            var materialRepository = mm.MaterialRepository;
            _modelRepository = mr;
            _userRepository = userRepository;
            _sphereRepository = sphereRepository;
            _materialRepository = materialRepository;
        }

        public IDbModelRepository ModelRepository { get { return _modelRepository; } }
        public IDbUserRepository UserRepository { get { return _userRepository; } }
        public IDbSphereRepository SphereRepository { get { return _sphereRepository; } }
        public IDbMaterialRepository MaterialRepository { get { return _materialRepository; } }

        public void AddModel(ModelDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Sphere sphere = _sphereRepository.GetShape(dto.ShapeName, dto.Owner, _userRepository);
                Material material = _materialRepository.GetMaterial(dto.MaterialName, dto.Owner, _userRepository);
                Model model = new Model()
                {
                    Owner = user,
                    Name = dto.Name,
                    Preview = dto.Preview,
                    ModelShape = sphere,
                    ModelMaterial = material,
                };
                _modelRepository.AddModel(model);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public Model CreateModel(ModelDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Sphere sphere = _sphereRepository.GetShape(dto.ShapeName, dto.Owner, _userRepository);
                Material material = _materialRepository.GetMaterial(dto.MaterialName, dto.Owner, _userRepository);
                return new Model()
                {
                    Owner = user,
                    Name = dto.Name,
                    Preview = dto.Preview,
                    ModelMaterial = material,
                    ModelShape = sphere,
                };
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public List<Model> GetUsersModels(string username)
        {
            try
            {
                return _modelRepository.GetUsersModels(username, _userRepository, _sphereRepository, _materialRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void DeleteModel(string name, string owner)
        {
            try
            {
                var model = GetModel(name, owner);
                _modelRepository.DeleteModel(model);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public string GetModelPreview(string name, string owner)
        {
            try
            {
                var model = _modelRepository.GetModel(name, owner, _userRepository, _sphereRepository, _materialRepository);
                return model.Preview;
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public Model GetModel(string name, string user)
        {
            try
            {
                return _modelRepository.GetModel(name, user, _userRepository, _sphereRepository, _materialRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public RGBVector GetMaterialColor(string username, string name)
        {
            try
            {
                var material = _materialRepository.GetMaterial(name, username, _userRepository);
                var description = material.GetDescription();
                return _materialRepository.GetColorFromDescription(description);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }
    }
}
