namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArregloTablaMateria : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Materia", "IX_NombreUnico");
            AlterColumn("dbo.Materia", "Nombre", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materia", "Nombre", c => c.String());
            CreateIndex("dbo.Materia", "Nombre", unique: true, name: "IX_NombreUnico");
        }
    }
}
