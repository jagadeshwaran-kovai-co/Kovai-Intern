using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofallelement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFind the sum of all elements of the array.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Input the number of elements to store in the array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nInput {num} number of elements in the array : \n");
            int i,sum=0;
            int[] number = new int[num];
            for (i = 0; i < num; i++)
            {
                Console.Write($"element - {i} : ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nSum of all elements stored in the array is : ");
            foreach (var item in number)
            {
                sum += item;
                
            }
            Console.Write(sum);
            
            Console.ReadLine();
        }
    }
}
