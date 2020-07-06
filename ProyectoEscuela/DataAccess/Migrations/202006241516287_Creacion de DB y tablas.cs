namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreaciondeDBytablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Curso = c.Int(nullable: false),
                        Documento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Documento, unique: true, name: "IX_DocumentoUnico");

            CreateTable(
                "dbo.Materia",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                })
                .PrimaryKey(t => t.Id);
                
            
            CreateTable(
                "dbo.Nota",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotaPrimerTrimestre = c.Double(nullable: false),
                        NotaSegundoTrimestre = c.Double(nullable: false),
                        NotaTercerTrimestre = c.Double(nullable: false),
                        NotaFinal = c.Int(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Materia", t => t.MateriaId, cascadeDelete: true)
                .Index(t => t.AlumnoId)
                .Index(t => t.MateriaId);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Documento = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materia", t => t.MateriaId, cascadeDelete: true)
                .Index(t => t.Documento, unique: true, name: "IX_DocumentoUnico")
                .Index(t => t.MateriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profesor", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Nota", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Nota", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.Profesor", new[] { "MateriaId" });
            DropIndex("dbo.Profesor", "IX_DocumentoUnico");
            DropIndex("dbo.Nota", new[] { "MateriaId" });
            DropIndex("dbo.Nota", new[] { "AlumnoId" });
            DropIndex("dbo.Materia", "IX_NombreUnico");
            DropIndex("dbo.Alumno", "IX_DocumentoUnico");
            DropTable("dbo.Profesor");
            DropTable("dbo.Nota");
            DropTable("dbo.Materia");
            DropTable("dbo.Alumno");
        }
    }
}
