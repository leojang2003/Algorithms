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
    public class _01KnapsackTest
    {
        [Test]
        public void Test1()
        {
            var sut = new _01Knapsack();
            int[] A = new int[6] { 20, 5, 10, 40, 15, 25 };
            int[] W = new int[6] {1, 2, 3, 8, 7, 4 };
            int threshold = 10;
            var max = sut.Maximum(A, W, 0, threshold);
            Assert.AreEqual(60, max);
        }

        
    }
}
