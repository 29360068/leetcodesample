using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class AddBinaryTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new AddBinary();

            Assert.AreEqual("100", func.Excution1("11", "1"));
            Assert.AreEqual("10101", func.Excution1("1010", "1011"));
            Assert.AreEqual("1", func.Excution1("0", "1"));
            Assert.AreEqual("110", func.Excution1("11", "11"));
            Assert.AreEqual("1100", func.Excution1("1011", "1"));
        }
    }
}