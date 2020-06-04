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
    public class MinimumCostTest
    {
        [Test]
        public void Test1()
        {
            var sut = new MinimumCost();
            var a = new int[5, 5];


            var lcs = sut.Find("XXXXXX", "XXXXXX");
            Assert.AreEqual(1, lcs.Count);
            Assert.Contains("XXXXXX", lcs);
        }
        
    }
}
