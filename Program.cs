using System.Collections.Generic;

namespace ConsoleApp1
{

    internal class Program
    {
        public int Solve(int n, int k, int[] a)
        {
            for (int i = 0; i < k; i++)
            {
                if (a[i] == 1)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {

        }
    }
}