using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution7
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }
            s = s.ToLower();
            int index = s.Length - 1;

            while (index >= 0)
            {
                if (s[index] < 'a' || s[index] > 'z')
                {
                    s = s.Remove(index,1);
                    index--;
                }
                else
                {
                    index--;
                }
            }
            if (s.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
