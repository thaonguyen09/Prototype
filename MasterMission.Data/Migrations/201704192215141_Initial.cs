namespace Propotype.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10),
                        Libelle = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeuilleDeFrais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        SalarieId = c.Int(nullable: false),
                        ResponsableId = c.Int(nullable: false),
                        KilometrageMois = c.Double(nullable: false),
                        CompteurDebutMois = c.Double(nullable: false),
                        DateDePaiement = c.DateTime(nullable: false),
                        ModePaiement = c.String(nullable: false, maxLength: 256),
                        ReferenceDePiece = c.String(nullable: false, maxLength: 256),
                        AgenceId = c.Int(nullable: false),
                        VehiculeId = c.Int(nullable: false),
                        VehiculePersonnel = c.Boolean(nullable: false),
                        VehiculeSociete = c.Boolean(nullable: false),
                        EtatValide = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agences", t => t.AgenceId, cascadeDelete: true)
                .ForeignKey("dbo.Salaries", t => t.ResponsableId)
                .ForeignKey("dbo.Salaries", t => t.SalarieId)
                .ForeignKey("dbo.Vehicules", t => t.VehiculeId, cascadeDelete: true)
                .Index(t => t.SalarieId)
                .Index(t => t.ResponsableId)
                .Index(t => t.AgenceId)
                .Index(t => t.VehiculeId);
            
            CreateTable(
                "dbo.LigneDeplacements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeuilleDeFraisId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        LibelleDeDeplacement = c.String(nullable: false, maxLength: 256),
                        NbKmVehiculeSoc = c.Double(nullable: false),
                        NbKmVehiculePerso = c.Double(nullable: false),
                        MontantIndemniteVehiPerso = c.Double(nullable: false),
                        MontantHtEntretienVehSoc = c.Double(nullable: false),
                        MontantHtHotelResto = c.Double(nullable: false),
                        MontantCarbParkPeage = c.Double(nullable: false),
                        MontantHtAutresFrais = c.Double(nullable: false),
                        MontantTvaDeductible = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeuilleDeFrais", t => t.FeuilleDeFraisId, cascadeDelete: true)
                .Index(t => t.FeuilleDeFraisId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identifiant = c.String(nullable: false, maxLength: 256),
                        MotDePasse = c.String(nullable: false, maxLength: 256),
                        Matricule = c.String(nullable: false, maxLength: 256),
                        Nom = c.String(nullable: false, maxLength: 256),
                        Prenom = c.String(nullable: false, maxLength: 256),
                        DateEntree = c.DateTime(nullable: false, storeType: "date"),
                        DateSortie = c.DateTime(nullable: false, storeType: "date"),
                        VehiculePersonnel = c.Int(nullable: false),
                        Profil = c.String(nullable: false, maxLength: 256),
                        AgenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agences", t => t.AgenceId, cascadeDelete: true)
                .Index(t => t.AgenceId);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlaqueMineralogique = c.String(nullable: false, maxLength: 256),
                        PuissanceFiscale = c.Double(nullable: false),
                        Kilometrage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeuilleDeFrais", "VehiculeId", "dbo.Vehicules");
            DropForeignKey("dbo.FeuilleDeFrais", "SalarieId", "dbo.Salaries");
            DropForeignKey("dbo.FeuilleDeFrais", "ResponsableId", "dbo.Salaries");
            DropForeignKey("dbo.Salaries", "AgenceId", "dbo.Agences");
            DropForeignKey("dbo.LigneDeplacements", "FeuilleDeFraisId", "dbo.FeuilleDeFrais");
            DropForeignKey("dbo.FeuilleDeFrais", "AgenceId", "dbo.Agences");
            DropIndex("dbo.Salaries", new[] { "AgenceId" });
            DropIndex("dbo.LigneDeplacements", new[] { "FeuilleDeFraisId" });
            DropIndex("dbo.FeuilleDeFrais", new[] { "VehiculeId" });
            DropIndex("dbo.FeuilleDeFrais", new[] { "AgenceId" });
            DropIndex("dbo.FeuilleDeFrais", new[] { "ResponsableId" });
            DropIndex("dbo.FeuilleDeFrais", new[] { "SalarieId" });
            DropTable("dbo.Vehicules");
            DropTable("dbo.Salaries");
            DropTable("dbo.LigneDeplacements");
            DropTable("dbo.FeuilleDeFrais");
            DropTable("dbo.Agences");
        }
    }
}
