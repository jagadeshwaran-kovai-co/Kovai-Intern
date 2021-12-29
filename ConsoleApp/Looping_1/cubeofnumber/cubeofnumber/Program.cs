using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeofnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("\n\n");
            Console.Write("Display the Cube of Number upto given integer:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                int res = i * i * i;
                Console.WriteLine("Number is : {0} and cube of the 1 is : {1}", i, res);
            }
            Console.ReadLine();
        }
    }
}
