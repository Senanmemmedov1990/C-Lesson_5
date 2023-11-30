using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem yazin:");

            string num1 = Console.ReadLine();

            Console.WriteLine("Yene yaz reqem");

            string num2 = Console.ReadLine();

            int a = Convert.ToInt32(num1);

            int b = Convert.ToInt32(num2);

            Console.WriteLine(a + b);



            //int[] array1 = new int[3];

            //array1[0] = 5;
            //array1[1] = 5;
            //array1[2] = 5;

            //int sum = array1[0] + array1[1] + array1[2];
            //Console.WriteLine(sum);

            //int sum1 = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sum1 += array1[i];
            //}
            //Console.WriteLine(sum1);









            //int[] array1 = new int[3];

            //array1[0] = 12;
            //array1[1] = 9;
            //array1[2] = 10;

            //int sum = array1[0] + array1[1] + array1[2];

            //int sum1 = 0;

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sum1 += array1[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum1);

        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string var = 
        //}

        //public string Reverse(string text)
            
        //{
            
        //    if (text == null) return null;
        //    char[] array = text.ToCharArray();
        //    Array.Reverse(array);
        //    return new string(array);
            
        //}
        
        





        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) return false;

        //    for ( int i = 2; i < num / 2; i++ )
        //    {
        //        if (num % i == 0) return false;
        //    }
            
        //}
        
        
    }
    
}
