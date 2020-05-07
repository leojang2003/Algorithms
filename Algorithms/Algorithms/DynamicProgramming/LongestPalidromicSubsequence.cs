using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestPalidromicSequence
    {
        // 0,4
        // 1 3
        // 2 2
        // 

        public List<string> Find(string input, int start, int end)
        {
            if (start <= end)
            {
                var x = input.Substring(start, 1);
                var y = input.Substring(end, 1);

                if (x == y)
                {
                    var result = new List<string>();
                    var tmp = Find(input, start + 1, end - 1);
                    // debug found error start 
                    if (tmp.Count == 0)
                    {
                        if (start == end)
                            result.Add(x);
                        else
                            result.Add(x + x);
                    }
                    // debug found error end                        
                    else
                    {
                        foreach (var lcs in tmp)
                        {
                            result.Add(x + lcs + x);
                        }
                    }
                    return result;
                }
                else
                {
                    var sub1 = Find(input, start + 1, end);
                    var sub2 = Find(input, start, end - 1);
                    if (sub1.Count() == 0 && sub2.Count > 0)
                        return sub2;
                    else if (sub2.Count() == 0 && sub1.Count > 0)
                        return sub1;
                    else if (sub1.Count() == 0 && sub2.Count == 0)
                        return new List<string>();
                    else
                    {
                        if (sub1.First().Length > sub2.First().Length)
                            return sub1;
                        else if (sub1.First().Length < sub2.First().Length)
                            return sub2;
                        else
                            return sub1.Concat(sub2).ToList();
                    }
                }
            }
            return new List<string>();
        }
    }
}
