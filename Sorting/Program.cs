using System;


namespace Sorting 
{
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[4];

            customers[0] = new Customer { ID = 101, Name = "Mark", Salary = 4000 };
            customers[1] = new Customer { ID = 102, Name = "Pam", Salary = 7000 };
            customers[2] = new Customer { ID = 103, Name = "John", Salary = 5500 };
            customers[3] = new Customer { ID = 104, Name = "Ken", Salary = 6500 };

            Array.Sort(customers);

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.Salary);
            }

            Console.ReadLine();
        }
    }

}