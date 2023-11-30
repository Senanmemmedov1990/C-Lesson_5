using System;
using System.Net.Security;

namespace Test_5_Class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "Apple", "iPhone 13 Pro Max", 1000, 20, 0, 10);
            var product1 = new Product(2, "Samsung", "A50", 800, 10, 0, 5);

            product.Sale();
            product.GetInfo();

            product1.Sale();
            product1.GetInfo();

            

        }
    }
    
}
