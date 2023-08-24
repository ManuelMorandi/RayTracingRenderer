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
    public class ModelEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Preview { get; set; }
        [ForeignKey("Owner")]
        public string OwnerRefId { get; set; }
        public UserEntity Owner { get; set; }
        [ForeignKey("Shape")]
        public string ShapeRefId { get; set; }
        public SphereEntity Shape { get; set; }
        [ForeignKey("Material")]
        public string MaterialRefId { get; set; }
        public MaterialEntity Material { get; set; }

        public static ModelEntity FromDomain(Model model)
        {
            var owner = UserEntity.FromDomain(model.Owner);
            var material = MaterialEntity.FromDomain(model.ModelMaterial, owner);
            var shape = SphereEntity.FromDomain(model.ModelShape, owner);
            return new ModelEntity
            {
                Id = owner.UserName + " " + model.Name,
                Name = model.Name,
                Preview = model.Preview,
                OwnerRefId = owner.UserName,
                Owner = owner,
                ShapeRefId = shape.Id,
                Shape = shape,
                MaterialRefId = material.Id,
                Material = material,
            };
        }

        public static Model ToDomain(ModelEntity entity)
        {
            var owner = UserEntity.ToDomain(entity.Owner);
            var shape = SphereEntity.ToDomain(entity.Shape);
            var material = MaterialEntity.ToDomain(entity.Material);
            return new Model
            {
                Owner = owner,
                Name = entity.Name,
                Preview = entity.Preview,
                ModelShape = shape,
                ModelMaterial = material
            };
        }
    }
}
