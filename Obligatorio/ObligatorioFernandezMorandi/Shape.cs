using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Shape
    {
        private string _name;
        private User _owner;

        public string Name { get => _name; set {
                NameValidator validator = new NameValidator();
                validator.ValidateName(value);
                _name = value;
            }
        }

        public User Owner { get => _owner; set => _owner = value; }

        public abstract HitRecord IsShapeHit(Vector center, Ray ray, double tMin, double tMax, RGBVector color, double roughness);

        public abstract string GetDescription();

        public override string ToString()
        {
            return this.Name;
        }
        public override bool Equals(object obj)
        {
            return obj.ToString().Equals(this.ToString());
        }
    }
}
