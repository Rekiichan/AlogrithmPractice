using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution2
    {
        static public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        int size = digits.Length + 1;
                        int[] res = new int[size];
                        res[0] = 1;
                        for (int j = 1; j < size; j++)
                        {
                            res[j] = 0;
                        }
                        return res;
                    }
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            return digits;
        }
    }
}
