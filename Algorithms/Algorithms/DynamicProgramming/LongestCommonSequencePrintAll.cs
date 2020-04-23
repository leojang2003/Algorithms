using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSequencePrintAll
    {
        public string Print(string a, string b)
        {
            var lookup = Lookup(a, b);
            var currentX = a.Length;
            var currentY = a.Length;
            var lcs = "";

            while (currentX > 0 && currentY > 0)
            {
                var count = lookup[currentX, currentY];
                if (a.Skip(currentX - 1).Take(1).ToString() == b.Skip(currentY - 1).Take(1).ToString())
                {
                    lcs = a.Skip(currentX - 1).Take(1).ToString() + lcs;
                    currentX--;
                    currentY--;
                }
                else
                {
                    if (currentX - 1 > 0 && currentY - 1 > 0)
                    {
                        var top = lookup[currentX, currentY - 1];
                        var left = lookup[currentX - 1, currentY];

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
                    if (a.Take(i + 1).ToString() != b.Take(j + 1).ToString())
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
