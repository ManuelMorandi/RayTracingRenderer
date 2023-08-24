using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class MaterialEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Red { get; set; }
        public double Green { get; set; }
        public double Blue { get; set; }
        public double Roughness { get; set; }
        public string Type { get; set; }
        [ForeignKey("Owner")]
        public string OwnerRefId { get; set; }
        public UserEntity Owner { get; set; }

        public static MaterialEntity FromDomain(Material material, UserEntity owner)
        {
            var entity = owner;
            var color = material.GetColor();
            var roughness = material.GetRoughness();
            return new MaterialEntity()
            {
                Id = entity.UserName + " " + material.Name,
                Owner = entity,
                OwnerRefId = entity.UserName,
                Name = material.Name,
                Red = color.X,
                Green = color.Y,
                Blue = color.Z,
                Roughness = roughness,
                Type = material.GetType().Name,
            };
        }

        public static Material ToDomain(MaterialEntity entity)
        {
            var owner = UserEntity.ToDomain(entity.Owner);
            switch (entity.Type)
            {
                case "Metallic":
                    return new Metallic()
                    {
                        Owner = owner,
                        Name = entity.Name,
                        Color = new RGBVector(entity.Red, entity.Green, entity.Blue),
                        Roughness = entity.Roughness,
                    };
                    break;
                default:
                    return new Lambertian()
                    {
                        Owner = owner,
                        Name = entity.Name,
                        Color = new RGBVector(entity.Red, entity.Green, entity.Blue),
                    };
                    break;
            }
        }
    }
}
