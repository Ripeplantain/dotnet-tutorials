using System;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("First: " + list[0]);
            Console.WriteLine("Contains 3: " + list.Contains(3));
            Console.WriteLine("Contains 7: " + list.Contains(7));
            Console.WriteLine("Exists 4: " + list.Exists(num => num == 4));
            Console.WriteLine("IndexOf 3: " + list.IndexOf(3));
            Console.WriteLine("IndexOf 7: " + list.IndexOf(7));
            Console.WriteLine("Remove 3: " + list.Remove(3));
            Console.WriteLine("Remove 7: " + list.Remove(7));
            Console.WriteLine("Count: " + list.Count);

            Console.WriteLine("--------------------");

            list.Insert(0, 0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Clear();
            Console.WriteLine();
            Console.WriteLine("Count: " + list.Count);
        }
    }
}