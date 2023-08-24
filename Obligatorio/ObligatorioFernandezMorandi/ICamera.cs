using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICamera
    {
        Ray GetRay(double u, double v);
    }
}
