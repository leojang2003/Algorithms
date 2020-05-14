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
    public class LongestIncreasingSubsequenceTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestIncreasingSubsequence();
            var input = new int[] { 0, 100, 2, 3, 4 };
            

            var lcs = sut.LIS(input, 0, input.Length, Int32.MinValue);
            Assert.AreEqual(4, lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAnyLCS("XXXXX", "XXXXX");
            Assert.AreEqual("XXXXX", lcs);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAnyLCS("XXXXX", "YYYYY");
            Assert.AreEqual("", lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAnyLCS("ABBABAB", "BABBABBBA");
            Assert.That(lcs == "ABBABB" || lcs == "ABBABA");
        }

        [Test]
        public void Test5()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAnyLCS("ABCDEFG", "AUACBCYEOFGP");
            Assert.AreEqual("ABCEFG", lcs);
        }

        [Test]
        public void Test6()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAllLCS("ABBABAB", "BABBABBBA");
            Assert.AreEqual(2, lcs.Count);
            Assert.Contains("ABBABB", lcs);
            Assert.Contains("ABBABA", lcs);
        }

        [Test]
        public void Test7()
        {
            var sut = new LongestCommonSubsequence();

            var lcs = sut.PrintAllLCS("ABCDEFG", "AUACBCYEOFGP");
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("ABCEFG", lcs);
        }
    }
}
