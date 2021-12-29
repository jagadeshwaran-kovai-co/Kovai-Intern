using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displaymultiplestable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("\n\n");
            Console.Write("Display the Multiplication table of a given integer:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int res = n*i;
                Console.WriteLine("{0} X {1} = {2}", n,i,res);
            }
            Console.ReadLine();
        }
    }
}
