using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    public class Solution1
    {
        public static int MajorityElement(int[] nums)
        {
            int size = nums.Length / 2;
            int[] Count = new int[1000];
            int[] SigCount = new int[1000];
            foreach (int i in nums)
            {
                if (i >= 0)
                {
                    Count[i]++;
                    if (Count[i] > size)
                    {
                        return i;
                    }
                }
                else
                {
                    SigCount[i*-1]++;
                    if (SigCount[i * -1] > size)
                    {
                        return i;
                    }
                }
                
            }
            return -1;
        }
    }
}
