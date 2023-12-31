using System;


namespace Structure;


class Program
{
    static void Main(string[] args)
    {
    
    }
}


public struct Customer
{
    private int _id;
    private string _name;

    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }
}