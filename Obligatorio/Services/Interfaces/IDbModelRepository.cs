using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbModelRepository
    {
        void AddModel(Model model);

        void DeleteModel(Model model);

        List<Model> GetUsersModels(string username, IDbUserRepository ur, IDbSphereRepository sr, IDbMaterialRepository mr);

        Model GetModel(string name, string username, IDbUserRepository ur, IDbSphereRepository sr, IDbMaterialRepository mr);
    }
}
