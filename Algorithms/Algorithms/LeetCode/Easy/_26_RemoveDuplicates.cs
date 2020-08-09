using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode.Easy
{
    public class _26_RemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int count = 1;
            int previous = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != previous)
                {
                    count++;
                    nums[count - 1] = nums[i];
                    previous = nums[i];
                }
                    
                else
                    continue;
            }
            return count;
        }
    }
}
