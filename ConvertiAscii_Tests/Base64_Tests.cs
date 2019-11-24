using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertiAscii_Tests
{
    [TestClass]
    public class Base64_Tests
    {
        public object Base64Convert { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            string r = Base64Convert.Base64Convert();
            Assert.AreEqual("Q2lhbw==", r);
        }
    }
}
