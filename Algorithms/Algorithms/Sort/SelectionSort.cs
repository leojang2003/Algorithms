using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class SelectionSort
    {
        public static void Sort(int[] input)
        {
            // Initial version 01/25
            for (int i = 1; i < input.Length; i++)
            {
                int min = i - 1;

                for (int j = i; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }

                if (min != i - 1)
                {
                    var temp = input[i - 1];
                    input[i - 1] = input[min];
                    input[min] = temp;
                }
            }
            Printer.Print(input);
        }

        public static void Sort2(int[] input)
        {
            // Version 01/27
            for (int i = 1; i < input.Length; i++)
            {
                // assumed minimum index, starting from 0,... 
                int min = i - 1;
                
                // assumed minimum value
                int minValue = input[min];

                int? temp = null;
                
                for (int j = i; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        // update assumed minumum value
                        input[min] = input[j];
                        temp = j;
                    }
                }
                // assign minValue to last index j, that satisfied the if condition
                // but we don't record the index j, so we create index temp to record it
                if(temp!=null)
                    input[(int)temp] = minValue;
            }
            Printer.Print(input);
        }
    }
}
