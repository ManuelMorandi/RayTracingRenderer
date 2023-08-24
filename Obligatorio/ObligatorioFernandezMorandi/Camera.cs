using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Camera : ICamera
    {
        private Vector _lowerLeftCorner;
        private Vector _horizontal;
        private Vector _vertical;
        private Vector _origin;

        public Vector LowerLeftCorner { get { return _lowerLeftCorner; } set { _lowerLeftCorner = value; } }

        public Vector Horizontal { get { return _horizontal; } set { _horizontal = value; } }

        public Vector Vertical { get { return _vertical; } set { _vertical = value; } }

        public Vector Origin { get { return _origin; } set { _origin = value; } }

        public Camera(Vector lookFrom, Vector lookAt, Vector up, int fov, int aspectRatio)
        {
            double theta = fov * Math.PI / 180; 
            double heightHalf = Math.Tan(theta / 2); 
            double widthHalf = aspectRatio * heightHalf; 
            this.Origin = lookFrom; 
            Vector vectorW = lookFrom.Subtract(lookAt).GetUnit(); 
            Vector vectorU = up.Cross(vectorW).GetUnit(); 
            Vector vectorV = vectorW.Cross(vectorU); 
            this.LowerLeftCorner = this.Origin.Subtract(vectorU.Multiply(widthHalf)).Subtract(vectorV.Multiply(heightHalf)).Subtract(vectorW); 
            this.Horizontal = vectorU.Multiply(2 * widthHalf); 
            this.Vertical = vectorV.Multiply(2 * heightHalf); 
        }

        public Ray GetRay(double u, double v) 
        {
            Vector horizontalPosition = this.Horizontal.Multiply(u); 
            Vector verticalPosition = this.Vertical.Multiply(v); 
            return new Ray(this.Origin, this.LowerLeftCorner.Add(horizontalPosition.Add(verticalPosition)).Subtract(this.Origin)); 
        }
    }
}
