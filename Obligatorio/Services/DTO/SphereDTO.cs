using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class SphereDTO
    {
        private string _name;
        private double _radius;
        private string _owner;

        public SphereDTO(string name, double radius, string owner)
        {
            _name = name;
            _radius = radius;
            _owner = owner;
        }

        public string Name { get { return _name; } }
        public double Radius { get { return _radius; } }
        public string Owner { get { return _owner; } }
    }
}
