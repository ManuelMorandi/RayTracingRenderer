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
    public class MaterialManager
    {
        public IDbMaterialRepository _materialRepository;
        public IDbUserRepository _userRepository;

        public MaterialManager(IDbMaterialRepository mr, UserManager userManager)
        {
            var userRepository = userManager.UserRepository;
            _materialRepository = mr;
            _userRepository = userRepository;
        }

        public IDbMaterialRepository MaterialRepository { get { return _materialRepository; } }
        public IDbUserRepository UserRepository { get { return _userRepository; } }

        public void CreateMetallic(MetallicDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Metallic metallic = new Metallic()
                {
                    Owner = user,
                    Name = dto.Name,
                    Color = dto.Color,
                    Roughness = dto.Roughness,
                };
                _materialRepository.AddMaterial(metallic);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void CreateLambertian(LambertianDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Lambertian lambertian = new Lambertian()
                {
                    Owner = user,
                    Name = dto.Name,
                    Color = dto.Color,
                };
                _materialRepository.AddMaterial(lambertian);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void DeleteMaterial(string name, string owner)
        {
            try
            {
                var material = GetMaterial(name, owner);
                _materialRepository.DeleteMaterial(material);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public List<Material> GetUsersMaterials(string username)
        {
            try
            {
                return _materialRepository.GetUsersMaterials(username, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public RGBVector GetMaterialColor(string description)
        {
            try
            {
                return _materialRepository.GetColorFromDescription(description);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public Material GetMaterial(string name, string owner)
        {
            try
            {
                return _materialRepository.GetMaterial(name, owner, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }
    }
}
