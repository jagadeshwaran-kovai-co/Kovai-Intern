using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            Console.WriteLine($"No.of .Elements using Count : {numbers.Count()}");
            Console.WriteLine($"Elements using peek : {numbers.Peek()}");
            Console.WriteLine($"Elements using pop : {numbers.Pop()}");
            Console.WriteLine($"Elements 4 exist in stack : {numbers.Contains(4)}");
            numbers.Clear();
            Console.WriteLine($"No.of .Elements after cleared : {numbers.Count()}");
            Console.ReadLine();
        }
    }
}
