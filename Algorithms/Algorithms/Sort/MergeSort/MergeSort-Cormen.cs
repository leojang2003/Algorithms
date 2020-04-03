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
        public void Merge(int[] array, int p, int q, int r)
        {
            var n1 = p - q + 1; // 
            var n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int m = 0; m < n1; m++)
                L[m] = array[p + m];
            for (int n = 0; n < n2; n++)
                R[n] = array[q + n + 1];

            var i = 0;
            var j = 0;

            for(int k = p; k < r; k++)
            {
                if (L[i] <= R[j])
                    array[k++] = L[i++];
                else
                    array[k++] = R[j++];
            }

        }
    }
}
