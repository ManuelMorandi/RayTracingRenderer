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
    public class RepoModel : IDbModelRepository
    {
        public RepoModel() { }

        public void AddModel(Model model)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = ModelEntity.FromDomain(model);
                    dbContext.ModelEntities.Add(entity);
                    dbContext.Entry(entity.Owner).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.Entry(entity.Shape).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.Entry(entity.Material).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Este usuario ya tiene un modelo creado con ese nombre");
            }
        }

        public void DeleteModel(Model model)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = ModelEntity.FromDomain(model);
                    dbContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("No se puede eliminar un modelo que forma parte de una escena");
            }
        }

        public List<Model> GetUsersModels(string username, IDbUserRepository ur, IDbSphereRepository sr, IDbMaterialRepository mr)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    List<Model> result = new List<Model>();
                    var modelEntities = dbContext.ModelEntities.Where(s => s.Owner.UserName.Equals(username)).ToList();
                    bool existAUsedModel = modelEntities != null;
                    if (existAUsedModel)
                    {
                        foreach (ModelEntity entity in modelEntities)
                        {
                            if (ModelIsEmpty(entity))
                            {
                                var owner = ur.GetUser(entity.OwnerRefId);
                                var ownerEntity = UserEntity.FromDomain(owner);
                                entity.Owner = ownerEntity;
                                var shapeInfo = entity.ShapeRefId.Split(' ');
                                var shapeName = "";
                                for (int i = 1; i < shapeInfo.Length; i++)
                                {
                                    shapeName += shapeInfo[i] + " ";
                                }
                                shapeName.Trim();
                                var sphere = sr.GetShape(shapeName, owner.UserName, ur);
                                var sphereEntity = SphereEntity.FromDomain(sphere, ownerEntity);
                                entity.Shape = sphereEntity;
                                var materialInfo = entity.MaterialRefId.Split(' ');
                                var materialName = "";
                                for (int i = 1; i < materialInfo.Length; i++)
                                {
                                    materialName += materialInfo[i] + " ";
                                }
                                materialName.Trim();
                                var material = mr.GetMaterial(materialName, owner.UserName, ur);
                                var materialEntity = MaterialEntity.FromDomain(material, ownerEntity);
                                entity.Material = materialEntity;

                                var model = ModelEntity.ToDomain(entity);
                                result.Add(model);
                            }
                        }
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                throw new DataBaseException(e.Message);
            }
        }
        public Model GetModel(string modelName, string userName, IDbUserRepository ur, IDbSphereRepository sr, IDbMaterialRepository mr)
        {
            var pk = userName + " " + modelName;
            using (var dbContext = new DBContext())
            {
                var query = from s in dbContext.ModelEntities
                            where s.Id.Equals(pk)
                            select s;
                var modelEntity = query.FirstOrDefault<ModelEntity>();
                if (ModelIsEmpty(modelEntity))
                {
                    var owner = ur.GetUser(modelEntity.OwnerRefId);
                    var ownerEntity = UserEntity.FromDomain(owner);
                    modelEntity.Owner = ownerEntity;
                    var shapeInfo = modelEntity.ShapeRefId.Split(' ');
                    var shapeName = "";
                    for (int i = 1; i < shapeInfo.Length; i++)
                    {
                        shapeName += shapeInfo[i] + " ";
                    }
                    shapeName.Trim();
                    var sphere = sr.GetShape(shapeName, owner.UserName, ur);
                    var sphereEntity = SphereEntity.FromDomain(sphere, ownerEntity);
                    modelEntity.Shape = sphereEntity;
                    var materialInfo = modelEntity.MaterialRefId.Split(' ');
                    var materialName = "";
                    for (int i = 1; i < materialInfo.Length; i++)
                    {
                        materialName += materialInfo[i] + " ";
                    }
                    materialName.Trim();
                    var material = mr.GetMaterial(materialName, owner.UserName, ur);
                    var materialEntity = MaterialEntity.FromDomain(material, ownerEntity);
                    modelEntity.Material = materialEntity;

                    var model = ModelEntity.ToDomain(modelEntity);
                    return model;
                }
                else
                {
                    throw new DataBaseException("Modelo no existente");
                }
            }
        }

        private static bool ModelIsEmpty(ModelEntity modelEntity)
        {
            return modelEntity != null;
        }
    }
}
