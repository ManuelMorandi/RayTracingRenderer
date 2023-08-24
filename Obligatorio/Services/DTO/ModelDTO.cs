using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class ModelDTO
    {
        private string _owner;
        private string _name;
        private string _preview;
        private string _materialName;
        private string _shapeName;

        public ModelDTO(string owner, string name, string preview, string material, string shape)
        {
            _owner = owner;
            _name = name;
            _preview = preview;
            _materialName = material;
            _shapeName = shape;
        }

        public string Owner { get { return _owner; } }
        public string Name { get { return _name; } }
        public string Preview { get { return _preview; } set { _preview = value; } }
        public string MaterialName { get { return _materialName; } }
        public string ShapeName { get { return _shapeName;} }
    }
}
