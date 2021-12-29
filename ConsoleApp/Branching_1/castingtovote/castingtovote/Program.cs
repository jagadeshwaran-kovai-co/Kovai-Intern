using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castingtovote
{
    class Program
    {
        static void Main(string[] args)
        {
            int vote_age;
            Console.Write("\n\n");
            Console.Write("Determine a specific age is eligible for casting the vote:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the age of the candidate: ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if(vote_age<18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year .\n\n",18-vote_age);
            }
            else
            {
                Console.Write("Congratulational ! You are eligible for casting your vote.\n\n");
            }
            Console.ReadLine();
        }
    }
}
