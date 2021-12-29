using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofelementinarray
{
    class Program
    {
        public static int Sum(int[] arr1)
        {
            int tot = 0;
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.Write("Input 5 elements in the array :\n");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr1));
            Console.ReadLine();
        }
    }
}
