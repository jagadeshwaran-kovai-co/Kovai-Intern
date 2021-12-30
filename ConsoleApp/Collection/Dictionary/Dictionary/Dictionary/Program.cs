using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> noDict = new Dictionary<int, string>();
            noDict.Add(1, "One");
            noDict.Add(4, "Four");
            noDict.Add(2, "Two");
            noDict.Add(3, "Three");
            foreach (var item in noDict)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            Console.WriteLine($"Key 1 value : {noDict[1]}"); 
            Console.WriteLine($"Key 2 Exist using containkey : { noDict.ContainsKey(2)}");
            Console.WriteLine($"Key 3 Exist using Trygetvalue : ");

            string result;

            if (noDict.TryGetValue(3, out result))
            {
                Console.WriteLine(result);
            }
            Console.WriteLine($"Using ElementAt  :");
            for (int i = 0; i < noDict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",noDict.ElementAt(i).Key,noDict.ElementAt(i).Value);
            }
            Console.WriteLine("Remove element : ");
            noDict.Remove(1);
            Console.WriteLine("Elements after removal of key 1 :");
            for (int i = 0; i < noDict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", noDict.ElementAt(i).Key, noDict.ElementAt(i).Value);
            }
            noDict.Clear();
            Console.Write($"Elements after removal of all elements :{noDict.Count()}");
            Console.ReadLine();

        }
    }
}
