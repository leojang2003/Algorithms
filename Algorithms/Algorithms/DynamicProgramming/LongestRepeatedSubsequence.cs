using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestRepeatedSubsequence
    {
        public List<string> PrintAll(string x, int m, int n, Dictionary<string, List<string>> lookup, HashSet<string> lrs)
        {
            if (m == 0 || n == 0)
            {
                return new List<string>();
            }

            string key = $"{m}|{n}"; // brilliant solution on web

            if (!lookup.ContainsKey(key)) // should lookup in outer scope
            {
                if (x.Substring(m - 1, 1) == x.Substring(n - 1, 1) && m != n)
                {
                    var previous = PrintAll(x, m - 1, n - 1, lookup, lrs);
                    var result = new List<string>();
                    if (previous.Count == 0)
                    {
                        result.Add(x.Substring(m - 1, 1));
                        lookup.Add(key, result);
                        return result;
                    }
                    else
                    {
                        foreach (var tmp in previous)
                        {
                            result.Add(tmp + x.Substring(m - 1, 1));
                        }
                        lookup.Add(key, result);
                        return result;
                    }
                }
                else
                {
                    var a = PrintAll(x, m - 1, n, lookup, lrs);
                    var b = PrintAll(x, m, n - 1, lookup, lrs);

                    if (a.Count == 0 && b.Count > 0)
                        return b;
                    else if (a.Count > 0 && b.Count == 0)
                        return a;
                    else if (a.Count > 0 && b.Count > 0)
                    {
                        if (a.First().Length > b.First().Length)
                            return a;
                        else if (a.First().Length < b.First().Length)
                            return b;
                        else
                        {
                            var list = new List<string>();
                            list.AddRange(a);
                            list.AddRange(b);
                            return list.Distinct().ToList(); 
                        }
                    }
                    else
                        return new List<string>();
                }
            }
            else
            {
                var value = new List<string>();
                lookup.TryGetValue(key, out value);
                return value;
            }            
        }

        // This problem is just the modification of Longest Common Subsequence problem. 
        // The idea is to find the LCS(str, str) where str is the input string with the restriction that when both the characters are same, they shouldn’t be on the same index in the two strings.
        public int Length(string x, int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            if (x.Substring(m - 1, 1) == x.Substring(n - 1, 1) && m != n)
            {
                return Length(x, m - 1, n - 1) + 1;
            }
            return Math.Max(Length(x, m - 1, n), Length(x, m, n - 1));
        }

        // Remove duplicate calculation by using memory
        public int LengthNoDupeCalc(string x, int m, int n, Dictionary<string, int> lookup)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            string key = $"{m}|{n}"; // brilliant solution on web

            if (!lookup.ContainsKey(key)) // should lookup in outer scope
            {
                if (x.Substring(m - 1, 1) == x.Substring(n - 1, 1) && m != n)
                {
                    return Length(x, m - 1, n - 1) + 1;
                }
                return Math.Max(Length(x, m - 1, n), Length(x, m, n - 1));
            }

            var value = -1;
            lookup.TryGetValue(key, out value);
            return value;

        }

    }
}
