using System;
using System.Collections.Generic;
using System.Linq;

namespace Praktika_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            List<Student> list = new List<Student>();

            list.Add(new Student() { Name= "Mario", Grade = 99 });
            list.Add(new Student() { Name= "Senan", Grade = 100 });
            list.Add(new Student() { Name= "Ruslan", Grade = 50 });

            //foreach (Student item in list.OrderByDescending(x=>x.Grade))
            //{
            //    Console.WriteLine(item.Name + " " +item.Grade);
            //}


            List<int> ints = new List<int> { 1, 3, 4, 33, 11, -5, 0, -10 };

            var a = ints.Where(x => x > 10);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }
    }
    class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }

    }
}
