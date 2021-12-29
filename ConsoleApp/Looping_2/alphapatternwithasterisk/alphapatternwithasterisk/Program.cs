using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphapatternwithasterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'A' with asterisk.\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");
            for(row=0;row<=7;row++)
            {
                for(column=0;column<=7;column++)
                {
                    if(((column==1 || column==5) && row!=0) || ((row==0 || row==3) && (column>1 && column<5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
