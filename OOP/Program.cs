using System;


namespace MyApplication;



class Program 
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        float area = c1.CalculateArea();
        Console.WriteLine($"Area: {area}");

        // Customer c1 = new Customer("John", "Doe");
        // c1.PrintFullName();

        // Customer c2 = new Customer("Jane", "Doe");
        // c2.PrintFullName();
    }
}


class Circle
{
    static float _pi = 3.141F;
    int _radius;

    public Circle(int radius)
    {
        this._radius = radius;
    }

    public float CalculateArea()
    {
        return Circle._pi * this._radius * this._radius;
    }
}


class Customer 
{
    string _firstname;
    string _lastname;


    public Customer(string firstname, string lastname)
    {
        this._firstname = firstname;
        this._lastname = lastname;
    }

    public void PrintFullName()
    {
        Console.WriteLine($"Fullname: {this._firstname} {this._lastname}");
    }
}