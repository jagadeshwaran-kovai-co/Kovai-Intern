using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readanddisplayinreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nRead n number of values in an array and display it in reverse order");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Input the number of elements to store in the array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nInput {num} number of elements in the array : ");
            int i;
            int[] number = new int[num];
            for (i = 0; i < num; i++)
            {
                Console.Write($"element - {i} : ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe values store into the array are : ");
            foreach(var item in number)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.Write("\n\nThe values store into the array in reverse are : ");
            Array.Reverse(number);
            foreach (var item in number)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
