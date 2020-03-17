using MyLeetCode.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class IsPalindrome125Tests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new IsPalindrome125();

            Assert.IsFalse(func.Excution1("0P"));
            Assert.IsTrue(func.Excution1(string.Empty));
            Assert.IsTrue(func.Excution1("A man, a plan, a canal: Panama"));
            Assert.IsFalse(func.Excution1("race a car"));
        }

        [TestMethod()]
        public void Excution2Test()
        {
            var func = new IsPalindrome125();

            Assert.IsFalse(func.Excution2("0P"));
            Assert.IsTrue(func.Excution2(string.Empty));
            Assert.IsTrue(func.Excution2("A man, a plan, a canal: Panama"));
            Assert.IsFalse(func.Excution2("race a car"));
        }
    }
}