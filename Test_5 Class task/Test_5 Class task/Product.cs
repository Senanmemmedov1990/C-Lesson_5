using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_Class_task
{
    public class Product
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public double Commissions { get; set; }
        public double Income { get; set; }
        public int Count { get; set; }

        public Product(int id, string brandName, string model, double price, double commissions, double income, int count)
        {
            this.Id = id;
            this.BrandName = brandName;
            this.Model = model;
            this.Price = price;
            this.Commissions = commissions;
            this.Income = income;
            this.Count = count;
        }

        public void GetInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Brand Name: {0}", this.BrandName);
            Console.WriteLine("Model: {0}", this.Model);
            Console.WriteLine("Price: {0}", this.Price);
            Console.WriteLine("Commissions: {0}", this.Commissions);
            Console.WriteLine("Income: {0}", this.Income);
            Console.WriteLine("Count: {0}", this.Count);
        }

        public bool Sale()
        {
            if (this.Count > 0)
            {
                double salePrice = this.Price - this.Commissions;
                this.Income += salePrice;
                this.Count--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
