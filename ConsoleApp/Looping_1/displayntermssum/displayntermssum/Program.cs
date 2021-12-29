using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displayntermssum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, sum = 0;
            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Input Value of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number is :\n", n);
            for (i = 1; i <= n; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.Write("\nThe sum of Natural Number upto {0} terms : {1} \n",n, sum);
            Console.ReadLine();
        }
    }
}
