namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterialEntities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Red = c.Double(nullable: false),
                        Green = c.Double(nullable: false),
                        Blue = c.Double(nullable: false),
                        Roughness = c.Double(nullable: false),
                        Type = c.String(),
                        OwnerRefId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserEntities", t => t.OwnerRefId)
                .Index(t => t.OwnerRefId);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Creation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.ModelEntities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Preview = c.String(),
                        OwnerRefId = c.String(maxLength: 128),
                        ShapeRefId = c.String(maxLength: 128),
                        MaterialRefId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaterialEntities", t => t.MaterialRefId)
                .ForeignKey("dbo.UserEntities", t => t.OwnerRefId)
                .ForeignKey("dbo.SphereEntities", t => t.ShapeRefId)
                .Index(t => t.OwnerRefId)
                .Index(t => t.ShapeRefId)
                .Index(t => t.MaterialRefId);
            
            CreateTable(
                "dbo.SphereEntities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Radius = c.Double(nullable: false),
                        OwnerRefId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserEntities", t => t.OwnerRefId)
                .Index(t => t.OwnerRefId);
            
            CreateTable(
                "dbo.SceneEntities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        OwnerRefId = c.String(maxLength: 128),
                        Creation = c.DateTime(nullable: false),
                        LastModification = c.DateTime(nullable: false),
                        LastRender = c.DateTime(nullable: false),
                        LookFromX = c.Double(nullable: false),
                        LookFromY = c.Double(nullable: false),
                        LookFromZ = c.Double(nullable: false),
                        LookAtX = c.Double(nullable: false),
                        LookAtY = c.Double(nullable: false),
                        LookAtZ = c.Double(nullable: false),
                        Fov = c.Int(nullable: false),
                        Render = c.String(),
                        Preview = c.String(),
                        Aperture = c.Double(nullable: false),
                        Blurred = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserEntities", t => t.OwnerRefId)
                .Index(t => t.OwnerRefId);
            
            CreateTable(
                "dbo.SceneModelEntities",
                c => new
                    {
                        UsedModelId = c.Int(nullable: false),
                        SceneId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UsedModelId, t.SceneId });
            
            CreateTable(
                "dbo.UsedModelEntities",
                c => new
                    {
                        UsedModelId = c.Int(nullable: false, identity: true),
                        PlaceX = c.Double(nullable: false),
                        PlaceY = c.Double(nullable: false),
                        PlaceZ = c.Double(nullable: false),
                        ModelRefId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UsedModelId)
                .ForeignKey("dbo.ModelEntities", t => t.ModelRefId)
                .Index(t => t.ModelRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsedModelEntities", "ModelRefId", "dbo.ModelEntities");
            DropForeignKey("dbo.SceneEntities", "OwnerRefId", "dbo.UserEntities");
            DropForeignKey("dbo.ModelEntities", "ShapeRefId", "dbo.SphereEntities");
            DropForeignKey("dbo.SphereEntities", "OwnerRefId", "dbo.UserEntities");
            DropForeignKey("dbo.ModelEntities", "OwnerRefId", "dbo.UserEntities");
            DropForeignKey("dbo.ModelEntities", "MaterialRefId", "dbo.MaterialEntities");
            DropForeignKey("dbo.MaterialEntities", "OwnerRefId", "dbo.UserEntities");
            DropIndex("dbo.UsedModelEntities", new[] { "ModelRefId" });
            DropIndex("dbo.SceneEntities", new[] { "OwnerRefId" });
            DropIndex("dbo.SphereEntities", new[] { "OwnerRefId" });
            DropIndex("dbo.ModelEntities", new[] { "MaterialRefId" });
            DropIndex("dbo.ModelEntities", new[] { "ShapeRefId" });
            DropIndex("dbo.ModelEntities", new[] { "OwnerRefId" });
            DropIndex("dbo.MaterialEntities", new[] { "OwnerRefId" });
            DropTable("dbo.UsedModelEntities");
            DropTable("dbo.SceneModelEntities");
            DropTable("dbo.SceneEntities");
            DropTable("dbo.SphereEntities");
            DropTable("dbo.ModelEntities");
            DropTable("dbo.UserEntities");
            DropTable("dbo.MaterialEntities");
        }
    }
}
