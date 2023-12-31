using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee(
                "John",
                "Doe",
                "test@test.com",
                30000 // Yearly salary in this example is considered as an integer
            );
            fte.PrintFullName(); // This will call the method from the base class
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee(string firstname, string lastname, string email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Fullname: {this.FirstName} {this.LastName}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        // Constructor of FullTimeEmployee class
        public FullTimeEmployee(string firstname, string lastname, string email, float yearly_salary)
            : base(firstname, lastname, email) // Calls base class constructor
        {
            this.YearlySalary = yearly_salary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public float HourlyRate;

        // Constructor of PartTimeEmployee class
        public PartTimeEmployee(string firstname, string lastname, string email, float hourly_rate)
            : base(firstname, lastname, email) // Calls base class constructor
        {
            this.HourlyRate = hourly_rate;
        }
    }
}
