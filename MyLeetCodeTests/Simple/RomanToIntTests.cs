using MyLeetCode.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class RomanToIntTests
    {
        Dictionary<string, int> targets = new Dictionary<string, int>
            {
                {"III",3 },
                {"IV",4 },
                {"IX" ,9},
                {"LVIII",58 },
                {"MCMXCIV",1994 }
            };

        [TestMethod()]
        public void Excution1Test()
        {
            RomanToInt p = new RomanToInt();

            foreach (var target in targets)
            {
                Assert.AreEqual(target.Value, p.Excution1(target.Key));
            }
        }

        [TestMethod()]
        public void Excution2Test()
        {
            RomanToInt p = new RomanToInt();

            foreach (var target in targets)
            {
                Assert.AreEqual(target.Value, p.Excution2(target.Key));
            }
        }
    }
}