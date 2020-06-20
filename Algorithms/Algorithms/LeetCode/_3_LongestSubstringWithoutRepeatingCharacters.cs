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
            HashSet<string> set = new HashSet<string>();

            var len = new int[s.Length];
            int max = 1;

            for (int i = 0; i < s.Length; i++)
            {
                len[i] = 1;
                set.Add($"{s.ElementAt(i)}|{i}");
            }

            for (int i = 1; i < s.Length; i++)
            {
                // loop start index
                var temp = i - 1;
                var common = false;
                var count = 0;
                Console.WriteLine(i);
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
		
		// over LeetCode time limit
        // abcabcbb -> abc
        // bbbbb -> b
        // pwwkew -> wke
        public int Find2(string s)
        {
            // boundary condition
            if (s == "") return 0;

            Dictionary<char, int> set = new Dictionary<char, int>();

            var len = new int[s.Length];
            int max = 1;
            len[0] = 1;
            
            // add to key
            set.Add(s.ElementAt(0), 0);

            for (int i = 1; i < s.Length; i++)
            {
                var lastDupeIndex = -1;

                if (set.ContainsKey(s.ElementAt(i)))
                {
                    // get last index when the char appears
                    set.TryGetValue(s.ElementAt(i), out lastDupeIndex);
                    set[s.ElementAt(i)] = i;
                }
                else
                {
                    set.Add(s.ElementAt(i), i);
                }
                   
                // Get the starting index for the longest no repeat substring ending at index i - 1                
                var pre_start_index = (i - 1) - len[i - 1] + 1;

                // If the char last appears before the starting index for the longest no repeat substring ending at index i - 1
                // then simply add 1 to the len
                // if not calculate the new len                
                if (lastDupeIndex < pre_start_index)
                    len[i] = len[i - 1] + 1;
                else
                {
                    var new_length = (i - 1) - lastDupeIndex + 1;
                    len[i] = new_length;
                }

                if (len[i] > max)
                    max = len[i];
            }

            return max;
        }
    }
}
