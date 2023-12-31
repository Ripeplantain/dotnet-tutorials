using System;
using System.Collections.Generic;
using System.Reflection;


public class Program
{
    static void Main(string[] args)
    {
        // int answer = Calculator.Add(1, 2);
        // int result = Calculator.Add(1, 2, 3);

        // Console.WriteLine($"Answer: {answer}");
        // Console.WriteLine($"Result: {result}");

        int total = Calculator.Add(new List<int> { 1, 2, 3, 4, 5 });
        Console.WriteLine($"Total: {total}");
    }
}


public class Calculator
{
    [ObsoleteAttribute("Use Add(List<int> numbers) instead")]
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    [ObsoleteAttribute("Use Add(List<int> numbers) instead")]
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}