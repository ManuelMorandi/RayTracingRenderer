using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbUsedModelRepository
    {
        void AddUsedModel(UsedModel usedmodel, Scene scene);

        void DeleteUsedModel(UsedModel usedmodel, Scene scene);

        List<UsedModel> GetSceneModels(string scene, string owner);
    }
}
