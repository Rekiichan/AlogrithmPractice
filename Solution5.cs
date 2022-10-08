using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution5
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> list = new List<IList<int>>();
            if (numRows == 1)
            {
                List<int> ints = new List<int>();
                ints.Add(1);
                list.Add(ints);
                return list;
            }
            else
            {
                List<int> ints = new List<int>();
                ints.Add(1);
                list.Add(ints);
                List<int> ints2 = new List<int>();
                ints2.Add(1);
                ints2.Add(1);
                list.Add(ints2);
            }
            for (int i = 3; i < numRows; i++)
            { 
                for (int j = 1; j < i - 1; j++)
                {
                    List<int> ints = new List<int>();
                    for (int k = 0; k < i - 2; k++)
                    {
                        
                        int tmp = list[i - 1][k] + list[i - 1][k + 1];
                        ints.Add(tmp);
                    }
                    list.Add(ints);
                }
            }
            foreach (var item in list)
            {
                foreach (var item2 in item)
                    Console.WriteLine(item2);
            }
            return list;
        }
    }
}


