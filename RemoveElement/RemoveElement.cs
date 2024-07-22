using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveElement
{
    public class RemoveElement
    {

        public static int RemovesElement(int[] nums, int val)
        {
            //Brute force
            //if(nums.Length == 0) return 0;

            //List<int> auxArray = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i] == val)
            //        continue;

            //    auxArray.Add(nums[i]);
            //}

            //return auxArray.Count;

            //LeetCode Solution
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

    }
}
