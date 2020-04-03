using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class MergeSortCormen
    {

        /// <summary>
        /// Implementation from "Introduction to Algorithms"
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
        public static void Merge(double[] array, int p, int q, int r)
        {
            var n1 = q - p + 1; // new left array length
            var n2 = r - q;     // new right array length

            double[] L = new double[n1 + 1];  // new left array, last element is sentinel
            double[] R = new double[n2 + 1];  // new right array, last element is sentinel

            for (int m = 0; m < n1; m++)
                L[m] = array[p + m]; // assign value to left array
            for (int n = 0; n < n2; n++)
                R[n] = array[q + n + 1]; // assign value to right array

            L[n1] = Double.PositiveInfinity; // Looks like not use
            R[n2] = Double.PositiveInfinity; // Looks like not use

            var i = 0;
            var j = 0;

            for(int k = p; k <= r; k++) // This 
            {
                if (L[i] <= R[j])
                    array[k] = L[i++]; // Degug fround error k++ -> k
                else
                    array[k] = R[j++]; // Degug fround error k++ -> k
            }
        }

        public static void Sort(double[] array, int p, int r)
        {
            if(p < r)
            {
                var q = (p + r) / 2;

                Sort(array, p, q);
                Sort(array, q + 1, r);  // Degug fround error
                Merge(array, p, q, r);
            }
        }
    }
}
