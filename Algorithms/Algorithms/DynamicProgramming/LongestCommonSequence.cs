using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSequence
    {
        public List<string> PrintAllLCS(string a, string b)
        {
            var lookup = Lookup(a, b);
            return LCS(a, b, lookup, a.Length, b.Length).Distinct().ToList();
        }

        public List<string> LCS(string a, string b, int[,] lookup, int m, int n)
        {
            if (m > 0 && n > 0)
            {
                var x1 = a.Substring(m - 1, 1);
                var y1 = b.Substring(n - 1, 1);

                if (x1 == y1)
                {
                    var list = new List<string>();
                    var previous = LCS(a, b, lookup, m - 1, n - 1);
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
                        list.AddRange(LCS(a, b, lookup, m, n - 1));
                        list.AddRange(LCS(a, b, lookup, m - 1, n));
                        return list;
                    }
                    else if (top > left)
                        return LCS(a, b, lookup, m, n - 1);
                    else
                        return LCS(a, b, lookup, m - 1, n);
                }
            }
            return new List<string>();

        }

        public string PrintAnyLCS(string a, string b)
        {
            var lookup = Lookup(a, b);
            var currentX = a.Length;
            var currentY = b.Length;
            var lcs = "";

            while (currentX > 0 && currentY > 0)
            {
                var count = lookup[currentX, currentY];
                if (a.Substring(currentX - 1, 1) == b.Substring(currentY - 1, 1))
                {
                    lcs = a.Substring(currentX - 1, 1) + lcs;
                    currentX--;
                    currentY--;
                }
                else
                {
                    /*
                    if (currentX - 1 > 0 && currentY - 1 > 0)
                    {
                        var top = lookup[currentX, currentY - 1];
                        var left = lookup[currentX - 1, currentY];

                        if (top > left)
                            currentY--;
                        else
                            currentX--;
                    }
                    else            // debug found error
                        return lcs; // debug found error 
                    */

                    var top = lookup[currentX, currentY - 1];
                    var left = lookup[currentX - 1, currentY];

                    // debug found error, need to consider margin
                    if (currentY - 1 == 0)
                        currentX--;
                    // debug found error --- need to consider margin
                    else if (currentX - 1 == 0)
                        currentY--;

                    else
                    {
                        if (top > left)
                            currentY--;
                        else
                            currentX--;
                    }

                }
            }
            return lcs;
        }

        // 假設兩個字串長度分別為 m 與 n
        // 技巧 : 建立一個長度為 m+1 X n+1 的二維陣列
        // 技巧 : 因為多維陣列的預設值為 0
        // 0 0 0 0 0 0 0  
        // 0 X X X X X X
        // 0 X X X X X X
        // 0 X X X X X X
        // 目標是產生上圖中的陣列Ｘ
        // 長度多1則不用處理第一行與第一列的特殊情況 
        public int[,] Lookup(string a, string b)
        {
            // default value of multidimensional array is 0
            var lookup = new int[a.Length + 1, b.Length + 1];

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    if (a.Substring(i - 1, 1) != b.Substring(j - 1, 1))
                    {
                        lookup[i, j] = Math.Max(lookup[i, j - 1], lookup[i - 1, j]);
                    }
                    else
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + 1;
                    }
                }
            }

            return lookup;
        }
    }
}
