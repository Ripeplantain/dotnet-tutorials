using System;


namespace PartialClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PartialCustomer customer = new PartialCustomer();
            customer.FirstName = "John";
            customer.LastName = "Doe";
            Console.WriteLine("Full Name: {0}", customer.GetFullName());
            customer.Print();
        }
    }
}