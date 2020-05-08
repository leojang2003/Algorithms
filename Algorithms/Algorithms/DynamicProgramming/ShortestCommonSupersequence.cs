using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class ShortestCommonSupersequence
    {
        // {C}B
        // {C}A

        // {GA}B
        // {BC}A

        // {GA}B
        // {BC}A

        // {D}B
        // {Q}A

        // ABCBDAB
        // BDCABA
        // SCS are ABCBDCABA, ABDCABDAB and ABDCBDABA
        public int Length(string a, string b, int m, int n)
        {
            if (m == 0 && n != 0) return n;
            if (m != 0 && n == 0) return m;
            if (m == 0 && n == 0) return 0;

            if (a.Substring(m - 1, 1) == b.Substring(n - 1, 1))
            {
                return Length(a, b, m - 1, n - 1) + 1;
            }
            else
            {
                return Math.Max(Length(a, b, m - 1, n), Length(a, b, m, n - 1)) + 1;
            }
        }
    }
}