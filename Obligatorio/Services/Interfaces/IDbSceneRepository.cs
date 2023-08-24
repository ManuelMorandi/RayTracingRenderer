using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbSceneRepository
    {
        void AddScene(Scene scene);

        void DeleteScene(Scene scene);

        void UpdateScene(Scene scene);

        List<Scene> GetUsersScenes(string username, IDbUserRepository ur);

        Scene GetScene(string name, string username, IDbUserRepository ur);
    }
}
