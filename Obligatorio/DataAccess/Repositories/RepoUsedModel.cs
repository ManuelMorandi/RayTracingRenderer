using Domain;
using DataAccess.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using System.Xml.Linq;

namespace DataAccess
{
    public class RepoUsedModel : IDbUsedModelRepository
    {
        public RepoUsedModel() { }

        public void AddUsedModel(UsedModel usedmodel, Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = UsedModelEntity.FromDomain(usedmodel);
                    dbContext.UsedModelEntities.Add(entity);
                    dbContext.Entry(entity.Model.Owner).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.Entry(entity.Model.Material).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.Entry(entity.Model.Shape).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.Entry(entity.Model).State = System.Data.Entity.EntityState.Unchanged;

                    dbContext.SaveChanges();

                    AddModelToScene(entity, scene);
                }
            }
            catch
            {
                throw new DataBaseException("Algo salió mal al posicionar el modelo");
            }
        }

        public void DeleteUsedModel(UsedModel model, Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var sceneId = scene.Owner.UserName + " " + scene.Name;
                    var modelEntity = UsedModelEntity.FromDomain(model);
                    modelEntity.UsedModelId = model.Id;
                    var relationshipEntity = SceneModelEntity.FromDomain(model.Id, sceneId);
                    dbContext.Entry(modelEntity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.Entry(relationshipEntity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Algo salió mal al borrar el modelo de la escena");
            }
        }

        public List<UsedModel> GetSceneModels(string scene, string owner)
        {
            try
            {
                List<UsedModel> result = new List<UsedModel>();
                using (var dbContext = new DBContext())
                {
                    var pk = owner + " " + scene;
                    var sceneModelEntities = dbContext.SceneModelEntities.Where(s => s.SceneId.Equals(pk)).ToList();
                    foreach (var sceneModelEntity in sceneModelEntities)
                    {
                        var modelQuery = from m in dbContext.UsedModelEntities
                                         where m.UsedModelId == sceneModelEntity.UsedModelId
                                         select m;
                        var entity = modelQuery.FirstOrDefault<UsedModelEntity>();

                        var getModel = from m in dbContext.ModelEntities
                                       where m.Id == entity.ModelRefId
                                       select m;
                        var modelInEntity = getModel.FirstOrDefault<ModelEntity>();
                        var getMaterial = from m in dbContext.MaterialEntities
                                          where m.Id == modelInEntity.MaterialRefId
                                          select m;
                        var materialInEntity = getMaterial.FirstOrDefault<MaterialEntity>();
                        var getShape = from s in dbContext.SphereEntities
                                       where s.Id == modelInEntity.ShapeRefId
                                       select s;
                        var shapeInEntity = getShape.FirstOrDefault<SphereEntity>();
                        var getOwner = from u in dbContext.UserEntities
                                       where u.UserName == modelInEntity.OwnerRefId
                                       select u;
                        var ownerInEntity = getOwner.FirstOrDefault<UserEntity>();
                        modelInEntity.Owner = ownerInEntity;
                        modelInEntity.Shape = shapeInEntity;
                        modelInEntity.Material = materialInEntity;
                        entity.Model = modelInEntity;

                        var model = UsedModelEntity.ToDomain(entity);
                        result.Add(model);
                    }
                }
                return result;
            }
            catch
            {
                throw new DataBaseException("No se pudieron obtener los modelos de la escena");
            }
        }
        private void AddModelToScene(UsedModelEntity model, Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var modelId = model.UsedModelId;
                    var sceneId = scene.Owner.UserName + " " + scene.Name;
                    var relationshipEntity = SceneModelEntity.FromDomain(modelId, sceneId);
                    dbContext.SceneModelEntities.Add(relationshipEntity);
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Algo salió mal al agregar el modelo a la escena");
            }
        }
    }
}
