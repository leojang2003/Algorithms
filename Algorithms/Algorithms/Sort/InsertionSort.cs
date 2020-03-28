using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class InsertionSort
    {
        public static void Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                while (i > 0 && input[i] < input[i - 1])
                {
                    var temp = input[i];
                    input[i] = input[i - 1];
                    input[i - 1] = temp;
                    i--;
                }
            }
            Printer.Print(input);
        }
    }
}
