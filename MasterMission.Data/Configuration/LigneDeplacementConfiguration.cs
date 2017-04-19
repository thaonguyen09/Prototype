using System.Data.Entity.ModelConfiguration;

using MasterMission.Models;

namespace Rh.Data.ModelConfiguration
{
    public class LigneDeplacementConfiguration
        : EntityTypeConfiguration<LigneDeplacement>
    {
        public LigneDeplacementConfiguration()
        {
            ToTable("LigneDeplacements");

            // Primary Key
            HasKey(t => t.Id);

            HasRequired(t => t.FeuilleDeFrais)
                .WithMany(x => x.Lignes)
                .HasForeignKey(t => t.FeuilleDeFraisId);

            Property(t => t.Date)
                .IsRequired();

            // Properties
            Property(t => t.LibelleDeDeplacement)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.NbKmVehiculeSoc)
                .IsRequired();
            Property(t => t.NbKmVehiculePerso)
                .IsRequired();

            Property(t => t.MontantIndemniteVehiPerso)
                .IsRequired();
            Property(t => t.MontantHtEntretienVehSoc)
                .IsRequired();

            Property(t => t.MontantHtHotelResto)
                .IsRequired();
            Property(t => t.MontantCarbParkPeage)
                .IsRequired();

            Property(t => t.MontantHtAutresFrais)
                .IsRequired();
            Property(t => t.MontantTvaDeductible)
                .IsRequired();
        }
    }
}
