using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class UsedModelDTO
    {
        Model _model;
        Vector _place;

        public UsedModelDTO(Model model, Vector place)
        {
            _model = model;
            _place = place;
        }

        public Model Model { get { return _model; } }
        public Vector Place { get { return _place; } }
    }
}
