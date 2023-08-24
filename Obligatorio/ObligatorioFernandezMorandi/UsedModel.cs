using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UsedModel
    {
        private int _id = 0;
        private Model _model;
        private Vector _place;

        public int Id { get { return _id; } set { _id = value; } }

        public Model SelectedModel { get => _model; set => _model = value; }

        public Vector Place { get => _place ; set => _place = value; }

        public HitRecord IsModelHit(Ray ray, double tMin, double tMax)
        {
            Shape shape = _model.ModelShape;
            Material material = _model.ModelMaterial;
            RGBVector color = material.GetColor();
            double roughness = material.GetRoughness();
            return shape.IsShapeHit(_place, ray, tMin, tMax, color, roughness);
        }
    }
}
