using Algorithms.DynamicProgramming;
using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class LongestCommonSubstringTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestCommonSequence();

            //   X A D F G F
            // A 0 1 1 1 1 1
            // E 0 1 1 1 1 1
            // D 0 1 2 2 2 2
            // E 0 1 2 2 2 2
            // G 0 1 2 2 3 3
            // F 0 1 2 3 3 4

            var lcs = sut.PrintAnyLCS("XADFGF", "AEDEGF");
            Assert.AreEqual("ADGF", lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAnyLCS("XXXXX", "XXXXX");
            Assert.AreEqual("XXXXX", lcs);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAnyLCS("XXXXX", "YYYYY");
            Assert.AreEqual("", lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAnyLCS("ABBABAB", "BABBABBBA");
            Assert.That(lcs == "ABBABB" || lcs == "ABBABA");
        }

        [Test]
        public void Test5()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAnyLCS("ABCDEFG", "AUACBCYEOFGP");
            Assert.AreEqual("ABCEFG", lcs);
        }

        [Test]
        public void Test6()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAllLCS("ABBABAB", "BABBABBBA");
            Assert.AreEqual(2, lcs.Count);
            Assert.Contains("ABBABB", lcs);
            Assert.Contains("ABBABA", lcs);
        }

        [Test]
        public void Test7()
        {
            var sut = new LongestCommonSequence();

            var lcs = sut.PrintAllLCS("ABCDEFG", "AUACBCYEOFGP");
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("ABCEFG", lcs);
        }
    }
}
