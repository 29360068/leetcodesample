using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class CountAndSayTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new CountAndSay();
            
            Assert.AreEqual("1", func.Excution1(1));
            Assert.AreEqual("11", func.Excution1(2));
            Assert.AreEqual("21", func.Excution1(3));
            Assert.AreEqual("1211", func.Excution1(4));
            Assert.AreEqual("111221", func.Excution1(5));
        }
    }
}