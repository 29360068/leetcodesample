using MyLeetCode.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class LengthOfLastWordTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new LengthOfLastWord();

            Assert.AreEqual(3, func.Excution1("   xxx   ppp    "));
            Assert.AreEqual(5, func.Excution1("Hello World"));
            Assert.AreEqual(2, func.Excution1("pp vv xx"));
            Assert.AreEqual(0, func.Excution1(""));
            Assert.AreEqual(3, func.Excution1("ppp"));
        }

        [TestMethod()]
        public void Excution2Test()
        {
            var func = new LengthOfLastWord();

            Assert.AreEqual(3, func.Excution2("   xxx   ppp    "));
            Assert.AreEqual(5, func.Excution2("Hello World"));
            Assert.AreEqual(2, func.Excution2("pp vv xx"));
            Assert.AreEqual(0, func.Excution2(""));
            Assert.AreEqual(3, func.Excution2("ppp"));
        }
    }
}