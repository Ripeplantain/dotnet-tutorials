using System;
using System.Reflection;


namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("Reflection.Customer");

            Console.WriteLine("Full Name = {0}", t.FullName);
            Console.WriteLine("Name = {0}", t.Name);
            Console.WriteLine("Namespace = {0}", t.Namespace);
        
            Console.WriteLine();
            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = t.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = t.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
        }
    }


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void PrintId()
        {
            Console.WriteLine("Id = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}