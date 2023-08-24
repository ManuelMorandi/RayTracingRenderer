using Domain;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Controllers
{
    public class VectorManager
    {
        public Vector CreateVector(VectorDTO dto)
        {
            return new Vector(dto.X, dto.Y, dto.Z);
        }

        public RGBVector CreateRGBVector(VectorDTO dto)
        {
            return new RGBVector(dto.X, dto.Y, dto.Z);
        }
    }
}
