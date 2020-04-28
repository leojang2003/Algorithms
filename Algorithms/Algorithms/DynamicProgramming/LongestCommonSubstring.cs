using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSubstring
    {
        int maxX = 0;
        int maxy = 0;
        int max = 0;
        Dictionary<int, int> list = new Dictionary<int, int>();

        public string Find(string a, string b)
        {
            var lookup = Lookup(a, b);
            foreach(var lcs in list)
            {
                var x = lcs.Key;
                var y = lcs.Value;

                while(int )
            }
            return "";
        }

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
                        lookup[i, j] = 0;
                    }
                    else
                    {
                        lookup[i, j] = lookup[i - 1, j - 1] + 1;
                        if(lookup[i,j] == max )
                        {
                            list.Add(i, j);                            
                        }
                        else if(lookup[i,j] > max)
                        {
                            list.Clear();
                            list.Add(i, j);
                            max = lookup[i, j];
                        }
                    }
                }
            }

            return lookup;
        }
    }
}
