using System;
using System.Globalization;

namespace praktika_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Task1(12));
            int[] array = { 33, 44, 55, 66 };
            Console.WriteLine(Task2(array, 55));


        }

        static int Task1(int x)
        {
            int sum = 0;
            while (x!=0)
            {
                int digit = x%10;
                sum += digit;
                x/=10;

            }
            return sum;
        }


        static int Task2(int[] Numbers, int num)
        {
            

            int sum = 0;

            foreach (int i in Numbers)
            {
                if (i == num)
                {
                    return sum;
                }
                sum++;
            }
            return -1;

            

        }
        







    }
}
