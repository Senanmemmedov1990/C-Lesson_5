using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalkulyator

            //    Console.WriteLine("Reqem daxil edin");
            //    int a =int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ikinci reqem daxil edin");
            //    int b = int.Parse(Console.ReadLine());
            //    int c = a + b;
            //    Console.WriteLine(c);

            // Array index sayi

            //int[] a = {1,2,3,4,5};
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;
            //a[3] = 4;
            //Console.WriteLine(a.Length - 1);


            //var source = new[] { 1,2, 3};
            //var target = new int[4];

            //source.CopyTo(target,1);

            //foreach (var item in target)
            //{
            //    Console.WriteLine(item);
            //}


            // bir arrayin elementlerini basqa arraye elave etmek



            var Senan = new[] { 1, 2, 3 };
            var Ilkin = new int[4];

            Senan.CopyTo(Ilkin, 0);

            foreach (int item in Ilkin)
            {
                Console.WriteLine(item);
            }



            // if else funksiyasi


            //Console.WriteLine("Yasinizi daxil edin:");
            //int a = int.Parse(Console.ReadLine());


            //if (a <= 18)
            //{
            //    Console.WriteLine("Yasiniz uygundur.");
            //}           
            //else Console.WriteLine("Yasiniz uygun deyil.");

            // work classi yaranir, work clasinda working metodu olur,/ employer adli class yaranir, employer clasi workden miras alir/
            // program.cs de employer obyekti yaranir ve working metodu cagrilir.



            //Employer employer = new Employer();
            //employer.working();

         

        }



    }



}
