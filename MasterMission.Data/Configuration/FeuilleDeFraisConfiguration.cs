using System.Data.Entity.ModelConfiguration;

using MasterMission.Models;

namespace Rh.Data.ModelConfiguration
{
    public class FeuilleDeFraisConfiguration
        : EntityTypeConfiguration<FeuilleDeFrais>
    {
        public FeuilleDeFraisConfiguration()
        {
            ToTable("FeuilleDeFrais");

            // Primary Key
            HasKey(t => t.Id);

            Property(t => t.DateDebut)
                .IsRequired();
            Property(t => t.DateFin)
                .IsRequired();
            Property(t => t.DateDePaiement)
                .IsRequired();

            Property(t => t.KilometrageMois)
                .IsRequired();
            Property(t => t.CompteurDebutMois)
                .IsRequired();

            // Properties
            Property(t => t.ModePaiement)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.ReferenceDePiece)
                .IsRequired()
                .HasMaxLength(256);

            HasRequired(t => t.Agence)
                .WithMany()
                .HasForeignKey(t => t.AgenceId);

            HasRequired(t => t.Salarie)
                .WithMany()
                .HasForeignKey(t => t.SalarieId)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.Responsable)
                .WithMany()
                .HasForeignKey(t => t.ResponsableId)
                .WillCascadeOnDelete(false);

            Property(t => t.VehiculePersonnel)
                .IsRequired();
            Property(t => t.VehiculeSociete)
                .IsRequired();
            Property(t => t.EtatValide)
                .IsRequired();
        }
    }
}
