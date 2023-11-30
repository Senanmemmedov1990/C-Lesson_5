using System;

namespace Praktika_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin:");

            int a;


            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("eded yazmaq lazimdir");
                    
                }
            }
            
            Console.WriteLine("Operator elave edin:");

            string c = (Console.ReadLine());

            Console.WriteLine("Yene eded yaz:");

            int b = int.Parse(Console.ReadLine());

            switch (c)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;

                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
                                   
        }
    }
}
