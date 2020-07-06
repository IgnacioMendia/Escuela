namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nada : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Alumno", "NotaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumno", "NotaId", c => c.Int(nullable: false));
        }
    }
}
