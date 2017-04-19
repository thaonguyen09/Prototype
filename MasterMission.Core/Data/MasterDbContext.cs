
using System.Data.Entity;

using MasterMission.Models;

namespace MasterMission.Core
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext() :
            base("MasterDbContext")
        { }

        public DbSet<Agence> Agences { get; set; }
        public DbSet<FeuilleDeFrais> FeuillesDeFrais { get; set; }
        public DbSet<LigneDeplacement> LignesDeDepalacement { get; set; }
        public DbSet<Salarie> Salaries { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
    }
}