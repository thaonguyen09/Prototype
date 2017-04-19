using System.Data.Entity.ModelConfiguration;

using MasterMission.Models;

namespace Rh.Data.ModelConfiguration
{
    public class AgenceConfiguration
        : EntityTypeConfiguration<Agence>
    {
        public AgenceConfiguration()
        {
            ToTable("Agences");

            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Libelle)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
