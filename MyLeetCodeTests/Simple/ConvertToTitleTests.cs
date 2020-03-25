using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class ConvertToTitleTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new ConvertToTitle();

            Assert.AreEqual("ZY", func.Excution1(701));
            Assert.AreEqual("AA", func.Excution1(27));
            Assert.AreEqual("A", func.Excution1(1));
            Assert.AreEqual("B", func.Excution1(2));
            Assert.AreEqual("Z", func.Excution1(26));
            Assert.AreEqual("ZZ", func.Excution1(702));
            Assert.AreEqual("AAA", func.Excution1(703));
        }
    }
}