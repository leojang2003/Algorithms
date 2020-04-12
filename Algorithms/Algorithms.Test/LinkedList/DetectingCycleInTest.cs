using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class DetectingCycleInTest
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            var node1 = new Node(0);
            var node2 = new Node(1);
            var node3 = new Node(2);
            var node4 = new Node(3);
            var node5 = new Node(4);
            var node6 = new Node(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node3;

            sut.head = node1;

            var result = sut.IsCycle();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            var node1 = new Node(0);
            var node2 = new Node(1);
            
            node1.next = node2;
            node2.next = node1;

            sut.head = node1;

            var result = sut.IsCycle();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(3);
            sut.Insert(4);
            sut.Insert(5);
            sut.Insert(6);
            sut.Insert(7);
            sut.Insert(8);
            sut.Insert(9);
            sut.Insert(10);
            sut.Insert(11);
            sut.Insert(12);

            var result = sut.IsCycle();
            Assert.IsFalse(result);
        }

        [Test]
        public void Test4()
        {
            var sut = new SingleLinkedList();

            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);

            var result = sut.IsCycle();
            Assert.IsFalse(result);
        }
    }
}
