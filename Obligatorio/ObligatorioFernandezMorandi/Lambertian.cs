using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class Lambertian : Material
    {
        private RGBVector _color;

        public RGBVector Color { get { return _color; } set {  _color = value; } }

        public override RGBVector GetColor()
        {
            return _color;
        }

        public override double GetRoughness()
        {
            return -1;
        }

        public override Ray Scatter(Ray ray, HitRecord hitRecord)
        {
            RandomUnitSphereProvider unitSphere = new RandomUnitSphereProvider();
            Vector newVectorPoint = hitRecord.Intersection.Add(hitRecord.Normal).Add(unitSphere.GetRandomInUnitSphere());
            Vector newVector = newVectorPoint.Subtract(hitRecord.Intersection);
            return new Ray(hitRecord.Intersection, newVector);
        }

        public override string GetDescription()
        {
            return "R: " + Color.Red() + " G: " + Color.Green() + " B: " + Color.Blue();
        }
    }
}
