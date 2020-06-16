using Algorithms.DynamicProgramming;
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
            int[] input = new int[] { 3, 1, 1, 2, 2, 1 };
            //int[] input = new int[] { 2,2,6,8,4,8,20,4,24,16,22,1,3,7,3,19,13,17,37 };
            var sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }

            if (sum % 2 != 0)
                Console.WriteLine("Can't divide");
            else
                sum = sum / 2;

            var group1 = new List<int>();
            var group2 = new List<int>();

            PartitionSum.Find(input, group1, group2, sum, sum, 0);

            var result = PartitionSum.SubsetSum(input, 6, 5);



            //var x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var lcs = new LongestIncreasingSubsequence();
            //lcs.LIS(x, x.Length);

            //var x = new int[6, 8];
            //x[0, 0] = 5;
            //var sut = new LargestSquareSubmatrix1();
            //var lookup = sut.Lookup(x);

            /*nt[,] test = new int*/

            //int[,] a = new int[5, 5];

            //a[0, 0] = 4;
            //a[0, 1] = 7;
            //a[0, 2] = 8;
            //a[0, 3] = 6;
            //a[0, 4] = 4;

            //a[1, 0] = 6;
            //a[1, 1] = 7;
            //a[1, 2] = 3;
            //a[1, 3] = 9;
            //a[1, 4] = 2;

            //a[2, 0] = 3;
            //a[2, 1] = 8;
            //a[2, 2] = 1;
            //a[2, 3] = 2;
            //a[2, 4] = 4;

            //a[3, 0] = 7;
            //a[3, 1] = 1;
            //a[3, 2] = 7;
            //a[3, 3] = 3;
            //a[3, 4] = 7;

            //a[4, 1] = 2;
            //a[4, 1] = 9;
            //a[4, 2] = 8;
            //a[4, 3] = 9;
            //a[4, 4] = 3;

            //var sut = new MinimumCost();
            //var lookup = sut.Lookup(a);

            //var sut2 = new _01Knapsack();
            //int[] A = new int[6] { 20, 5, 10, 40, 15, 25 };
            //int[] W = new int[6] { 1, 2, 3, 8, 7, 4 };
            //int threshold = 12;
            //var max = sut2.Maximum(A, W, 0, threshold);
            //Assert.AreEqual(60, max);

            Console.ReadKey();            
        }

        public static void RearrangeInSpecificMannerInLinearTime()
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
            list.Insert(11);
            list.Insert(12);

            var result = list.RearrangeInSpecificMannerInLinearTime();
            list.Print(result);
            Console.WriteLine();
        }

        public static void DeleteEveryNNodesAfterSkippingMNodes(int m, int n)
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
            list.Insert(11);
            list.Insert(12);
            list.Print(list.head);
            Console.WriteLine($"skip {m} nodes, Delete {n} nodes ");
            list.DeleteEveryNNodesAfterSkippingMNodes(m,n);
            list.Print(list.head);
            Console.WriteLine();
        }

        public static void MergeTwoSortedLinkedListsFromEnd()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(5);
            list.Insert(7);
            list.Insert(9);
            list.Insert(11);
            list.Insert(13);

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);
            list2.Insert(8);
            list2.Insert(10);
            list2.Insert(12);
            list2.Insert(14);

            var result = list.MergeTwoSortedLinkedListsFromEnd(list2.head);
                        
            list.Print(result);
            Console.WriteLine();
        }

        public static void MergeAlternateNodes()
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Insert(0);
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            

            SingleLinkedList list2 = new SingleLinkedList();
            list2.Insert(7);
            list2.Insert(8);
            list2.Insert(9);
            list2.Insert(10);
            list2.Insert(11);
            list2.Insert(12);
            list2.Insert(13);

            var result = list.MergeAlternateNodes(list2.head);

            list.Print(list.head);
            Console.WriteLine();
            list.Print(result);
            Console.WriteLine();
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
