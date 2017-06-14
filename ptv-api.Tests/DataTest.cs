using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ptv_api.Tests
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void DeveloperIdNotNull()
        {
            var result = Data.DeveloperId;
            Assert.IsFalse(string.IsNullOrWhiteSpace(result));
        }
        [TestMethod]
        public void DeveloperKeyNotNull()
        {
            var result = Data.DeveloperKey;
            Assert.IsFalse(string.IsNullOrWhiteSpace(result));
        }
    }
}