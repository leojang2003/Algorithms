using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    [TestFixture]
    public class RearrangeOddNodesFromEvenNodesTest
    {
        [Test]
        public void Test1()
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

            sut.RearrangeOddNodesFromEvenNodes();
            StringAssert.AreEqualIgnoringCase("0 2 4 6 8 10 12 1 3 5 7 9 11", sut.Print(sut.head));
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);

            sut.RearrangeOddNodesFromEvenNodes();
            StringAssert.AreEqualIgnoringCase("0 1", sut.Print(sut.head));
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);

            sut.RearrangeOddNodesFromEvenNodes();
            StringAssert.AreEqualIgnoringCase("0", sut.Print(sut.head));
        }

        [Test]
        public void Test4()
        {
            var sut = new SingleLinkedList();

            sut.Insert(10);
            sut.Insert(9);
            sut.Insert(8);
            sut.Insert(7);
            sut.Insert(6);
            sut.Insert(5);
            sut.Insert(4);
            sut.Insert(3);
            sut.Insert(2);
            sut.Insert(1);
            sut.Insert(0);

            sut.RearrangeOddNodesFromEvenNodes();
            StringAssert.AreEqualIgnoringCase("10 8 6 4 2 0 9 7 5 3 1", sut.Print(sut.head));
        }

        [Test]
        public void Test5()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);

            sut.RearrangeAlternatingHighLow();
            StringAssert.AreEqualIgnoringCase("0 2 1", sut.Print(sut.head));
        }

        [Test]
        public void Test6()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(3);
            sut.Insert(4);
            

            sut.RearrangeAlternatingHighLow();
            StringAssert.AreEqualIgnoringCase("0 2 1 4 3", sut.Print(sut.head));
        }
    }
}
