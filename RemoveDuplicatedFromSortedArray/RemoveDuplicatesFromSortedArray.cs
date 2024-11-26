using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveDuplicatedFromSortedArray
{
    internal class RemoveDuplicatesFromSortedArray
    {

        public static int RemoveDuplicates(int[] nums)
        {
            var count = 1;
            var currIndex = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    continue;

                nums[currIndex] = nums[i + 1];
                currIndex++;
            }

            return currIndex;
        }
    }
}
