using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Material
    {
        private string _name;
        private User _owner;

        public string Name {
            get => _name; 
            set 
            {
                NameValidator validator = new NameValidator();
                validator.ValidateName(value);
                _name = value;
            }
        }

        public User Owner { get => _owner; set => _owner = value; }

        public abstract RGBVector GetColor();

        public abstract double GetRoughness();

        public abstract Ray Scatter(Ray ray, HitRecord hitRecord);

        public abstract string GetDescription();

        public override string ToString()
        {
            return Name;
        }
    }
}
