using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MergeTwoListsTests
    {
        private MergeTwoLists.ListNode CreateLink(List<int> values)
        {
            var root = new MergeTwoLists.ListNode(values[0]);
            var current = root;
            for (int i = 1; i < values.Count; i++, current = current.next)
            {
                current.next = new MergeTwoLists.ListNode(values[i]);
            }
            return root;
        }

        private bool AreEqual(MergeTwoLists.ListNode l, List<int> values)
        {
            if (l == null) return false;

            for (int i = 0; i < values.Count && l != null; i++, l = l.next)
            {
                if (l.val != values[i])
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MergeTwoLists();

            var result = func.Excution1(CreateLink(new List<int> { 1, 2, 4 }), CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 1, 2, 3, 4, 4 }));

            result = func.Excution1(null, CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4 }));

            result = func.Excution1(CreateLink(new List<int> { 1, 3, 4 }), null);

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4 }));

            result = func.Excution1(CreateLink(new List<int> { 1, 3, 4 }), CreateLink(new List<int> { 1 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 1, 3, 4 }));

            result = func.Excution1(CreateLink(new List<int> { 5 }), CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4, 5 }));

            result = func.Excution1(CreateLink(new List<int> { -10, -9, -6, -4, 1, 9, 9 }), CreateLink(new List<int> { -5, -3, 0, 7, 8, 8 }));

            Assert.IsTrue(AreEqual(result, new List<int> { -10, -9, -6, -5, -4, -3, 0, 1, 7, 8, 8, 9, 9 }));
        }

        [TestMethod()]
        public void Excution2Test()
        {
            var func = new MergeTwoLists();

            var result = func.Excution2(CreateLink(new List<int> { 1, 2, 4 }), CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 1, 2, 3, 4, 4 }));

            result = func.Excution2(null, CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4 }));

            result = func.Excution2(CreateLink(new List<int> { 1, 3, 4 }), null);

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4 }));

            result = func.Excution2(CreateLink(new List<int> { 1, 3, 4 }), CreateLink(new List<int> { 1 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 1, 3, 4 }));

            result = func.Excution2(CreateLink(new List<int> { 5 }), CreateLink(new List<int> { 1, 3, 4 }));

            Assert.IsTrue(AreEqual(result, new List<int> { 1, 3, 4, 5 }));

            result = func.Excution2(CreateLink(new List<int> { -10, -9, -6, -4, 1, 9, 9 }), CreateLink(new List<int> { -5, -3, 0, 7, 8, 8 }));

            Assert.IsTrue(AreEqual(result, new List<int> { -10, -9, -6, -5, -4, -3, 0, 1, 7, 8, 8, 9, 9 }));
        }
    }
}