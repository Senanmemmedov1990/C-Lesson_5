using System;

namespace Test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //istifadeciden indeksler alib ekrana yazmaq

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write("Num arrayinden" +" "+ (i + 0) + ". index daxil edin:");

            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("-----------------------");

            //for (int i = 0;i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}



            // Array : istifadeciden alinan reqemlerin olub olmamasini yoxlamaq ve nece dene oldugunu tapmaq


            //int[] reqemler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //int eded = 0;

            //int reqem;

            //Console.Write("Reqem daxil edin:");

            //reqem = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < reqemler.Length; i++)
            //{
            //    if (reqemler[i] == reqem)
            //    {
            //        eded++;
            //    }

            //}
            //if (eded ==0)
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem tapilmadi");
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem tapildi");
            //    Console.WriteLine(eded);
            //}



            // Array :  istifadeciden 10 eded reqem almaq, onlarin tek veya cut oldugunu tapmaq ve onlari toplayib hansinin daha boyuk oldugunu tapmaq


            //    int[] ededler = new int[10];
            //    int tekededlericemi = 0;
            //    int cutededlerincemi = 0;
            //    int tekededlerinsayi = 0;
            //    int cutededlerinsayi = 0;

            //    int deyer;

            //    for (int i = 0; i < ededler.Length; i++)
            //    {
            //        Console.Write((i + 0) + ".index deyerini yazin:");
            //        deyer = int.Parse(Console.ReadLine());

            //        ededler[i] = deyer;
            //    }

            //    for (int j = 0; j < ededler.Length; j++)
            //    {
            //        if (ededler[j]%2  == 0)
            //        {
            //            cutededlerincemi++;
            //            cutededlerinsayi += ededler[j];
            //        }
            //        else
            //        {
            //            tekededlericemi++;
            //            tekededlerinsayi += ededler[j];
            //        }

            //    }
            //    if (tekededlerinsayi < cutededlerinsayi)
            //    {
            //        Console.WriteLine("Cut ededlerin sayi daha coxdur");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Tek ededlerin sayi daha coxdur");
            //    }

            //    Console.WriteLine("Cut ededlerin sayi:" + cutededlerincemi);
            //    Console.WriteLine("Cut ededlerin cemi:" + cutededlerinsayi);

            //    Console.WriteLine("----------------------");

            //    Console.WriteLine("Tek ededlerin sayi:" + tekededlericemi);
            //    Console.WriteLine("Tek ededlerin cemi:" + tekededlerinsayi);


            //}
        }
    }
    class CustomArraylist
    {
        public int Count { get; set; }
        public int Capacity { get; set; }
    }
        
}
