using System;
using System.Collections.Generic;


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
            numbers.Enqueue(5);

            int firstNumber = numbers.Peek();
            Console.WriteLine("First number: {0}", firstNumber);

            // int removedNumber = numbers.Dequeue();

            // Console.WriteLine("Removed number: {0}", removedNumber);
        }
    }
}