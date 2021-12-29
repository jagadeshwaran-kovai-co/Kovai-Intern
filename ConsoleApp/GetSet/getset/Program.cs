using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Company
    {
        public string CompanyName { get; set; }
    }
    class Vechicle
    {
        public string VechicleName { get; set; }
    }
    class Order
    {
        public int Items { get; set; }
    }
    class Product
    {
        public int ProductId { get; set; }
    }
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Name = "jaga";
            Console.WriteLine(obj.Name);
            

            Product obj1 = new Product();
            obj1.ProductId = 01;
            Console.WriteLine(obj1.ProductId);

            Order obj2 = new Order();
            obj2.Items= 10;
            Console.WriteLine(obj2.Items);

            Vechicle obj3= new Vechicle();
            obj3.VechicleName = "R15 v3";
            Console.WriteLine(obj3.VechicleName);

            Company obj4 = new Company();
            obj4.CompanyName = "Kovai.co";
            Console.WriteLine(obj4.CompanyName);

            Console.ReadLine();

        }
    }
}
