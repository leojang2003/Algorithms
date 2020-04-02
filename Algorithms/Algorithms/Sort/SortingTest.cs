using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class SortingTest
    {
        public static void Test()
        {
            MergeSortTest();
        }

        private static void MergeSortTest()
        {
            int[] array = { 3, 1, 6, 5, 2, 9, 4, 7, 20 };
            Printer.Print(array);
            var sorted = MergeSort.Sort(array);
            Printer.Print(sorted);

            int[] array4 = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            Printer.Print(array4);
            var sorted4 = MergeSort.Sort(array4);
            Printer.Print(sorted4);

            int[] array2 = { 9 };
            Printer.Print(array2);
            var sorted2 = MergeSort.Sort(array2);
            Printer.Print(sorted2);

            int[] array3 = new int[0];
            Printer.Print(array3);
            var sorted3 = MergeSort.Sort(array3);
            Printer.Print(sorted3);
        }
    }
}
