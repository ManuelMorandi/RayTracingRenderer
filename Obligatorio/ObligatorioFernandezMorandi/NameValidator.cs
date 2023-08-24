using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NameValidator
    {
        public void ValidateName(string name)
        {
            if (NameStartsWithSpace(name))
                throw new BusinessLogicException("El nombre no puede empezar con un espacio");
            if (NameEndsWithSpace(name))
                throw new BusinessLogicException("El nombre no puede terminar con un espacio");
            if (IsNameEmpty(name))
                throw new BusinessLogicException("El nombre no puede ser vacío");
        }

        private bool IsNameEmpty(string name)
        {
            return name.Equals("");
        }

        private bool NameStartsWithSpace(string name)
        {
            return name.StartsWith(" ");
        }

        private bool NameEndsWithSpace(string name)
        {
            return name.EndsWith(" ");
        }
    }
}
