namespace Propotype.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangerTailleLibelleAgence : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Agences", "Libelle", c => c.String(nullable: false, maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Agences", "Libelle", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
