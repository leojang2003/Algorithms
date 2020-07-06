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

        // abcabcbb -> abc
        // abcb 
        // abcba
        // abcbac
        // abcbabcx
        // abababx
        // abcbx
        // abcd efg d eqy
        // abcd efg d abc
        // abcd efg d qxc
        // abcd efg d q b
        // abcd efg d q g
        // max = 7, 
        // abc d efg d 123456789 b
        // abcd efg a hqk
        // bbbbb -> b
        // pwwkew -> wke
        // longest no repeat substring starts with index i
        public int Find3(string s)
        {
            HashSet<char> set = new HashSet<char>();
            HashSet<char> dupe_set = new HashSet<char>();
            int max = 0;
            int current = 0;
            bool dupe_start = false;
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Contains(s.ElementAt(i)))
                {
                    queue.Enqueue(s.ElementAt(i));
                    set.Add(s.ElementAt(i));
                    current++;
                    if (current > max)
                        max = current;
                }
                else
                {
                    if (!dupe_start) dupe_start = true;

                    //var tmp = queue.Dequeue();
                    //while(tmp != s.ElementAt(i))
                    //{
                    //    set.Remove(tmp);
                    //    tmp = queue.Dequeue();
                    //    current--;
                    //}

                    //queue.Enqueue(s.ElementAt(i));
                }
            }
            return max;
        }

        // Runtime: 1768 ms, faster than 5.06% of C# online submissions for Longest Substring Without Repeating Characters.
        // Memory Usage: 25.9 MB, less than 17.51% of C# online submissions for Longest Substring Without Repeating Characters.
        public int Find4(string s)
        {
            if (s == "") return 0;

            HashSet<string> set = new HashSet<string>();
            int max = 0;
            int current = 0;
            bool dupe_found = false;
            
            for (int i = 0; i < s.Length; i++)
            {
				// Substring() 方法比 ElementAt() 的速度快很多
                var target = s.Substring(i,1);

                if (!set.Contains(target))
                {
                    if (dupe_found)
                    {
                        set.Clear();
                        current = 0;
                        int j = i;
                        var target2 = s.Substring(j, 1);
                        while (!set.Contains(target2))
                        {
                            set.Add(target2);
                            j--;
                            current++;
                            target2 = s.Substring(j, 1);
                        }
                        dupe_found = false;
                        if (current > max)
                            max = current;
                    }
                    else
                    {
                        set.Add(target);
                        current++;
                        if (current > max)
                            max = current;
                    }
                }
                else
                {
                    if (!dupe_found) dupe_found = true;
                }
            }
            return max;
        }

        
    }
    
}
