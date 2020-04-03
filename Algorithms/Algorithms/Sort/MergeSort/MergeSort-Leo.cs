using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        public static int[] Sort(int[] input)
        {
            // Debug found error empty string return
            if (input.Length == 0)
                return input;

            var p = 0;
            var q = input.Count() - 1;
            var r = (p + q) / 2;

            // Debug found error
            if (input.Length == 1)
                return input;

            var firstHalf = input.Take(r + 1).ToArray();
            var secondHalf = input.Skip(r + 1).Take(q - r + 1).ToArray();

            firstHalf = Sort(firstHalf);
            secondHalf = Sort(secondHalf);
            return Merge(firstHalf, secondHalf);
        }

        public static int[] Merge(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Count() + array2.Count()];

            var i = 0;
            var j = 0;
            var current = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if(array1[i] <= array2[j])
                {
                    result[current] = array1[i];                  
                    ++i;
                }
                else
                {
                    result[current] = array2[j];
                    ++j;
                }
                ++current;
            }

            if(i==array1.Length)
            {
                for(int k = j; k < array2.Length; k++)
                {
                    result[current] = array2[k];
                    ++current;
                }
            }
            else
            {
                for (int k = i; k < array1.Length; k++)
                {
                    result[current] = array1[k];
                    ++current;
                }
            }

            return result;
        }
    }
}
