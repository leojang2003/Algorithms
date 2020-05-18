using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        int[] p; 

        public int Length(int[] A)
        {
            var lookup = Lookup(A);
            var max = -1;
            for(int i = 0; i < lookup.Length; i++)
            {
                if (lookup[i] > max)
                    max = lookup[i];
            }

            return max;
        }

        public List<int> PrintAny(int[] A)
        {
            var lookup = Lookup(A);
            var list = new List<int>();
            var max_index = -1;
            var max_value = -1; // debug found error, need to track both index and value

            for (int i = 0; i < lookup.Length; i++)
            {
                if (lookup[i] > max_value)
                {
                    max_index = i;
                    max_value = lookup[i];
                }
                    
            }
            
            while(lookup[max_index] >= 1)
            {
                list.Insert(0, A[max_index]);

                if (lookup[max_index] == 1)
                    break;

                max_index = p[max_index];                
            }

            return list;
        }

        public int[] Lookup(int[] A)
        {
            var lookup = new int[A.Length];
            p = new int[A.Length];

            for (int j = 0; j < A.Length; j++)
            {
                lookup[j] = 1;
                p[j] = j;
            }                

            for(int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (A[i] > A[j])
                    {
                        // debug found error, should put this line before Math.Max
                        if (lookup[j] + 1 > lookup[i])
                            p[i] = j;

                        lookup[i] = Math.Max(lookup[i], lookup[j] + 1);

                        
                    }                        
                }
            }

            return lookup;
        }
    }
}
