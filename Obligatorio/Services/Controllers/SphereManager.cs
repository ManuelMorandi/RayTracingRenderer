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
    public class SphereManager
    {
        public IDbSphereRepository _sphereRepository;
        public IDbUserRepository _userRepository;

        public SphereManager(IDbSphereRepository sr, UserManager userManager)
        {
            var userRepository = userManager.UserRepository;
            _sphereRepository = sr;
            _userRepository = userRepository;
        }

        public IDbSphereRepository SphereRepository { get {  return _sphereRepository; } }
        public IDbUserRepository UserRepository { get { return _userRepository; } }

        public void CreateSphere(SphereDTO dto)
        {
            try
            {
                User user = _userRepository.GetUser(dto.Owner);
                Sphere sphere = new Sphere()
                {
                    Owner = user,
                    Radius = dto.Radius,
                    Name = dto.Name,
                };
                _sphereRepository.AddSphere(sphere);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void DeleteSphere(string name, string owner)
        {
            try
            {
                var sphere = GetShape(name, owner);
                _sphereRepository.DeleteSphere(sphere);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public List<Sphere> GetUsersSpheres(string username)
        {
            try
            {
                return _sphereRepository.GetUsersSpheres(username, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public Sphere GetShape(string shapeName, string userName)
        {
            try
            {
                return _sphereRepository.GetShape(shapeName, userName, _userRepository);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }
    }
}
