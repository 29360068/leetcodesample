using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class ValidBracketsTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var fun = new ValidBrackets();

            Assert.AreEqual(true, fun.Excution1("()"));
            Assert.AreEqual(true, fun.Excution1("()[]{}"));
            Assert.AreEqual(false, fun.Excution1("(]"));
            Assert.AreEqual(false, fun.Excution1("([)]"));
            Assert.AreEqual(true, fun.Excution1("{[]}"));
            Assert.AreEqual(true, fun.Excution1("(([]){})"));
            Assert.AreEqual(true, fun.Excution1(""));
        }
    }
}