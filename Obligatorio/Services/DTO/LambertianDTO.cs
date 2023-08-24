using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class LambertianDTO
    {
        private string _owner;
        private string _name;
        private RGBVector _color;

        public LambertianDTO(string owner,string name, RGBVector color)
        {
            _owner = owner;
            _name = name;
            _color = color;
        }

        public string Owner { get { return _owner; } }
        public string Name { get { return _name; } }
        public RGBVector Color { get { return _color; } }
    }
}
