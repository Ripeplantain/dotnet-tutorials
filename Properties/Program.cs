using System;


namespace ConsoleApplication;


class Program
{
    static void Main(string[] args)
    {
        Student S1 = new Student();
        S1.SetId(101);
        S1.SetName("Mark");
        Console.WriteLine("Student Id = {0}", S1.GetId());
        Console.WriteLine("Student Name = {0}", S1.GetName());
        Console.WriteLine("Student PassMark = {0}", S1.GetPassMark());
    }
}


public class Student
{
    private int _id;
    private string? _name;
    private int _passMark  = 35;

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._name = Name;
    }

    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id cannot be negative");
        }
        this._id = Id;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }

    public int GetPassMark()
    {
        return this._passMark;
    }

    public int GetId()
    {
        return this._id;
    }
}
