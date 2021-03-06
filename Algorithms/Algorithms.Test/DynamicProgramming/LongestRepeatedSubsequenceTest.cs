﻿using Algorithms.DynamicProgramming;
using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.DynamicProgramming
{
    public class LongestRepeatedSubsequenceTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABAB";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ATACTCGCA";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABCDACBD";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "CABQACQB";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test5()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABAB";
            var lookup = new Dictionary<string, int>();
            var result = sut.LengthNoDupeCalc(test, test.Length, test.Length, lookup);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test6()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ATACTCGCA";
            var lookup = new Dictionary<string, int>();
            var result = sut.LengthNoDupeCalc(test, test.Length, test.Length, lookup);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test7()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABCDACBD";
            var lookup = new Dictionary<string, int>();
            var result = sut.LengthNoDupeCalc(test, test.Length, test.Length, lookup);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test8()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "CABQACQB";
            var lookup = new Dictionary<string, int>();
            var result = sut.LengthNoDupeCalc(test, test.Length, test.Length, lookup);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test9()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABCOABCXQRFGQRF";
            var lookup = new Dictionary<string, List<string>>();
            var lrs = new HashSet<string>();
            var result = sut.PrintAll(test, test.Length, test.Length, lookup, lrs);
            Assert.AreEqual(1, result.Count);
            Assert.Contains("ABCQRF", result);
        }

        [Test]
        public void Test10()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "YA1234567AX";
            var lookup = new Dictionary<string, List<string>>();
            var lrs = new HashSet<string>();
            var result = sut.PrintAll(test, test.Length, test.Length, lookup, lrs);
            Assert.AreEqual(1, result.Count);
            Assert.Contains("A", result);
        }

        [Test]
        public void Test11()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "ABA";
            var lookup = new Dictionary<string, List<string>>();
            var lrs = new HashSet<string>();
            var result = sut.PrintAll(test, test.Length, test.Length, lookup, lrs);
            Assert.AreEqual(1, result.Count);
            Assert.Contains("A", result);
        }

        [Test]
        public void Test12()
        {
            var sut = new LongestRepeatedSubsequence();
            var test = "QARBFCOAQBRCF";
            var lookup = new Dictionary<string, List<string>>();
            var lrs = new HashSet<string>();
            var result = sut.PrintAll(test, test.Length, test.Length, lookup, lrs);
            Assert.AreEqual(8, result.Count);
            Assert.Contains("ABC", result);
        }
    }
}
