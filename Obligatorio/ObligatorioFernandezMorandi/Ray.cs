using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ray
    {
        private Vector _origin;
        private Vector _direction;

        public Vector Origin { get { return _origin; } set { _origin = value; } }

        public Vector Direction { get { return _direction; } set { _direction = value; } }

        public Ray(Vector givenOrigin, Vector givenDirection)
        {
            this.Origin = givenOrigin;
            this.Direction = givenDirection;
        }

        public Vector PointAt(double iPosX)
        {
            return this._origin.Add(this._direction.Multiply(iPosX));
        }
    }
}
