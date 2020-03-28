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
            int[] source = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //SelectionSort.Sort2(source);
            InsertionSort.Sort(source);
            //Console.ReadKey();

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

            //list.Print(list.head);


            var head2 = list.Split();

            list.Print(list.head);
            Console.WriteLine();
            list.Print(head2);
            Console.Read();
        }
    }
}
