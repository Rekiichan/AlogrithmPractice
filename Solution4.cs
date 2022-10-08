using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution4
    {
        public static bool IsHappy(int n)
        {
            int tmp = 0;
            int sum = 0;
            if (n < 10 && n >1)
            {
                return false;
            }
            while (true)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
                if (n == 0)
                {
                    if (sum < 10)
                    {
                        if (sum == 1)
                            return true;
                        return false;
                    }
                    else
                    {
                        n = sum;
                        sum = 0;
                    }
                }
            }    
            return false;
        }
    }
}
