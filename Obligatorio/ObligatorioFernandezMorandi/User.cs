using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Domain
{
    public class User
    {
        private const int UserNameMaxLength = 20;
        private const int UserNameMinLength = 3;
        private const int PasswordMaxLength = 25;
        private const int PasswordMinLength = 5;

        private string _userName;
        private string _password;
        private DateTime _creation;

        public string UserName { 
            get => _userName; 
            set {
                ValidateName(value);
                _userName = value;
            }
        }

        public string Password { 
            get => _password; 
            set {
                ValidatePassword(value);
                _password = value;
            }
        }

        public DateTime Creation { get => _creation; set => _creation = value; }

        public override string ToString()
        {
            return this.UserName;
        }

        public override bool Equals(object obj)
        {
            bool objectIsEmpty = obj == null;
            if (objectIsEmpty) return false;
            return this.UserName.Equals(obj.ToString());
        }

        private void ValidateName(string name)
        {
            if (IsNameTooShort(name))
                throw new BusinessLogicException("El nombre de usuario debe tener al menos 3 caracteres");
            if (IsNameTooLong(name))
                throw new BusinessLogicException("El nombre de usuario debe tener como maximo 20 caracteres");
            if (NameContainsSpace(name))
                throw new BusinessLogicException("El nombre de usuario no puede tener espacios");
            if (IsNameNotAlphanumeric(name))
                throw new BusinessLogicException("El nombre de usuario sólo puede tener letras y números");
        }

        private void ValidatePassword(string password)
        {
            if (PasswordContainsNoUpperCase(password))
                throw new BusinessLogicException("La contraseña debe tener al menos una mayúscula");
            if (PasswordContainsNoNumbers(password))
                throw new BusinessLogicException("La contraseña debe tener al menos un número");
            if (IsPasswordTooShort(password))
                throw new BusinessLogicException("La contraseña debe tener al menos 5 caracteres");
            if (IsPasswordTooLong(password))
                throw new BusinessLogicException("La contraseña debe tener como maximo 25 caracteres");
        }

        private bool IsNameTooShort(string name)
        {
            return name.Length < UserNameMinLength;
        }

        private bool IsNameTooLong(string name)
        {
            return name.Length > UserNameMaxLength;
        }

        private bool NameContainsSpace(string name)
        {
            return name.Contains(" ");
        }

        private bool IsNameNotAlphanumeric(string name)
        {
            return !(new Regex("^[a-zA-Z0-9]*$")).IsMatch(name);
        }

        private bool PasswordContainsNoUpperCase(string password)
        {
            return !password.Any(char.IsUpper);
        }

        private bool PasswordContainsNoNumbers(string password)
        {
            return !password.Any(char.IsNumber);
        }

        private bool IsPasswordTooShort(string password)
        {
            return password.Length < PasswordMinLength;
        }

        private bool IsPasswordTooLong(string password)
        {
            return password.Length > PasswordMaxLength;
        }
    }
}
