﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveornegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("\n\n");
            Console.Write("Check whether a numberr is positive or negative :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("{0} is a positive number.\n", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number.\n", num);
            }
            Console.ReadLine();
        }
    }
}
