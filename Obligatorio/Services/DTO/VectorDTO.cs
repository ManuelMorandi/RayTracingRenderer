using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class VectorDTO
    {
        private double _x; 
        private double _y; 
        private double _z;

        public VectorDTO(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double X { get { return _x; } }
        public double Y { get { return _y; } }
        public double Z { get { return _z; } }
    }
}
