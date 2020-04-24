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
    public class LongestCommonSequencePrintAllTest
    {
        [Test]
        public void Test1()
        {
            var sut = new LongestCommonSequencePrintAll();

            var lcs = sut.Print("XADFGF", "AEDEGF");            
            Assert.AreEqual("ADGF", lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new LongestCommonSequencePrintAll();

            var lcs = sut.Print("XXXXX", "XXXXX");
            Assert.AreEqual("XXXXX", lcs);
        }

        [Test]
        public void Test3()
        {
            var sut = new LongestCommonSequencePrintAll();

            var lcs = sut.Print("XXXXX", "YYYYY");
            Assert.AreEqual("", lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new LongestCommonSequencePrintAll();

            var lcs = sut.Print("ABBABAB", "BABBABBBA");
            Assert.AreEqual("ABBABA", lcs);
        }


    }
}
