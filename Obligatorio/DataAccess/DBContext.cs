using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=RendererDBConnectionString")
        { 

        }

        public DbSet<UserEntity> UserEntities { get; set; }
        public DbSet<SphereEntity> SphereEntities { get; set; }
        public DbSet<MaterialEntity> MaterialEntities { get; set; }
        public DbSet<ModelEntity> ModelEntities { get; set; }
        public DbSet<UsedModelEntity> UsedModelEntities { get; set; }
        public DbSet<SceneEntity> SceneEntities { get; set; }
        public DbSet<SceneModelEntity> SceneModelEntities { get; set; }
    }
}
