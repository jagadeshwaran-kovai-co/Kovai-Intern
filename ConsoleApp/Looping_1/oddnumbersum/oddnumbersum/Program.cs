using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddnumbersum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,sum=0;
            Console.Write("\n\n");
            Console.Write("Display the n terms of odd natural number and their sum\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are :");
            for(i=1;i<=2*n;i=i+2)
            {
                sum += i;
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1}", n, sum);
            Console.ReadLine();
                
        }
    }
}
