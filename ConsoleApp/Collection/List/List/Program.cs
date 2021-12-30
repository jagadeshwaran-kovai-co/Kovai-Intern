using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int>() { 1, 2, 3, 4, 5, 6 };
            numbers.Add(7);
            numbers.Add(8);
            Console.WriteLine($"index at 0 :{numbers[0]}");
            Console.WriteLine($"Count : {numbers.Count()}");
            Console.WriteLine("Print ForEach LINQ Method :");
            numbers.ForEach(num => Console.Write(num + ", "));
            Console.Write("\n");
            int[] no = new int[] { 9, 10, 11 };
            numbers.AddRange(no);
            numbers.Insert(0, 0);
            Console.WriteLine($"After adding element using addrange and insert : {numbers.Count()}");
            numbers.Remove(0);
            numbers.RemoveAt(11 - 1);
            Console.WriteLine($"After using remove and removeat : {numbers.Count()}");
            Console.WriteLine($"Element Contains : {numbers.Contains(11)}");
            Console.ReadKey();
        }
    }
}
