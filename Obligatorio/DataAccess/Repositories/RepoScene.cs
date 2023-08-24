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
    public class RepoScene : IDbSceneRepository
    {
        public RepoScene() { }

        public void AddScene(Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = SceneEntity.FromDomain(scene);
                    dbContext.SceneEntities.Add(entity);
                    dbContext.Entry(entity.Owner).State = System.Data.Entity.EntityState.Unchanged;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Este usuario ya tiene una escena creada con ese nombre");
            }
        }

        public void DeleteScene(Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = SceneEntity.FromDomain(scene);
                    dbContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Algo salió mal al borrar la escena");
            }
        }

        public void UpdateScene(Scene scene)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var pk = scene.Owner.UserName + " " + scene.Name;
                    var query = from s in dbContext.SceneEntities
                                where s.Id == pk
                                select s;
                    var sceneEntity = query.FirstOrDefault<SceneEntity>();
                    sceneEntity.LastModification = scene.LastModificationDate;
                    scene.LastRenderDate = scene.LastRenderDate;
                    sceneEntity.LookFromX = scene.LookFrom.X;
                    sceneEntity.LookFromY = scene.LookFrom.Y;
                    sceneEntity.LookFromZ = scene.LookFrom.Z;
                    sceneEntity.LookAtX = scene.LookAt.X;
                    sceneEntity.LookAtY = scene.LookAt.Y;
                    sceneEntity.LookAtZ = scene.LookAt.Z;
                    sceneEntity.Fov = scene.Fov;
                    sceneEntity.Render = scene.Render;
                    sceneEntity.Preview = scene.Preview;
                    sceneEntity.Aperture = scene.Aperture;
                    sceneEntity.Blurred = scene.Blurred;
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("No se pudieron guardar correctamente los datos de la escena");
            }
        }

        public List<Scene> GetUsersScenes(string username, IDbUserRepository ur)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    List<Scene> result = new List<Scene>();
                    var sceneEntities = dbContext.SceneEntities.Where(s => s.Owner.UserName.Equals(username)).ToList();
                    var inOrder = sceneEntities.OrderByDescending(s => s.LastModification);
                    bool existAScene = inOrder != null;
                    if (existAScene)
                    {
                        foreach (SceneEntity entity in inOrder)
                        {
                            if (SceneIsEmpty(entity))
                            {
                                var owner = ur.GetUser(entity.OwnerRefId);
                                var ownerEntity = UserEntity.FromDomain(owner);
                                entity.Owner = ownerEntity;

                                var scene = SceneEntity.ToDomain(entity);
                                result.Add(scene);
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

        public Scene GetScene(string name, string owner, IDbUserRepository ur)
        {
            using (var dbContext = new DBContext())
            {
                var pk = owner + " " + name;
                var query = from s in dbContext.SceneEntities
                            where s.Id == pk
                            select s;
                var sceneEntity = query.FirstOrDefault<SceneEntity>();
                if (SceneIsEmpty(sceneEntity))
                {
                    var ownerUser = ur.GetUser(sceneEntity.OwnerRefId);
                    var ownerEntity = UserEntity.FromDomain(ownerUser);
                    sceneEntity.Owner = ownerEntity;

                    var scene = SceneEntity.ToDomain(sceneEntity);
                    return scene;
                }
                else
                {
                    throw new DataBaseException("La escena no existe");
                }
            }
        }
        private static bool SceneIsEmpty(SceneEntity sceneEntity)
        {
            return sceneEntity != null;
        }
    }
}
