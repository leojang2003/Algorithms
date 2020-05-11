using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class ShortestCommonSupersequence
    {
        public List<string> SCS(string a, string b, int[,] lookup, int m, int n)
        {
            if (m >= 0 && n >= 0)
            {
                // ******** Debug found error, need to consider boundary                
                var bound = new List<string>();
                if (m == 0 && n != 0)
                {
                    bound.Add(b.Substring(n - 1, 1));
                    return bound;
                }
                if (m != 0 && n == 0)
                {
                    bound.Add(a.Substring(m - 1, 1));
                    return bound;
                }
                if (m == 0 && n == 0)
                {                   
                    return bound;
                }
                // ********

                var x1 = a.Substring(m - 1, 1);
                var y1 = b.Substring(n - 1, 1);

                if (x1 == y1)
                {
                    var list = new List<string>();
                    var previous = SCS(a, b, lookup, m - 1, n - 1);
                    if (previous.Count > 0)
                    {
                        foreach (var x in previous)
                        {
                            list.Add(x + x1);
                        }
                    }
                    else
                        list.Add(x1);

                    return list;
                }
                else
                {
                    var top = lookup[m, n - 1];
                    var left = lookup[m - 1, n];

                    if (top == left)
                    {
                        var list = new List<string>();
                        
                        var toplist = new List<string>();

                        // ******** Debug found error, need to consider when count = 0
                        if (SCS(a, b, lookup, m, n - 1).Count == 0) 
                            toplist.Add(y1);
                        else
                            toplist = SCS(a, b, lookup, m, n - 1).Select(x => x + y1).ToList();

                        var leftlist = new List<string>();
                        if (SCS(a, b, lookup, m - 1, n).Count == 0)
                            leftlist.Add(x1);
                        else
                            leftlist = SCS(a, b, lookup, m - 1, n).Select(x => x + x1).ToList();
                        // ********

                        list.AddRange(toplist);
                        list.AddRange(leftlist);

                        return list;
                    }
                    else if (top > left)
                        return SCS(a, b, lookup, m - 1, n).Select(x => x + x1).ToList();
                    else
                        return SCS(a, b, lookup, m, n - 1).Select(x => x + y1).ToList();
                }
            }
            return new List<string>();
        }

        public int[,] Lookup(string a, string b)
        {
            // default value of multidimensional array is 0
            var lookup = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i <= a.Length; i++)
                lookup[0, i] = i;

            for (int j = 0; j <= b.Length; j++)
                lookup[j, 0] = j;

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    if (a.Substring(i - 1, 1) != b.Substring(j - 1, 1))
                    {
                        lookup[i, j] = Math.Min(lookup[i, j - 1], lookup[i - 1, j]) + 1;
                    }
                    else
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + 1;
                    }
                }
            }

            return lookup;
        }

        public int Length(string a, string b, int m, int n)
        {
            return m + n - GetLCSLength(a, b, m, n);
        }

        public int GetLCSLength(string a, string b, int m, int n)
        {
            if (m == 0 || n == 0) return 0;

            if (a.Substring(m - 1, 1) == b.Substring(n - 1, 1))
            {
                return GetLCSLength(a, b, m - 1, n - 1) + 1;
            }
            else
            {
                return Math.Max(GetLCSLength(a, b, m - 1, n), GetLCSLength(a, b, m, n - 1));
            }
        }
    }
}
