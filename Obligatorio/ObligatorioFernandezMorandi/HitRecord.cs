using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HitRecord
    {
        private double _t;
        private Vector _intersection;
        private Vector _normal;
        private RGBVector _attenuation;
        private double _rouhness;

        public double T { get => _t; set => _t = value; }

        public Vector Intersection { get => _intersection; set => _intersection = value; }

        public Vector Normal { get =>  _normal; set => _normal = value; }

        public RGBVector Attenuation { get => _attenuation; set => _attenuation = value; }

        public double Roughness { get => _rouhness; set => _rouhness = value; }
    }
}
