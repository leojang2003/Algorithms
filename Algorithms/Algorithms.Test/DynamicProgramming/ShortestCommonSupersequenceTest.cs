using Algorithms.DynamicProgramming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.DynamicProgramming
{
    public class ShortestCommonSupersequenceTest
    {
        [Test]
        public void Test1()
        {
            var sut = new ShortestCommonSupersequence();            
            var x = "AB";
            var y = "A";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(2, lcs);
        }

        [Test]
        public void Test2()
        {
            var sut = new ShortestCommonSupersequence();
            var x = "AA";
            var y = "AA";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(2, lcs);
        }

        [Test]
        public void Test3()
        {
            var sut = new ShortestCommonSupersequence();
            var x = "CBDA";
            var y = "GB";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(5, lcs);
        }

        [Test]
        public void Test4()
        {
            var sut = new ShortestCommonSupersequence();
            var x = "AB";
            var y = "AC";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(3, lcs);
        }

        [Test]
        public void Test5()
        {
            // AGGTA  B
            // GXTXAY B

            // --

            // AGGTA
            // GXTXA

            // AGGT
            // GXTX

            // AGGT 
            // GXT

            // AGG
            // GXTX

            // AGGT
            // GXTXAY
            
            // -- 
            var sut = new ShortestCommonSupersequence();
            var x = "";
            var y = "GX";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(2, lcs);
        }

        [Test]
        public void Test6()
        {
            // AGGTA  B
            // GXTXAY B

            // --

            // AGGTA
            // GXTXA

            // AGGT
            // GXTX

            // AGGT 
            // GXT

            // AGG
            // GXTX

            // AGGT
            // GXTXAY

            // -- 
            var sut = new ShortestCommonSupersequence();
            var x = "AGGTAB";
            var y = "GXTXAYB";
            var lcs = sut.Length(x, y, x.Length, y.Length);
            Assert.AreEqual(9, lcs);
        }
    }
}
