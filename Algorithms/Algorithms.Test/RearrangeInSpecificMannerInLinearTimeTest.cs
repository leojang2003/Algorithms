using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    [TestFixture]
    public class RearrangeInSpecificMannerInLinearTimeTest
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

            var result = sut.RearrangeInSpecificMannerInLinearTime();
            StringAssert.AreEqualIgnoringCase("0 12 1 11 2 10 3 9 4 8 5 7 6", sut.Print(result));
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);            

            var result = sut.RearrangeInSpecificMannerInLinearTime();
            StringAssert.AreEqualIgnoringCase("0 1", sut.Print(result));
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);

            var result = sut.RearrangeInSpecificMannerInLinearTime();
            StringAssert.AreEqualIgnoringCase("0", sut.Print(result));
        }

        [Test]
        public void Test4()
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
            
            var result = sut.RearrangeInSpecificMannerInLinearTime();
            StringAssert.AreEqualIgnoringCase("0 7 1 6 2 5 3 4", sut.Print(result));
        }
    }
}
