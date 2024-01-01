using System;
using System.Collections.Generic;

namespace Indexes
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "Thomas", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "Kelsey", Gender = "Female" });
        }

        public string this[int employeeId]
        {
            get
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.EmployeeId == employeeId)
                    {
                        return employee.Name;
                    }
                }
                // Return a default value when employeeId is not found
                return "Employee not found";
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.EmployeeId == employeeId)
                    {
                        employee.Name = value;
                    }
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Employee Name: {0}", company[1]);
            Console.WriteLine("Employee Name: {0}", company[2]);
            Console.WriteLine("Employee Name: {0}", company[3]);
        }
    }
}
