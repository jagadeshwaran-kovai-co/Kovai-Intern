using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displaymultiplesvertical
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            Console.Write("\n\n");
            Console.Write("Display the Multiplication table vertically from 1 to n:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input upto the number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to {0}", n);
            for (i = 1; i <=10; i++)
            {
                for(j=1;j<=n;j++)
                {
                    Console.Write("{0} X {1} = {2}, ", j, i, i * j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
