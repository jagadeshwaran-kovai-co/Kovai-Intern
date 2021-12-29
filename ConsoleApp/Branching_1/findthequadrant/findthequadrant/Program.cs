using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findthequadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            int co1, co2;
            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the value of X coordinate: ");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of Y coordinate: ");
            co2 = Convert.ToInt32(Console.ReadLine());
            if((co1 > 0) && (co2 > 0))
            {
                Console.Write("The coordinate point ({0},{1}) lies in the First quadrant.\n\n",co1,co2);
            }
            else if((co1 < 0) && (co2 > 0))
            {
                Console.Write("The coordinate point ({0},{1}) lies in the Second quadrant.\n\n", co1, co2);
            }
            else if ((co1 < 0) && (co2 < 0))
            {
                Console.Write("The coordinate point ({0},{1}) lies in the Third quadrant.\n\n", co1, co2);
            }
            else if ((co1 > 0) && (co2 < 0))
            {
                Console.Write("The coordinate point ({0},{1}) lies in the Fourth quadrant.\n\n", co1, co2);
            }
            else
            {
                Console.Write("The coordinate point ({0},{1})lies at origin.\n\n", co1, co2);
            }
            Console.ReadLine();
        }
    }
}
