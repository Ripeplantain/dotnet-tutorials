using System;
using System.Collections.Generic;


namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            // int lastNumber = numbers.Peek();
            // Console.WriteLine("Last number: {0}", lastNumber);

            int removedNumber = numbers.Pop();
            Console.WriteLine("Removed number: {0}", removedNumber);
        }
    }
}