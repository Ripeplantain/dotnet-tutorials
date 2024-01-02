using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> contactsDictionary = new Dictionary<int, string>();
            contactsDictionary.Add(1, "John");
            contactsDictionary.Add(2, "Mary");
            contactsDictionary.Add(3, "Peter");
            contactsDictionary.Add(4, "Jane");
            contactsDictionary.Add(5, "Bob");

            Console.WriteLine("Contacts Dictionary");
            Console.WriteLine("-------------------");
            Console.WriteLine("Count: " + contactsDictionary.Count);
            Console.WriteLine($"{contactsDictionary[1]}");

            foreach (var contact in contactsDictionary)
            {
                Console.WriteLine($"{contact.Key} - {contact.Value}");
            }

            Console.WriteLine("------------------");

            if (contactsDictionary.TryGetValue(10, out string contact1))
            {
                Console.WriteLine($"Contact 1: {contact1}");
            } else
            {
                Console.WriteLine("Contact 1 not found");
            }
        }
    }
}