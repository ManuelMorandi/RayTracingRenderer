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
    public class UsedModelEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsedModelId { get; set; }
        public double PlaceX { get; set; }
        public double PlaceY { get; set; }
        public double PlaceZ { get; set; }
        [ForeignKey("Model")]
        public string ModelRefId { get; set; }
        public ModelEntity Model { get; set; }

        public static UsedModelEntity FromDomain(UsedModel model)
        {
            var modelEntity = ModelEntity.FromDomain(model.SelectedModel);
            return new UsedModelEntity
            {
                PlaceX = model.Place.X,
                PlaceY = model.Place.Y,
                PlaceZ = model.Place.Z,
                ModelRefId = modelEntity.Id,
                Model = modelEntity
            };
        }

        public static UsedModel ToDomain(UsedModelEntity entity)
        {
            var model = ModelEntity.ToDomain(entity.Model);
            var x = entity.PlaceX;
            var y = entity.PlaceY;
            var z = entity.PlaceZ;
            var place = new Vector(x, y, z);
            return new UsedModel
            {
                Id = entity.UsedModelId,
                SelectedModel = model,
                Place = place
            };
        }
    }
}
