using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdefinefunction
{
    class Program
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {

            Console.Write("\n\n To create an user define function :\n");
            Console.Write("------------------------------------------------\n");
            welcome();
            HaveAnice();
            Console.Write("\n");
            Console.ReadLine();
            
        }
    }
}
