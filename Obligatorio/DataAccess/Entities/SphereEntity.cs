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
    public class SphereEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Radius { get; set; }
        [ForeignKey("Owner")]
        public string OwnerRefId { get; set; }
        public UserEntity Owner { get; set; } 

        public static SphereEntity FromDomain(Sphere sphere, UserEntity owner)
        {
            var entity = owner;
            return new SphereEntity
            {
                Id = entity.UserName + " " + sphere.Name,
                Owner = entity,
                OwnerRefId = entity.UserName,
                Name = sphere.Name,
                Radius = sphere.Radius,
            };
        }

        public static Sphere ToDomain(SphereEntity entity)
        {
            var owner = UserEntity.ToDomain(entity.Owner);
            return new Sphere
            {
                Owner = owner,
                Name = entity.Name,
                Radius = entity.Radius,
            };
        }
    }
}
