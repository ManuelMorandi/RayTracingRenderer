using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BlurredCamera : ICamera
    {
        private Vector _lowerLeftCorner;
        private Vector _horizontal;
        private Vector _vertical;
        private Vector _origin;
        private double _lensRadius;
        private Vector _vectorU;
        private Vector _vectorV;

        public Vector LowerLeftCorner { get { return _lowerLeftCorner; } set { _lowerLeftCorner = value; } }

        public Vector Horizontal { get { return _horizontal; } set { _horizontal = value; } }

        public Vector Vertical { get { return _vertical; } set { _vertical = value; } }

        public Vector Origin { get { return _origin; } set { _origin = value; } }

        public double LensRadius { get { return _lensRadius; } set { _lensRadius = value; } }

        public Vector VectorU { get { return _vectorU; } set { _vectorU = value; } }

        public Vector VectorV { get { return _vectorV; } set { _vectorV = value; } }

        public BlurredCamera(Vector lookFrom, Vector lookAt, Vector up, int fov, int aspectRatio, double aperture, double focalDistance)
        {
            this._lensRadius = aperture / 2;
            double theta = (fov * Math.PI) / 180;
            double heightHalf = Math.Tan(theta / 2);
            double widthHalf = aspectRatio * heightHalf;
            this.Origin = lookFrom;
            Vector vectorW = lookFrom.Subtract(lookAt).GetUnit();
            this._vectorU = up.Cross(vectorW).GetUnit();
            this._vectorV = vectorW.Cross(_vectorU);
            _lowerLeftCorner = this._origin
              .Subtract(_vectorU.Multiply(widthHalf * focalDistance))
              .Subtract(_vectorV.Multiply(heightHalf * focalDistance))
              .Subtract(vectorW.Multiply(focalDistance));
            this.Horizontal = _vectorU.Multiply(2 * widthHalf * focalDistance);
            this.Vertical = _vectorV.Multiply(2 * heightHalf * focalDistance);
        }

        public Ray GetRay(double u, double v)
        {
            RandomUnitSphereProvider randomUnitSphere = new RandomUnitSphereProvider();
            var vectorRandom = randomUnitSphere.GetRandomInUnitSphere().Multiply(this._lensRadius);
            var vectorOffset = this._vectorU.Multiply(vectorRandom.X).Add(this._vectorV.Multiply(vectorRandom.Y));
            var horizontalPosition = this._horizontal.Multiply(u);
            var verticalPosition = this._vertical.Multiply(v);
            return new Ray(
              this._origin.Add(vectorOffset),
              this._lowerLeftCorner
                .Add(horizontalPosition.Add(verticalPosition))
                .Subtract(this._origin)
                .Subtract(vectorOffset)
            );
        }
    }
}
