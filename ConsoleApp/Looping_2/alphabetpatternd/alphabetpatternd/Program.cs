﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetpatternd
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'D' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
