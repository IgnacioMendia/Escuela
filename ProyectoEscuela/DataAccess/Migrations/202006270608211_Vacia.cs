namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vacia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "NotaId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumno", "NotaId");
        }
    }
}
