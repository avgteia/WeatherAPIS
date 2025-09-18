using Weather.Operations;
using Weather.Operations.Entities;

namespace Business.Tests
{
    [TestClass]
    public class SourcesTests
    {
        [TestMethod]
        public void ExecuteAllTests()
        {
            GetTest();
            GetByIdTest();
            GetByOtherTest();
            AddTest();
        }

        [TestMethod]
        public void GetTest()
        {

            List<SourcesEntity> result = null;

            result = Sources.GetService();

            Assert.IsTrue(result.Count() > 0, "No se encontraron resultados.");

        }

        [TestMethod]
        public void GetByIdTest()
        {

            var request = new SourceRequestEntity() { 
                idSource = Guid.Parse("3a220c20-c4f3-49db-8634-43380ef46de1")
            };

            var result = Sources.GetByIdService(request);
            
            Assert.IsNotNull(result, "No se encontró resultado.");
        }

        [TestMethod]
        public void GetByOtherTest()
        {

            var request = new SourceRequestEntity()
            {
                idSource = Guid.Parse("3a220c20-c4f3-49db-8634-43380ef46de1")
            };

            var result = Sources.GetByIdService(request);

            Assert.IsNotNull(result, "No se encontró resultado.");
        }

        [TestMethod]
        public void AddTest()
        {

            var request = new SourceAddDto()
            {
                idSource = Guid.NewGuid()
                , Source = string.Format("KQL-{0}",DateTime.Now.ToString("yyyyMMdd"))
                , DataBaseName = "salesforce_mx"
            };

            var result = Sources.AddService(request);

            Assert.IsTrue(result.RecordsAffected > 0, result.NonAffectionReason);
            //
        }
    }
}