using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class MetallicDTO
    {
        private string _owner;
        private string _name;
        private RGBVector _color;
        private double _roughness;

        public MetallicDTO(string owner, string name, RGBVector color, double roughness)
        {
            _owner = owner;
            _name = name;
            _color = color;
            _roughness = roughness;
        }

        public string Owner { get { return _owner; } }
        public string Name { get { return _name; } }
        public RGBVector Color { get { return _color; } }
        public double Roughness { get { return _roughness; } }
    }
}
