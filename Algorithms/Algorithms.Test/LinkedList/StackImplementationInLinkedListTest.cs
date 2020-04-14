using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class StackImplementationInLinkedListTest
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            sut.StackPush(0);
            sut.StackPush(1);
            sut.StackPush(2);
            sut.StackPush(3);
            sut.StackPush(4);            

            var result = sut.StackPop();
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.StackPush(0);
            sut.StackPush(1);
            sut.StackPush(2);
            sut.StackPush(3);
            sut.StackPush(4);

            var result = sut.StackPeep();
            Assert.AreEqual(4, result);
        }
        
    }
}
