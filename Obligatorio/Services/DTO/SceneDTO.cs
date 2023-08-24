using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class SceneDTO
    {
        private string _owner;
        private string _name;

        public SceneDTO(string owner, string name)
        {
            _owner = owner;
            _name = name;
        }

        public string Owner { get { return _owner; } }
        public string Name { get { return _name; } }
    }
}
