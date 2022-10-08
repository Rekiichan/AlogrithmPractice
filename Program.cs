using AlogrithmPractice;
using System.Collections.Generic;

namespace ConsoleApp1
{

    internal class Program
    {
        static void DisplayList<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = {5,1,1};
            Solution6.NextPermutation(array);
            DisplayList<int>(array);
            //Console.WriteLine(Solution5.Generate(5));
        }
    }
}