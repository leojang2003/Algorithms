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
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("XXXXXX", "XXXXXX");
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("XXXXXX", lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("XXXXX", "YYYYYY");
            Assert.AreEqual(0, lcs.Count);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("ABCDEFGHI", "ABCDIEPKP");
            Assert.Contains("ABCD", lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("ABBABAB", "BABBABBBA");
            Assert.Contains("ABBAB", lcs);
        }

        [Test]
        public void Test5()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("ABCDEFG", "DEFGOFGP");
            Assert.Contains("DEFG", lcs);
        }

        [Test]
        public void Test6()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("ABCDEFGHIJKL", "JKLONFGHPOBCD");
            Assert.AreEqual(3, lcs.Count);
            Assert.Contains("BCD", lcs);
            Assert.Contains("FGH", lcs);
            Assert.Contains("JKL", lcs);
        }

        [Test]
        public void Test7()
        {
            var sut = new LongestCommonSubstring();

            var lcs = sut.Find("ABCDEFG", "EFGOIOIOIABCDEIOK");
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("ABCDE", lcs);
        }
    }
}
