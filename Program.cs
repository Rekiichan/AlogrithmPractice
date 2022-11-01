using AlogrithmPractice;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = {1,3,2,4,5};
            //int a = 5;
            //string s = "0P";
            Solution10 s = new Solution10();
            var res = s.AddBinary("101110", "1011");
            Console.WriteLine(res);

        }
        static void DisplayList<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }

        
    }
}