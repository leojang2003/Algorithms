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
            //Assert.AreEqual(array[3, 3], 1);
        }

        
    }
}
