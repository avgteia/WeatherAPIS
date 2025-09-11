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
        }

        [TestMethod]
        public void GetTest()
        {

            List<SourcesEntity> result = null;

            result = Sources.Get();

            Assert.IsTrue(result.Count() > 0, "No se encontraron resultados.");

        }
    }
}