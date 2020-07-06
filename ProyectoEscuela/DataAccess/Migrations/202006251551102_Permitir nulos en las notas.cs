namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Permitirnulosenlasnotas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Nota", "NotaPrimerTrimestre", c => c.Double());
            AlterColumn("dbo.Nota", "NotaSegundoTrimestre", c => c.Double());
            AlterColumn("dbo.Nota", "NotaTercerTrimestre", c => c.Double());
            AlterColumn("dbo.Nota", "NotaFinal", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nota", "NotaFinal", c => c.Int(nullable: false));
            AlterColumn("dbo.Nota", "NotaTercerTrimestre", c => c.Double(nullable: false));
            AlterColumn("dbo.Nota", "NotaSegundoTrimestre", c => c.Double(nullable: false));
            AlterColumn("dbo.Nota", "NotaPrimerTrimestre", c => c.Double(nullable: false));
        }
    }
}
