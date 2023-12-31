using System;


namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual<int>(1, 2);
            if (Equal)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}