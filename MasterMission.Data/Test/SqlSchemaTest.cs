
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Xml;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterMission.Data.Tests
{
    [TestClass]
    public class SqlSchemaTest
    {
        MasterDbContext _context;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Database.SetInitializer(new DbInitializer());
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new MasterDbContext();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
        }

        [TestMethod]
        public void WriteEdmxFileTest()
        {
            var settings = new XmlWriterSettings
            {
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(@"..\..\..\MasterMission.Core\Data\MasterMission.edmx", settings))
            {
                EdmxWriter.WriteEdmx(_context, writer);
            }
        }
    }
}
