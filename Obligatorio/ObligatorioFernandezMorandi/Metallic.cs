using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Metallic : Material
    {
        private RGBVector _color;
        private double _roughness;

        public RGBVector Color { get { return _color; } set { _color = value; } }

        public double Roughness { 
            get { return _roughness; } 
            set 
            { 
                ValidateRoughness(value);
                _roughness = value; 
            } 
        }

        public override RGBVector GetColor()
        {
            return _color;
        }

        public override double GetRoughness()
        {
            return _roughness;
        }

        public override Ray Scatter(Ray ray, HitRecord hitRecord)
        {
            RandomUnitSphereProvider unitSphere = new RandomUnitSphereProvider();
            Ray rayScattered = new Ray(new Vector(0, 0, 0), new Vector(0, 0, 0));
            Vector vectorReflected = Reflect(ray.Direction.GetUnit(), hitRecord.Normal);
            rayScattered.Origin = hitRecord.Intersection;
            rayScattered.Direction = vectorReflected.Add(
                unitSphere.GetRandomInUnitSphere().Multiply(hitRecord.Roughness)
            );
            bool dotIsPositive = rayScattered.Direction.Dot(hitRecord.Normal) > 0;
            if (dotIsPositive)
            {
                return rayScattered;
            }
            else
            {
                return null;
            }
        }

        public override string GetDescription()
        {
            return "R: " + Color.Red() + " G: " + Color.Green() + " B: " + Color.Blue() + " Difuminado: " + _roughness;
        }

        private Vector Reflect(Vector vectorV, Vector vectorN)
        {
            double dotVN = vectorV.Dot(vectorN);
            return vectorV.Subtract(vectorN.Multiply(2 * dotVN));
        }

        private void ValidateRoughness(double roughness)
        {
            if (IsRoughnessInvalid(roughness))
                throw new BusinessLogicException("El difuminado debe ser un valor positivo");
        }

        private bool IsRoughnessInvalid(double roughness)
        {
            return roughness < 0;
        }
    }
}
