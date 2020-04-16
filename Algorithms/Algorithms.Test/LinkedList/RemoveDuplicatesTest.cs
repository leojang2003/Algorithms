using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class RemoveDuplicatesTest
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            sut.Insert(5);
            sut.Insert(3);
            sut.Insert(4);
            sut.Insert(2);
            sut.Insert(5);
            sut.Insert(4);
            sut.Insert(1);
            sut.Insert(3);

            sut.RemoveDuplicates();
            StringAssert.AreEqualIgnoringCase("5 3 4 2 1", sut.Print(sut.head));
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(5);
            sut.Insert(5);
            sut.Insert(5);
            sut.Insert(5);

            sut.RemoveDuplicates();
            StringAssert.AreEqualIgnoringCase("5", sut.Print(sut.head));
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(5);

            sut.RemoveDuplicates();
            StringAssert.AreEqualIgnoringCase("5", sut.Print(sut.head));
        }

        [Test]
        public void Test4()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(2);
            sut.Insert(2);
            sut.Insert(2);

            sut.RemoveDuplicates();
            StringAssert.AreEqualIgnoringCase("0 1 2", sut.Print(sut.head));
        }

        [Test]
        public void Test5()
        {
            var sut = new SingleLinkedList();

            sut.Insert(2);
            sut.Insert(7);
            sut.Insert(2);
            sut.Insert(7);
            sut.Insert(1);
            sut.Insert(4);
            sut.Insert(1);
            sut.Insert(4);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(12);
            sut.Insert(13);
            
            sut.RemoveDuplicates();
            StringAssert.AreEqualIgnoringCase("2 7 1 4 0 12 13", sut.Print(sut.head));
        }
    }
}
