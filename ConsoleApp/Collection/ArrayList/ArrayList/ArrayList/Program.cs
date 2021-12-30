using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListAll = new ArrayList(){2, "Steve", " ", true, 4.5, null};
            Console.WriteLine("\nPrint Array List :");
            foreach (var item in ListAll)
                Console.Write(item + ", ");
            int[] arr = { 100, 200, 300, 400 };
            ListAll.AddRange(arr);
            Console.WriteLine("\nElements after using addrange : ");
            foreach (var item in ListAll)
                Console.Write(item + ", ");
            Console.WriteLine("\nElement after Insert at index 1 : ");
            ListAll.Insert(1, "Jaga");
            foreach (var item in ListAll)
                Console.Write(item + ", ");

            Console.WriteLine("\nRemove & Removeat index :");
            ListAll.Remove("Jaga");
            ListAll.RemoveAt(5);
            foreach (var item in ListAll)
                Console.Write(item + ", ");
            Console.WriteLine($"\nElement 2 exist in list : {ListAll.Contains(2)}");
            Console.ReadLine();


        }
    }
}
