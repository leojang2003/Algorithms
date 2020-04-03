using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class MergeSortBook
    {
        /// <summary>
        /// 程式出自書 : 資料結構使用 Visual C#
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Sort(int[] input, int left, int right)
        {
            int j, k, item, mid, count;

            int len = input.Length;
            int[] data = new int[len];

            if (left < right)
            {
                mid = (left + right) / 2;
                Sort(input, left, mid);
                Sort(input, mid + 1, right);

                j = item = left;

                k = mid + 1;
                count = right - left + 1;

                while (j <= mid && k <= right)
                {
                    if (input[j] <= input[k])
                        data[item++] = input[j++];
                    else
                        data[item++] = input[k++];
                }

                while (j <= mid)
                    data[item++] = input[j++];
                while (k <= right)
                    data[item++] = input[k++];
                for (j = 0; j < count; j++, right--)
                    input[right] = data[right];
            }


        }

    }
}
