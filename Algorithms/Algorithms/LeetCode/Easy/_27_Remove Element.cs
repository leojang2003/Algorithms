using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode.Easy
{
    public class _27_Remove_Element
    {
        /*
         * Runtime: 420 ms, faster than 7.56% of C# online submissions for Remove Element.
         *   Memory Usage: 29.7 MB, less than 99.83% of C# online submissions for Remove Element.
         */
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int final_length = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    continue;
                else
                {
                    nums[count] = nums[i];
                    final_length++;
                    count++;
                }                    
            }

            return final_length;
        }


        /*
         * Runtime: 232 ms, faster than 96.94% of C# online submissions for Remove Element.
         * Memory Usage: 30 MB, less than 89.63% of C# online submissions for Remove Element.
         */
        public int RemoveElement2(int[] nums, int val)
        {
            int count = 0;
            //int final_length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    continue;
                else
                {
                    nums[count] = nums[i];
                    //final_length++;
                    count++;
                }
            }
            return count;
        }

        /*
         * When we encounter nums[i] = valnums[i]=val, we can swap the current element out with the last element and dispose the last one. 
         * This essentially reduces the array's size by 1. 
         * Note that the last element that was swapped in could be the value you want to remove itself. But don't worry, in the next iteration we will still check this element.
         */
        public int RemoveElement3(int[] nums, int val)
        {
            int count = 0;
            //int final_length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    continue;
                else
                {
                    nums[count] = nums[i];
                    //final_length++;
                    count++;
                }
            }
            return count;
        }
    }
}
