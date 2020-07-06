namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablasdefinitivas : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Materia", "Nombre", unique: true, name: "IX_NombreUnico");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Materia", "IX_NombreUnico");
        }
    }
}
