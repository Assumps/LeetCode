using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeSortedArray
{
    public class MergeSortedArray
    {

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //Brute force
            int i = 0;
            int j = 0;

            while (i < n)
            {
                nums1[m++] = nums2[j++];
                i++;
            }

            Array.Sort(nums1);

            //while (j < n)
            //{
            //    nums3[k++] = nums2[j++];
            //}

            //Array.Sort(nums3);

            //nums1 = nums3;

            //foreach (var item in nums1)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
