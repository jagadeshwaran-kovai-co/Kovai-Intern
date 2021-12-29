using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heightandcategorizeofperson
{
    class Program
    {
        static void Main(string[] args)
        {
            float PerHeight;
            Console.Write("\n\n");
            Console.Write("Accept the height of aperson in centimeter and categorize them:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the height of the person(in centimeter): ");
            PerHeight = Convert.ToInt32(Console.ReadLine());
            if(PerHeight<150.0)
            {
                Console.Write("The person is Dwarf \n\n");
            }
            else if((PerHeight>=150.0)&&(PerHeight<=165.0))
            {
                Console.Write("The person is average heighted  \n\n");
            }
            else if((PerHeight >= 165.0) && (PerHeight <= 195.0))
            {
                Console.Write("The person is taller  \n\n");
            }
            else
            {
                Console.Write("Abnormal height \n\n");
            }
            Console.ReadLine();

        }
    }
}
