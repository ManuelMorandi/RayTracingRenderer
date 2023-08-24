using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sphere : Shape
    {
        private const double MinRadiusValue = 0;
        
        private double _radius;

        public double Radius { get => _radius; set
            {
                ValidateRadius(value);
                _radius = value;
            } 
        }

        public override HitRecord IsShapeHit(Vector center, Ray ray, double tMin, double tMax, RGBVector color, double roughness)
        {
            Vector vectorOriginCenter = ray.Origin.Subtract(center);
            double a = ray.Direction.Dot(ray.Direction);
            double b = vectorOriginCenter.Dot(ray.Direction) * 2;
            double c = vectorOriginCenter.Dot(vectorOriginCenter) - (Radius * Radius);
            double discriminant = (b * b) - (4 * a * c);
            bool discriminantIsNegative = discriminant < 0;
            if (discriminantIsNegative)
            {
                return null;
            }
            else
            {
                double t = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);
                Vector intersectionPoint = ray.PointAt(t);
                Vector normal = intersectionPoint.Subtract(center).Divide(Radius);
                bool tInBounds = t < tMax && t > tMin;
                if (tInBounds)
                {
                    return new HitRecord()
                    {
                        T = t,
                        Normal = normal,
                        Intersection = intersectionPoint,
                        Attenuation = color,
                        Roughness = roughness
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public override string GetDescription()
        {
            return "Radio: " + Radius;
        }

        private void ValidateRadius(double radius)
        {
            if (IsRadiusSmallerThanMinimum(radius))
            {
                throw new BusinessLogicException("El radio debe ser mayor a 0");
            }
        }

        private bool IsRadiusSmallerThanMinimum(double radius)
        {
            return radius <= MinRadiusValue;
        }
    }
}
