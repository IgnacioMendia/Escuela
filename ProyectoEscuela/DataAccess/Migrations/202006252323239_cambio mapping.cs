namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiomapping : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Materia", name: "Nombre", newName: "Materia");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Materia", name: "Materia", newName: "Nombre");
        }
    }
}
