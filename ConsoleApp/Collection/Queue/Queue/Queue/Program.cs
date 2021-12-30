using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            Console.WriteLine($"No.of .Elements using Count : {numbers.Count()}");
            Console.WriteLine($"Elements using peek : {numbers.Peek()}");
            Console.WriteLine($"Elements using dequeued : {numbers.Dequeue()}");
            Console.WriteLine($"Elements 4 exist in stack : {numbers.Contains(4)}");
            numbers.Clear();
            Console.WriteLine($"No.of .Elements after cleared : {numbers.Count()}");
            Console.ReadLine();
        }
    }
}
