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
            Console.ReadKey();
        }
    }
}
