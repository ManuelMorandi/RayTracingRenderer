using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vector
    {
        protected double _x;
        protected double _y;
        protected double _z;

        public Vector(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }

        public Vector Add(Vector vector3d)
        {
            return new Vector(this.X + vector3d.X, this.Y + vector3d.Y, this.Z + vector3d.Z);
        }

        public Vector Subtract(Vector vector3d)
        {
            return new Vector(this.X - vector3d.X, this.Y - vector3d.Y, this.Z - vector3d.Z);
        }

        public Vector Multiply(double iCount)
        {
            return new Vector(this.X * iCount, this.Y * iCount, this.Z * iCount);
        }

        public Vector Divide(double iCount)
        {
            if (IsDividingByZero(iCount))
                throw new BusinessLogicException("No se puede dividir entre 0");
            return new Vector(this.X / iCount, this.Y / iCount, this.Z / iCount);
        }

        public void AddTo(Vector vector3d)
        {
            this.X += vector3d.X;
            this.Y += vector3d.Y;
            this.Z += vector3d.Z;
        }

        public void SubstractFrom(Vector vector3d)
        {
            this.X -= vector3d.X;
            this.Y -= vector3d.Y;
            this.Z -= vector3d.Z;
        }

        public void ScaleUpBy(double iCount)
        {
            this.X *= iCount;
            this.Y *= iCount;
            this.Z *= iCount;
        }

        public void ScaleDownBy(double iCount)
        {
            if (IsDividingByZero(iCount))
                throw new BusinessLogicException("No se puede dividir entre 0");
            this.X /= iCount;
            this.Y /= iCount;
            this.Z /= iCount;
        }

        public Vector GetUnit()
        {
            return this.Divide(this.Length());
        }

        public double Dot(Vector vector3d)
        {
            double result = (this.X * vector3d.X) + (this.Y * vector3d.Y) + (this.Z * vector3d.Z);
            return result;
        }

        public Vector Cross(Vector vector3d)
        {
            double x = this.Y * vector3d.Z - this.Z * vector3d.Y;
            double y = this.Z * vector3d.X - this.X * vector3d.Z;
            double z = this.X * vector3d.Y - this.Y * vector3d.X;
            return new Vector(x, y, z);
        }

        public double Length()
        {
            return Math.Sqrt(this.SquaredLength());
        }

        public double SquaredLength()
        {
            return (this.X * this.X) + (this.Y * this.Y) + (this.Z * this.Z);
        }

        public override string ToString()
        {
            return "(" + this._x + ", " + this._y + ", " + this._z + ")";
        }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }

        private bool IsDividingByZero(double number)
        {
            return (number == 0);
        }
    }
}
