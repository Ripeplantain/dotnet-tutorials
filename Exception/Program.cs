using System;
using System.IO;


namespace TestApplication;


class Program
{
    static void Main(string[] args)
    {
        try {
            try {
                Console.WriteLine("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
    
                int result = num1 / num2;
                Console.WriteLine("Result: {0}", result);
            } catch (Exception ex) {
                string filePath = @"../error.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath, true);
                    sw.Write(DateTime.Now);
                    sw.WriteLine();
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.WriteLine();
                    sw.Close();
                    Console.WriteLine("There is a problem, please try later");
                }
                else {
                    throw new FileNotFoundException(filePath + " is not present", ex);
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Current Exception: {0}", ex.GetType().Name);
            Console.WriteLine("Inner Exception: {0}", ex.InnerException.GetType().Name);
        }
    }
}