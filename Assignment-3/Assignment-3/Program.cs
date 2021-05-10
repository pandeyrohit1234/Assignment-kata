using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteNth(new int[] { 20, 37, 20, 21 }, 1);
            DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
            Console.WriteLine();
        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            var occurences = new Dictionary<int, int>();
            var resultList = new List<int>();
            foreach (var number in arr)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences[number] = 1;
                }

                if (occurences[number] <= x)
                {
                    resultList.Add(number);
                }
            }
            resultList.ForEach(i => Console.WriteLine(i.ToString()));
            return resultList.ToArray();
        }
    }
}


