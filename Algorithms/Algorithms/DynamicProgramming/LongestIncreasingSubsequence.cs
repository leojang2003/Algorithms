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

        public int Sum(int[] A)
        {
            // sum[i] stores the maximum sum of the increasing subsequence that ends with A[i]
            var sum = new int[A.Length];

            sum[0] = A[0];

            for(int i = 1; i < A.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (sum[i] < sum[j] && A[i] > A[j])
                        sum[i] = sum[j];
                }

                sum[i] += A[i];
            }

            var max = Int32.MinValue;

            for(int i = sum.Length - 1; i > 0; i--)
            {
                if (sum[i] > max)
                    max = sum[i];
            }

            for (int i = sum.Length - 1; i > 0; i--)
            {
               if(sum[i] == max)
                {
                    Console.WriteLine(A[i]); // Print longest increasing maximum sum 
                    max -= A[i];
                }
            }

            return max; // return maximum sum
        }

        public int Length(int[] A)
        {
            var lookup = Lookup(A);
            var max = -1;
            for (int i = 0; i < lookup.Length; i++)
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

            while (lookup[max_index] >= 1)
            {
                list.Insert(0, A[max_index]);

                if (lookup[max_index] == 1)
                    break;

                max_index = p[max_index];
            }

            return list;
        }

        public Stack<int>[] PatienceSolitaire(int[] A)
        {
            var stack_array = new Stack<int>[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                Stack<int> stack = new Stack<int>();
                stack_array[i] = stack;
            }

            int start = 0;
            int end = A.Length;

            var top = new int[A.Length];
            var previous = new int[A.Length];


            for (int i = 0; i < A.Length; i++)
                top[i] = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                while (end > start)
                {
                    int mid = (start + end) / 2;
                    if (A[i] > top[mid])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                if (top[end] < A[i])
                {
                    top[end + 1] = A[i];
                    previous[end + 1] = top[end];
                    stack_array[end + 1].Push(A[i]);
                }
                else
                {
                    top[end] = A[i];
                    previous[end] = end >= 0 ? top[end] : Int32.MinValue;
                    stack_array[end].Push(A[i]);
                }
                
                end = A.Length;
            }

            for(int i = 0; i < top.Length; i++)
            {
                if (top[i] == Int32.MaxValue)
                    break;
                else
                {
                    Console.WriteLine(top[i]);
                }
            }

            return stack_array;
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

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < i; j++)
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

        public int Length2(int[] A)
        {
            var d = new int[A.Length + 1];
            d[0] = Int32.MinValue;

            for (int i = 1; i < d.Length; i++)
                d[i] = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 1; j <= A.Length; j++) // d array should start with length 1
                {
                    if (d[j - 1] < A[i] && A[i] < d[j])
                    {
                        d[j] = A[i];
                    }
                }
                Console.WriteLine("");
            }

            var max = 0;

            for (int i = A.Length; i >= 0; i--)
            {
                if (d[i] != Int32.MaxValue)
                {
                    max = d[i];
                    break;
                }
            }

            return max;
        }

        public int BinarySearch(int[] d, int start, int end, int key)
        {
            while (end - start > 1)
            {
                int mid = (start + end) / 2;
                if (d[mid] >= key)
                {
                    end = mid;
                }
                else
                    start = mid;
            }
            return end;
        }

        public int Length3(int[] A)
        {
            var d = new int[A.Length + 1];
            d[0] = Int32.MinValue;

            for (int i = 1; i < d.Length; i++)
                d[i] = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                var j = BinarySearch(d, 0, i + 1, A[i]);
                if (d[j - 1] < A[i] && A[i] < d[j])
                {
                    d[j] = A[i];
                }

                Console.WriteLine("");
            }

            var max = 0;

            for (int i = A.Length; i >= 0; i--)
            {
                if (d[i] != Int32.MaxValue)
                {
                    max = d[i];
                    break;
                }
            }

            return max;
        }
    }
}
