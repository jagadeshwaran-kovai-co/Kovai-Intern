using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyofarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTo copy the elements one array into another array.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Input the number of elements to store in the array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nInput {num} number of elements in the array : \n");
            int i;
            int[] number = new int[num];
            int[] newNumber = new int[num];
            for (i = 0; i < num; i++)
            {
                Console.Write($"element - {i} : ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe elements stored in the first array are : ");
            for (i=0;i<num;i++)
            {
                newNumber[i] = number[i];
                Console.Write(number[i]);
                Console.Write(" ");

            }
            Console.WriteLine("\nThe elements copied into the second array are :");
            foreach (var item in newNumber)
            {
                Console.Write(item);
                Console.Write(" ");

            }
            Console.ReadLine();
        }
    }
}
