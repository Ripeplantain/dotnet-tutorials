using System;


namespace ConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        Student S1 = new Student();
        S1.Id = 101;
        S1.Name = "Mark";
        Console.WriteLine("Student Id = {0}", S1.Id);
        Console.WriteLine("Student Name = {0}", S1.Name);
        Console.WriteLine("Student PassMark = {0}", S1.PassMark);
    }
}


public class Student
{
    private int _id;
    private string? _name;
    private int _passMark  = 35;


    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = value;
        }

        get
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = value;
        }

        get
        {
            return this._id;
        }
    }

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
}