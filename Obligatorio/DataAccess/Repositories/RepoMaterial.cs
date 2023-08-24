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
    public class RepoMaterial : IDbMaterialRepository
    {
        public RepoMaterial() { }

        public void AddMaterial(Material material)
        {
            try 
            {
                using (var dbContext = new DBContext())
                {
                    var ownerEntity = UserEntity.FromDomain(material.Owner);
                    var entity = MaterialEntity.FromDomain(material, ownerEntity);
                    dbContext.MaterialEntities.Add(entity);
                    dbContext.Entry(entity.Owner).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Este usuario ya tiene un material creado con ese nombre");
            }
        }

        public void DeleteMaterial(Material material)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var ownerEntity = UserEntity.FromDomain(material.Owner);
                    var entity = MaterialEntity.FromDomain(material, ownerEntity);
                    dbContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("No se puede eliminar un material que forma parte de un modelo");
            }
        }

        public List<Material> GetUsersMaterials(string username, IDbUserRepository ur)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    List<Material> result = new List<Material>();
                    var materialEntities = dbContext.MaterialEntities.Where(m => m.Owner.UserName.Equals(username)).ToList();
                    bool noMaterials = materialEntities != null;
                    if (noMaterials)
                    {
                        foreach (MaterialEntity entity in materialEntities)
                        {
                            if (MaterialIsEmpty(entity))
                            {
                                var owner = ur.GetUser(entity.OwnerRefId);
                                var ownerEntity = UserEntity.FromDomain(owner);
                                entity.Owner = ownerEntity;

                                var material = MaterialEntity.ToDomain(entity);
                                result.Add(material);
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

        public Material GetMaterial(string materialName, string userName, IDbUserRepository ur)
        {
            var pk = userName + " " + materialName;
            using (var dbContext = new DBContext())
            {
                var query = from m in dbContext.MaterialEntities
                            where m.Id.Equals(pk)
                            select m;
                var materialEntity = query.FirstOrDefault<MaterialEntity>();
                if (MaterialIsEmpty(materialEntity))
                {
                    var owner = ur.GetUser(materialEntity.OwnerRefId);
                    var ownerEntity = UserEntity.FromDomain(owner);
                    materialEntity.Owner = ownerEntity;

                    var material = MaterialEntity.ToDomain(materialEntity);
                    return material;
                }
                else
                {
                    throw new DataBaseException("Material no existente");
                }
            }
        }

        public RGBVector GetColorFromDescription(string description)
        {
            char[] delimiterChars = { ' ' };
            string[] values = description.Split(delimiterChars);
            const int MaxColorValue = 255;
            double red = Convert.ToDouble(values[1]) / MaxColorValue;
            double green = Convert.ToDouble(values[3]) / MaxColorValue;
            double blue = Convert.ToDouble(values[5]) / MaxColorValue;
            return new RGBVector(red, green, blue);
        }

        private static bool MaterialIsEmpty(MaterialEntity materialEntity)
        {
            return materialEntity != null;
        }
    }
}
