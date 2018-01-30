namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 200),
                        MaestroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Maestroes", t => t.MaestroId, cascadeDelete: true)
                .Index(t => t.MaestroId);
            
            CreateTable(
                "dbo.Maestroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detalles", "MaestroId", "dbo.Maestroes");
            DropIndex("dbo.Detalles", new[] { "MaestroId" });
            DropTable("dbo.Maestroes");
            DropTable("dbo.Detalles");
        }
    }
}
