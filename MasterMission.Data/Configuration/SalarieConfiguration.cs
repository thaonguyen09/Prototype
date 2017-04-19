using System.Data.Entity.ModelConfiguration;

using MasterMission.Models;

namespace Rh.Data.ModelConfiguration
{
    public class SalarieConfiguration
        : EntityTypeConfiguration<Salarie>
    {
        public SalarieConfiguration()
        {
            ToTable("Salaries");

            // Primary Key
            HasKey(t => t.Id);
            
            // Properties
            Property(t => t.Identifiant)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.MotDePasse)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Matricule)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Nom)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Prenom)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.DateEntree)
                .IsRequired()
                .HasColumnType("Date");

            Property(t => t.DateSortie)
                .IsRequired()
                .HasColumnType("Date");

            Property(t => t.VehiculePersonnel)
                .IsRequired();

            Property(t => t.Profil)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
