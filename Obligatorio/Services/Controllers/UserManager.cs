using Domain;
using Services.Interfaces;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services.Controllers
{
    public class UserManager
    {
        private User _activeUser;
        private IDbUserRepository _userRepository;

        public UserManager(IDbUserRepository ur)
        {
            ActiveUser = null;
            _userRepository = ur;
        }

        public User ActiveUser { get { return _activeUser; } set { _activeUser = value; } }

        public IDbUserRepository UserRepository { get { return _userRepository; } }

        public string GetActiveUserName()
        {
            return ActiveUser.UserName;
        }

        public void LogIn(string username, string password)
        {
            try
            {
                ValidateUserCredentials(username, password);
                ActiveUser = _userRepository.GetUser(username);
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void LogOut()
        {
            ActiveUser = null;
        }

        public void AddUser(UserDTO userDTO)
        {
            try
            {
                User user = new User()
                {
                    UserName = userDTO.UserName,
                    Password = userDTO.Password,
                    Creation = DateTimeProvider.Now
                };
                _userRepository.AddUser(user);
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void CheckNameValidity(string name)
        {
            try
            {
                User temporaryUser = new User()
                {
                    UserName = name,
                };
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void CheckPasswordValidity(string password)
        {
            try
            {
                User temporaryUser = new User()
                {
                    Password = password
                };
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        private void ValidateUserCredentials(string username, string password)
        {
            bool usernameDoesntExist = !_userRepository.ExistsUser(username);
            bool passwordDoesntMatch = !_userRepository.GetUser(username).Password.Equals(password);
            bool isLogInInformationInvalid = usernameDoesntExist || passwordDoesntMatch;
            if (isLogInInformationInvalid)
                throw new ManagerException("Nombre de usuario o contraseña incorrectos");
        }
    }
}
