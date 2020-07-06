namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregotablacurso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Descripcion, unique: true, name: "IX_DocumentoUnico");
            
            AddColumn("dbo.Alumno", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumno", "CursoId");
            AddForeignKey("dbo.Alumno", "CursoId", "dbo.Curso", "Id", cascadeDelete: true);
            DropColumn("dbo.Alumno", "Curso");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumno", "Curso", c => c.Int(nullable: false));
            DropForeignKey("dbo.Alumno", "CursoId", "dbo.Curso");
            DropIndex("dbo.Curso", "IX_DocumentoUnico");
            DropIndex("dbo.Alumno", new[] { "CursoId" });
            DropColumn("dbo.Alumno", "CursoId");
            DropTable("dbo.Curso");
        }
    }
}
