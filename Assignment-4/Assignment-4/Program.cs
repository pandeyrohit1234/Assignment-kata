using System;
using System.Collections.Generic;
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var sc = SumConsecutives(new List<int>() { 1, 1, 3, 3, 7, 2, 2, 2, 2 });
            sc.ForEach(i => Console.WriteLine(i.ToString()));
        }
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> ret = new List<int>();
            int last = s[0], sum = 0;
            foreach (int i in s)
            {
                if (i == last) sum += last;
                else
                {
                    ret.Add(sum);
                    sum = last = i;
                }
            }
            ret.Add(sum);
            return ret;
        }
    }
}


