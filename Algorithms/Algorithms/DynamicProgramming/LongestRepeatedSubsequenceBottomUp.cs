using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestRepeatedSubsequenceBottomUp
    {
        public List<string> LRS(string a, string b, int[,] lookup, int m, int n)
        {
            if (m > 0 && n > 0)
            {
                var x1 = a.Substring(m - 1, 1);
                var y1 = b.Substring(n - 1, 1);

                if (x1 == y1 && m != n)
                {
                    var list = new List<string>();
                    var previous = LRS(a, b, lookup, m - 1, n - 1);
                    if (previous.Count > 0)
                    {
                        foreach (var x in previous)
                        {
                            list.Add(x + a.Substring(m - 1, 1));
                        }
                    }
                    else
                        list.Add(a.Substring(m - 1, 1));

                    return list;
                }
                else
                {
                    var top = lookup[m, n - 1];
                    var left = lookup[m - 1, n];

                    if (top == left)
                    {
                        var list = new List<string>();
                        list.AddRange(LRS(a, b, lookup, m, n - 1));
                        list.AddRange(LRS(a, b, lookup, m - 1, n));
                        return list;
                    }
                    else if (top > left)
                        return LRS(a, b, lookup, m, n - 1);
                    else
                        return LRS(a, b, lookup, m - 1, n);
                }
            }
            return new List<string>();

        }

        public int[,] Lookup(string a)
        {
            // default value of multidimensional array is 0
            var lookup = new int[a.Length + 1, a.Length + 1];

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= a.Length; j++)
                {
                    if (a.Substring(i - 1, 1) == a.Substring(j - 1, 1) && i != j)
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lookup[i, j] = Math.Max(lookup[i, j - 1], lookup[i - 1, j]);
                        
                    }
                }
            }

            return lookup;
        }
    }
}
