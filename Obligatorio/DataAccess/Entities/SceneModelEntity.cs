using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SceneModelEntity
    {
        [Key]
        [Column(Order = 1)]
        public int UsedModelId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string SceneId { get; set; }

        public static SceneModelEntity FromDomain(int model, string scene)
        {
            return new SceneModelEntity()
            {
                UsedModelId = model,
                SceneId = scene
            };
        }
    }
}
