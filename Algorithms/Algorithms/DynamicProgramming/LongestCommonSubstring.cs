using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSubstring
    {
        int max = 0;

        List<Loc> list = new List<Loc>();

        public List<string> Find(string a, string b)
        {
            var lookup = Lookup(a, b);
            var lcss = new List<string>();

            foreach (var loc in list)
            {
                var x = loc.x;
                var y = loc.y;
                var lcs = "";

                var length = lookup[loc.x, loc.y];

                for (int i = length; i > 0; i--)
                {
                    lcs = a.Substring(x - 1, 1) + lcs;
                    x--;
                    y--;
                }

                lcss.Add(lcs);
            }
            return lcss;
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
                        if (lookup[i, j] == max)
                        {
                            /* debug found error : key duplicate
                            list.Add(i, j); 
                            */
                            list.Add(new Loc() { x = i, y = j });
                        }
                        else if (lookup[i, j] > max)
                        {
                            list.Clear();
                            list.Add(new Loc() { x = i, y = j });
                            max = lookup[i, j];
                        }
                    }
                }
            }
            return lookup;
        }
    }
    internal class Loc
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
