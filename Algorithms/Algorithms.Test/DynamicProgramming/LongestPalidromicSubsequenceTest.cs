using Algorithms.DynamicProgramming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.DynamicProgramming
{
    public class LongestPalidromicSubsequenceTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestPalidromicSubsequence();
            var test = "ABCDEDCBA";
            var lcs = sut.Find(test, 0, test.Length - 1);
            Assert.Contains("ABCDEDCBA", lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestPalidromicSubsequence();
            var test = "ABCBADOOOPQRSTUVUTSRQ";
            var lcs = sut.Find(test, 0, test.Length - 1);
            Assert.Contains("QRSTUVUTSRQ", lcs);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestPalidromicSubsequence();
            var test = "ABCBAPQRQP";
            var lcs = sut.Find(test, 0, test.Length - 1);
            Assert.AreEqual(2, lcs.Count);
            Assert.Contains("ABCBA", lcs);
            Assert.Contains("PQRQP", lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestPalidromicSubsequence();
            var test = "XXXX";
            var lcs = sut.Find(test, 0, test.Length - 1);
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("XXXX", lcs);
        }

        [Test]
        public void Test5()
        {
            var sut = new LongestPalidromicSubsequence();
            var test = "QOAGBLCKTDSCPBJAZ";
            var lcs = sut.Find(test, 0, test.Length - 1);            
            Assert.Contains("ABCDCBA", lcs);
        }
    }
}
