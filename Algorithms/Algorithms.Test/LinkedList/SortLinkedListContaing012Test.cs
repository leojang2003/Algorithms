using Algorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LinkedList
{
    public class SortLinkedListContaing012Test
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(1);

            sut.SortLinkedListContaing012();
            StringAssert.AreEqualIgnoringCase("0 0 1 1 1 2 2", sut.Print(sut.head));
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);

            sut.SortLinkedListContaing012();
            StringAssert.AreEqualIgnoringCase("0 0 0 0", sut.Print(sut.head));
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);

            sut.SortLinkedListContaing012();
            StringAssert.AreEqualIgnoringCase("0", sut.Print(sut.head));
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

            sut.SortLinkedListContaing012();
            StringAssert.AreEqualIgnoringCase("0 0 0 0 1 1 1 1 2 2 2 2", sut.Print(sut.head));
        }

        [Test]
        public void Test5()
        {
            var sut = new SingleLinkedList();

            sut.Insert(2);
            sut.Insert(2);
            sut.Insert(2);
            sut.Insert(2);            
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);
            sut.Insert(0);


            sut.SortLinkedListContaing012();
            StringAssert.AreEqualIgnoringCase("0 0 0 0 1 1 1 1 2 2 2 2", sut.Print(sut.head));
        }
    }
}
