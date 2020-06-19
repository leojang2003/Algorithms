using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
        // abcabcbb -> abc
        // bbbbb -> b
        // pwwkew -> wke
        public int Find(string s)
        {
			      if(s=="") return 0;
			
            var len = new int[s.Length];
            int max = 1;

            for (int i = 0; i < s.Length; i++)
            {
                len[i] = 1;
            }

            for (int i = 1; i < s.Length; i++)
            {
                // loop start index
                var temp = i - 1;
                var common = false;
                var count = 0;

                // see if have same char, only search  len[i-1] times
                for (int j = len[i - 1]; j > 0; j--)
                {
                    if (s.ElementAt(temp) == s.ElementAt(i))
                    {
                        // check how many chars past
                        len[i] = count + 1;
                        common = true;
                        break;
                    }
                    count++;
                    temp--;
                }

                if (!common)
                    len[i] = len[i - 1] + 1;


                if (len[i] > max)
                {
                    max = len[i];
                }
            }

            return max;
        }
    }
}
