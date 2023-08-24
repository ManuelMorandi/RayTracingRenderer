using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbMaterialRepository
    {
        void AddMaterial(Material material);

        void DeleteMaterial(Material material);

        List<Material> GetUsersMaterials(string username, IDbUserRepository ur);

        Material GetMaterial(string name, string username, IDbUserRepository ur);

        RGBVector GetColorFromDescription(string username);
    }
}
