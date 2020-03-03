using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class LongestCommonPrefixTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var fun = new LongestCommonPrefix();

            Assert.AreEqual("fl", fun.Excution1(new string[] { "flower", "flow", "flight" }));

            Assert.AreEqual(string.Empty, fun.Excution1(new string[] { "dog", "racecar", "car" }));

            Assert.AreEqual(string.Empty, fun.Excution1(new string[] { }));
        }
    }
}