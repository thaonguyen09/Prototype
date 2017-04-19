using System.Data.Entity.ModelConfiguration;

using MasterMission.Models;

namespace Rh.Data.ModelConfiguration
{
    public class VehiculeConfiguration
        : EntityTypeConfiguration<Vehicule>
    {
        public VehiculeConfiguration()
        {
            ToTable("Vehicules");

            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.PlaqueMineralogique)
                .IsRequired()
                .HasMaxLength(256);

            Property(t => t.Kilometrage)
                .IsRequired();
            Property(t => t.PuissanceFiscale)
                .IsRequired();
        }
    }
}
