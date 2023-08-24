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
    public class RepoSphere : IDbSphereRepository
    {
        public RepoSphere() { }

        public void AddSphere(Sphere sphere)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var ownerEntity = UserEntity.FromDomain(sphere.Owner);
                    var entity = SphereEntity.FromDomain(sphere, ownerEntity);
                    dbContext.SphereEntities.Add(entity);
                    dbContext.Entry(entity.Owner).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Este usuario ya tiene una esfera creada con ese nombre");
            }
        }

        public void DeleteSphere(Sphere sphere)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var ownerEntity = UserEntity.FromDomain(sphere.Owner);
                    var entity = SphereEntity.FromDomain(sphere, ownerEntity);
                    dbContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("No se puede eliminar una esfera que forma parte de un modelo");
            }
        }

        public List<Sphere> GetUsersSpheres(string username, IDbUserRepository ur)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    List<Sphere> result = new List<Sphere>();
                    var sphereEntities = dbContext.SphereEntities.Where(s => s.Owner.UserName.Equals(username)).ToList();
                    bool existASphere = sphereEntities != null;
                    if (existASphere)
                    {
                        foreach (SphereEntity entity in sphereEntities)
                        {
                            if (SphereIsEmpty(entity))
                            {
                                var owner = ur.GetUser(entity.OwnerRefId);
                                var ownerEntity = UserEntity.FromDomain(owner);
                                entity.Owner = ownerEntity;

                                var sphere = SphereEntity.ToDomain(entity);
                                result.Add(sphere);
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

        public Sphere GetShape(string shapeName, string userName, IDbUserRepository ur)
        {
            var pk = userName + " " + shapeName;
            using (var dbContext = new DBContext())
            {
                var query = from s in dbContext.SphereEntities
                            where s.Id.Equals(pk)
                            select s;
                var sphereEntity = query.FirstOrDefault<SphereEntity>();
                if (SphereIsEmpty(sphereEntity))
                {
                    var owner = ur.GetUser(sphereEntity.OwnerRefId);
                    var ownerEntity = UserEntity.FromDomain(owner);
                    sphereEntity.Owner = ownerEntity;

                    var sphere = SphereEntity.ToDomain(sphereEntity);
                    return sphere;
                }
                else
                {
                    throw new DataBaseException("Figura no existente");
                }
            }
        }

        private static bool SphereIsEmpty(SphereEntity sphereEntity)
        {
            return sphereEntity != null;
        }

    }
}
