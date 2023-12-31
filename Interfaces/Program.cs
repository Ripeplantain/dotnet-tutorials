using System;


namespace Interfaces;


interface ICustomer
{
    void Print();
}

interface I2
{
    void I2Method();
}

class Customer : ICustomer, I2
{
    public void Print()
    {
        Console.WriteLine("Print method");
    }

    public void I2Method()
    {
        Console.WriteLine("I2Method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        c1.Print();
        c1.I2Method();
    }
} 