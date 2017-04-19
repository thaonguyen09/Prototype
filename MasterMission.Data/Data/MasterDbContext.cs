
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Reflection;

namespace MasterMission.Data
{
    public class MasterDbContext
        : Core.MasterDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
