using System;

namespace assigment_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            operation(4, 5);
            Console.WriteLine(operation(4, 5));

        }
        public static Tuple<int, int> operation(int x, int y)
        {
            int res1;
            int res2;
            int num1 = x;
            int num2 = y;
            int lcm = 0;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            lcm = (num1 * num2) / y;
            res1 = lcm / num1;
            res2 = lcm / num2;

            return new Tuple<int, int>(res1, res2);
        }
    }
}
