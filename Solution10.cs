using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    public class Solution10
    {
        public string Add(string a, string b)
        {
            if (a == "1")
            {
                if (b == "1")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else
            {
                if (b == "1")
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
        }
        public string AddBinary(string a, string b)
        {
            double num_a = 0;
            double num_b = 0;
            double mu = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == '1')
                {
                    num_a += Math.Pow(2.0,mu);
                }
                mu += 1;
            }
            mu = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] == '1')
                {
                    num_b += Math.Pow(2.0, mu);
                }
                mu += 1;
            }
            double sum = num_a + num_b;
            if ((int) sum == 0)
            {
                return "0";
            }
            int val = (int)sum;
            string res = "";
            while (val > 0)
            {
                int tem = (int)val % 2;
                res += (tem).ToString();
                val /= 2;
            }
            string res_rev = "";
            for (int i = res.Length - 1; i >= 0; i--)
            {
                res_rev += res[i].ToString();
            }
            return res_rev;
        }
    }
}
