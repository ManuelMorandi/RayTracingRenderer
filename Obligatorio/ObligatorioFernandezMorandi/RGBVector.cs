using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RGBVector : Vector
    {
        private const int MinColorValue = 0;
        private const int MaxColorValue = 1;

        public RGBVector(double x, double y, double z) : base(x, y, z)
        {
            if (AreValuesOutOfBounds(x, y, z))
                throw new BusinessLogicException("Los valores deben estar entre 0 y 255");
        }

        public double Red()
        {
            if (IsValueOutOfBounds(this.X))
                throw new BusinessLogicException("El valor del color rojo debe estar entre 0 y 255");
            return Math.Abs(Math.Round(this.X * 255, 0, MidpointRounding.AwayFromZero));
        }

        public double Green()
        {
            if (IsValueOutOfBounds(this.Y))
                throw new BusinessLogicException("El valor del color verde debe estar entre 0 y 255");
            return Math.Abs(Math.Round(this.Y * 255, 0, MidpointRounding.AwayFromZero));
        }

        public double Blue()
        {
            if (IsValueOutOfBounds(this.Z))
                throw new BusinessLogicException("El valor del color azul debe estar entre 0 y 255");
            return Math.Abs(Math.Round(this.Z * 255, 0, MidpointRounding.AwayFromZero));
        }
        public RGBVector DivideColor(double iCount)
        {
            if (IsDividingByZero(iCount))
                throw new BusinessLogicException("No es posible dividir entre 0");
            return new RGBVector(this.X / iCount, this.Y / iCount, this.Z / iCount);
        }

        private bool IsValueOutOfBounds(double value)
        {
            return value < MinColorValue || value > MaxColorValue;
        }

        private bool AreValuesOutOfBounds(double x, double y, double z)
        {
            return IsValueOutOfBounds(x) || IsValueOutOfBounds(y) || IsValueOutOfBounds(z);
        }

        private static bool IsDividingByZero(double iCount)
        {
            return iCount == 0;
        }
    }
}
