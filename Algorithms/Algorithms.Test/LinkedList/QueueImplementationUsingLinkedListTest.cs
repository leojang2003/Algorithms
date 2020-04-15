using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class QueueImplementationUsingLinkedListTest
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            sut.Enqueue(0);
            sut.Enqueue(1);
            sut.Enqueue(2);
            sut.Enqueue(3);
            sut.Enqueue(4);

            sut.Dequeue();
            sut.Dequeue();
            sut.Dequeue();
            sut.Dequeue();
            
            Assert.AreEqual(4, sut.Peek());            
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Enqueue(0);
            sut.Enqueue(1);
            sut.Enqueue(2);
            sut.Enqueue(3);
            sut.Enqueue(4);

            sut.Dequeue();
            sut.Dequeue();
            sut.Dequeue();
            sut.Dequeue();
            sut.Dequeue();

            Assert.AreEqual(null, sut.Peek());

            sut.Enqueue(7);
            sut.Enqueue(8);
            sut.Enqueue(9);

            Assert.AreEqual(7, sut.Peek());

        }
    }
}
