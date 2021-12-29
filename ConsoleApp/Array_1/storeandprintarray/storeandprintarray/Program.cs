using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeandprintarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read and Print elements of an array: ");
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine("Input 10 elements in the array :");
            int[] num=new int[10];
            int i;
            for(i=0;i<10;i++)
            {
                Console.Write($"element - {i} :");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(num[i]);
                Console.Write(" ");
            }
            Console.ReadLine();


        }
    }
}
