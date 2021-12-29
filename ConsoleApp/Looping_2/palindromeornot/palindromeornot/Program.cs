using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeornot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, t;
            Console.Write("\n\n");
            Console.Write("Check whether a number is a palindrome or not:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
                Console.Write("{0} is a palindrome number.\n", t);
            else
                Console.Write("{0} is not a palindrome number.\n", t);
            Console.ReadLine();
        }
    }
    
}
