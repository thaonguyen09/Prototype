
using System.Data.Entity;

namespace MasterMission.Data
{
    public class DbInitializer
        : DropCreateDatabaseAlways<MasterDbContext>
    {
        protected override void Seed(MasterDbContext context)
        {
        }
    }
}
