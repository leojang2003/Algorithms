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
    public class IsPalindromTest
    {
        [Test]
        public void Test1()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(0);

            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test2()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);

            var result = sut.IsPalindrome();
            Assert.IsFalse(result);
        }

        [Test]
        public void Test3()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);

            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test4()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(3);
            sut.Insert(2);
            sut.Insert(1);
            sut.Insert(0);

            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test5()
        {
            var sut = new SingleLinkedList();

            sut.Insert(0);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(0);

            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test6()
        {
            var sut = new SingleLinkedList();

            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);
            sut.Insert(1);

            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }

        [Test]
        public void Test7()
        {
            var sut = new SingleLinkedList();

            sut.Insert(1);
            sut.Insert(2);
            sut.Insert(3);
            sut.Insert(4);
            sut.Insert(3);
            sut.Insert(2);
            sut.Insert(1);
            
            var result = sut.IsPalindrome();
            Assert.IsTrue(result);
        }
    }
}
