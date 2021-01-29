using System;
using System.Collections.Generic;
using System.Linq;




namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyDictionary");
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
            MyDictionary.Add(1, "Armağan");
            MyDictionary.Add(2, "Engin");
            MyDictionary.Add(3, "Semiha");
            // foreach list sample
            Console.WriteLine("foreach sample for access MyDictionary Values");
            foreach (string item in MyDictionary.Values)
            {
                Console.WriteLine(item);
            }
            // myDictionary.List sample
            Console.WriteLine("MyDictionary.List");
            MyDictionary.Last();
            Console.ReadLine();
        }
    }

}
   