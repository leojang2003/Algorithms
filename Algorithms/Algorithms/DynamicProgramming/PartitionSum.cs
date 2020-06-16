using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class PartitionSum
    {        
        // 3, 1, 1, 2, 2, 1
        public static void Find(int[] A, List<int> set1, List<int> set2, int sum1, int sum2, int index)
        {
            if (index == A.Length)
                return;

            var target = A[index];
            
            // First Half
            if(sum1 - A[index] == 0)
            {
                set1.Add(index);

                Console.Write($"Set1 ");

                foreach (var data in set1)                
                    Console.Write($"{A[data]}({data}) ");
                Console.WriteLine($"");                

                set1.RemoveAt(set1.Count - 1);

            }
            else if (sum1 - A[index] > 0)
            {
                set1.Add(index);
                Find(A, set1, set2, sum1 - A[index], sum2, ++index);
                set1.RemoveAt(set1.Count - 1);                
            }

            if (index == A.Length)
                return;

            // Second Half
            if (sum2 - A[index] == 0)
            {
                set2.Add(index);

                Console.Write($"Set2 ");

                foreach (var data in set2)
                    Console.Write($"{A[data]}({data}) ");
                Console.WriteLine($"");

                set2.RemoveAt(set2.Count - 1);
            }
            else if (sum2 - A[index] >= 0)
            {
                set2.Add(index);
                Find(A, set1, set2, sum1, sum2 - A[index], ++index);
                set2.RemoveAt(set2.Count - 1);                
            }                   
        }        

        public static bool SubsetSum(int[] A, int n, int sum)
        {
            // T[i,j] stores true if subset with sum j can be attained with
            // using items up to first i items
            bool[,] T = new bool[n + 1,sum + 1];

            // if sum is zero
            for (int i = 0; i <= n; i++)
                T[i, 0] = true;

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= sum; j++)
                {
                    if (A[i - 1] > j)
                        T[i, j] = T[i - 1, j];
                    else
                        T[i, j] = T[i - 1, j] || T[i - 1, j - A[i - 1]];
                }
            }

            return T[n, sum];
        }
    }
}
