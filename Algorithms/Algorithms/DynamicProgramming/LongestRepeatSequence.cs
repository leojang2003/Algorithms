using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestRepeatSequence
    {
        public List<string> PrintAll(string input, int start, int end)
        {
            if (start == 0 || end == 0)
                return new List<string>();

            if (input.Substring(start, 1) == input.Substring(end, 1) && start != end)
            {
                var previous = PrintAll(input, start - 1, end - 1);
                var result = new List<string>();
                if (previous.Count == 0)
                {
                    result.Add(input.Substring(start, 1));
                    return result;
                }
                else
                {
                    foreach (var tmp in previous)
                    {
                        result.Add(tmp + input.Substring(start, 1));
                    }
                }
            }
            else
            {
                var m = PrintAll(input, start - 1, end);
                var n = PrintAll(input, start, end - 1);


            }

            return new List<string>();
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
