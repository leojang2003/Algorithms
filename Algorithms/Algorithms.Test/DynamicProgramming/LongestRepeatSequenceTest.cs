using Algorithms.DynamicProgramming;
using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.DynamicProgramming
{
    public class LongestRepeatSequenceTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestRepeatSequence();
            var test = "ABAB";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestRepeatSequence();
            var test = "ATACTCGCA";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestRepeatSequence();
            var test = "ABCDACBD";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestRepeatSequence();
            var test = "CABQACQB";
            var result = sut.Length(test, test.Length, test.Length);
            Assert.AreEqual(2, result);
        }
    }
}
