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
            //RemoveDuplicateFromSorted();
            //SplitLinkedList();
            //MoveHeadToAnotherList();
            MoveEvenNodeToEndReverseOrder();
            Console.ReadKey();            
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
