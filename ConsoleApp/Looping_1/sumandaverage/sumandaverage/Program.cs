using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumandaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,sum=0,avg=0;
            Console.Write("\n\n");
            Console.Write("Find Sum and Average of Numbers:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Input the 10 numbers: ");
            Console.Write("Number-1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-2 :");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-3 :");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-4 :");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-5 :");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-6 :");
            n6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-7 :");
            n7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-8 :");
            n8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-9 :");
            n9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-10 :");
            n10 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            Console.WriteLine("The sum of 10 no is : {0}", sum);
            avg = sum / 10;
            Console.WriteLine("The Average is : {0}",avg);
            Console.ReadLine();
        }
    }
}
