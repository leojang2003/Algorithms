using Algorithms.LinkedList;
using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortingTest.Test();

            //RemoveDuplicateFromSorted();
            //SplitLinkedList();
            //MoveHeadToAnotherList();
            //MoveEvenNodeToEndReverseOrder();
            //MergeAlternatingNodes();
            //MergeTwoSortedList();
            //IntersectionOfTwoGivenSortedLinkedLists();
            //ReverseLinkedList();
            //ReverseEveryGroupOfKNodes();
            FindKthNodeFromTheEnd();
            Console.ReadKey();            
        }

        public static void FindKthNodeFromTheEnd()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(0);
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);
            list.Insert(10);

            list.Print(list.head);
            Console.WriteLine();
            Console.WriteLine(list.FindKthNodeFromTheEnd(6));            
            Console.WriteLine();
        }

        public static void ReverseEveryGroupOfKNodes()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);
            list.Insert(10);

            var result = list.ReverseEveryGroupOfKNodes(6);

            list.Print(result);
            Console.WriteLine();
        }

        public static void ReverseLinkedList()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(10); 

            var result = list.ReverseLinkedList();

            list.Print(result);
            Console.WriteLine();
        }

        public static void IntersectionOfTwoGivenSortedLinkedLists()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(10);

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(3);
            list2.Insert(4);
            list2.Insert(6);
            list2.Insert(8);
            list2.Insert(10);
            list2.Insert(12);
            list2.Insert(14);

            var result = list.IntersectionOfTwoGivenSortedLinkedLists(list2.head);

            list.Print(result);
            Console.WriteLine();
        }

        public static void MergeTwoSortedList()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(4);
            list.Insert(6);

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(2);
            list2.Insert(5);
            list2.Insert(10);

            list.MergeTwoSortedList(list2.head);

            list.Print(list.head);
            Console.WriteLine();
        }

        public static void MergeAlternatingNodes()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(5);
            list.Insert(7);

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);

            list.MergeAlternatingNodes(list2.head);

            list.Print(list.head);
            Console.WriteLine();            
        }

        public static void MoveEvenNodeToEndReverseOrder()
        {
            SingleLinkedList list = new SingleLinkedList();
            //list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.MoveEvenNodeToEndReverseOrder();
            list.Print(list.head);
        }

        public static void MoveHeadToAnotherList()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(6);
            list2.Insert(4);
            list2.Insert(2);

            var head2 = list.MoveFrontToAnotherList(list2.head);

            list.Print(list.head);
            Console.WriteLine();
            list2.Print(head2);
        }

        public static void RemoveDuplicateFromSorted()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(2);
            list.Insert(2);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(7);
            list.Insert(7);
            list.Insert(10);

            list.RemoveDuplicateFromSorted();
            list.Print(list.head);
        }

        public static void SplitLinkedList()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);            
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);

            list.Print(list.head);
            var head2 = list.Split();

            list.Print(list.head);
            Console.WriteLine();
            list.Print(head2);            
        }
    }
}
