using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbSphereRepository
    {
        void AddSphere(Sphere sphere);

        void DeleteSphere(Sphere sphere);

        List<Sphere> GetUsersSpheres(string username, IDbUserRepository ur);

        Sphere GetShape(string name, string username, IDbUserRepository ur);
    }
}
