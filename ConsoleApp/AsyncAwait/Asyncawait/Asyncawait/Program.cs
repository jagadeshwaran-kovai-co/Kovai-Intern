using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Asyncawait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Firstline();
            ThirdLine(3, 3);
            Secondline();
            
            Console.ReadKey();
            async Task Firstline ()
            {
                Console.WriteLine("Frist Line");
            }
            async Task Secondline()
            {
                Console.WriteLine("Second Line");

            }
            async Task ThirdLine(int x,int y)
            {
                int c;
                c = x + y;
                await Task.Delay(1000);

                Console.WriteLine(c);
            }

        }
    }
}