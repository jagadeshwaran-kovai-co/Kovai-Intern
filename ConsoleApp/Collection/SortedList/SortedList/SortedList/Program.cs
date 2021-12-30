using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> noNames = new SortedList<int, string>();
            noNames.Add(1, "One");
            noNames.Add(4, "Four");
            noNames.Add(2, "Two");
            noNames.Add(10, null);
            noNames.Add(3, "Three");
            Console.WriteLine("Sorted List : ");
            noNames[5] = "Five";
            foreach (var item in noNames)
                Console.Write("key: {0}, value: {1}", item.Key, item.Value);
            Console.Write("\n");
            Console.WriteLine($"Check Key- 4 Exist : {noNames.ContainsKey(4)}");
            Console.WriteLine("Trygetvalue of key using out : ");
            string result;
            if (noNames.TryGetValue(4, out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);
            Console.WriteLine("Using key and value in for loop :");
            for (int i = 0; i < noNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", noNames.Keys[i], noNames.Values[i]);
            }
            Console.WriteLine("Using Remove 10 key and RemoveAt 0 index: ");
            noNames.Remove(10);
            noNames.RemoveAt(0);
            for (int i = 0; i < noNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", noNames.Keys[i], noNames.Values[i]);
            }

            Console.ReadLine();



        }
    }
}
