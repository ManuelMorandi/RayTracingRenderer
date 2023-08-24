using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SceneEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Owner")]
        public string OwnerRefId { get; set; }
        public UserEntity Owner { get; set; }
        public DateTime Creation { get; set; }
        public DateTime LastModification { get; set; }
        public DateTime LastRender { get; set; }
        public double LookFromX { get; set; }
        public double LookFromY { get; set; }
        public double LookFromZ { get; set; }
        public double LookAtX { get; set; }
        public double LookAtY { get; set; }
        public double LookAtZ { get; set; }
        public int Fov { get; set; }
        public string Render { get; set; }
        public string Preview { get; set; }
        public double Aperture { get; set; }
        public bool Blurred { get; set; }

        public static SceneEntity FromDomain(Scene scene)
        {
            var owner = UserEntity.FromDomain(scene.Owner);
            return new SceneEntity
            {
                Id = owner.UserName + " " + scene.Name,
                Name = scene.Name,
                OwnerRefId = owner.UserName,
                Owner = owner,
                Creation = scene.CreationDate,
                LastModification = scene.LastModificationDate,
                LastRender = scene.LastRenderDate,
                LookFromX = scene.LookFrom.X,
                LookFromY = scene.LookFrom.Y,
                LookFromZ = scene.LookFrom.Z,
                LookAtX = scene.LookAt.X,
                LookAtY = scene.LookAt.Y,
                LookAtZ = scene.LookAt.Z,
                Fov = scene.Fov,
                Render = scene.Render,
                Preview = scene.Preview,
                Aperture = scene.Aperture,
                Blurred = scene.Blurred,
            };
        }

        public static Scene ToDomain(SceneEntity entity)
        {
            var owner = UserEntity.ToDomain(entity.Owner);
            var lookFrom = new Vector(entity.LookFromX, entity.LookFromY, entity.LookFromZ);
            var lookAt = new Vector(entity.LookAtX, entity.LookAtY, entity.LookAtZ);
            return new Scene
            {
                Owner = owner,
                Name = entity.Name,
                CreationDate = entity.Creation,
                LastModificationDate = entity.LastModification,
                LastRenderDate = entity.LastRender,
                LookFrom = lookFrom,
                LookAt = lookAt,
                Fov = entity.Fov,
                Render = entity.Render,
                Preview = entity.Preview,
                Aperture = entity.Aperture,
                Blurred = entity.Blurred,
            };
        }
    }
}
