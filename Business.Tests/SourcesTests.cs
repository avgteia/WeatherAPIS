using Weather.Commons.Entities;
using Weather.Operations;
using Weather.Operations.Entities;

namespace Business.Tests
{
    [TestClass]
    public class SourcesTests
    {
        private static string SourceId = Guid.NewGuid().ToString();

        [TestMethod]
        public void ExecuteAllTests()
        {
            AddTest();
            GetTest();
            GetByIdTest();
            DeleteTest();
        }

        [TestMethod]
        public void AddTest()
        {

            var request = new SourceAddDto()
            {
                idSource = Guid.Parse(SourceId)
                ,
                Source = string.Format("KQL-{0}", DateTime.Now.ToString("yyyyMMdd"))
                ,
                DataBaseName = "salesforce_mx"
            };

            var result = Sources.AddService(request);

            Assert.IsTrue(result.RecordsAffected > 0, result.NonAffectionReason);
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
                idSource = Guid.Parse(SourceId)
            };

            var result = Sources.GetByIdService(request);
            
            Assert.IsNotNull(result, "No se encontró resultado.");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var result = new NonQueryResultEntity();

            result = Sources.DeleteService(Guid.Parse(SourceId));

            Assert.IsTrue(result.RecordsAffected > 0, result.NonAffectionReason);
        }
    }
}