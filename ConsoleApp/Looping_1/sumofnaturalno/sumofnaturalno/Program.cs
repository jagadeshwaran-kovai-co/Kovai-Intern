using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofnaturalno
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sum=0;
            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.WriteLine("The first 10 natural number is: ");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write("{0} ", i);
            }
            Console.Write("\nThe sum is {0} \n",sum);
            Console.ReadLine();
        }
    }
}
