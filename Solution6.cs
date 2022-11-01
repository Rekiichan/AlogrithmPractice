using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution6
    {
        public static void NextPermutation(int[] nums)
        {
            try
            {
                if (nums.Length == 2)
                {
                    (nums[0], nums[1]) = (nums[1], nums[0]);
                }
                else
                {
                    int i;
                    for (i = nums.Length - 2; i >= 0; i--)
                    {
                        if (nums[i] < nums[i + 1])
                        {
                            break;
                        }
                    }
                    int j = nums.Length - 1;
                    while (nums[j] <= nums[i])
                    {
                        j--;
                    }
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    Array.Sort(nums, i + 1, nums.Length - (i + 1));
                }
            }
            catch (Exception)
            {
                Array.Sort(nums);
            }
        }
    }
}
