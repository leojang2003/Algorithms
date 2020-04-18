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
    public class RearrangeAlternatingHighLowTest
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

            sut.RearrangeAlternatingHighLow();
            StringAssert.AreEqualIgnoringCase("0 2 1 4 3 6 5 8 7 10 9 12 11", sut.Print(sut.head));
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);

            sut.RearrangeAlternatingHighLow();
            StringAssert.AreEqualIgnoringCase("0 1", sut.Print(sut.head));
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);

            sut.RearrangeAlternatingHighLow();
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

            sut.RearrangeAlternatingHighLow();
            StringAssert.AreEqualIgnoringCase("9 10 7 8 5 6 3 4 1 2 0", sut.Print(sut.head));
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
