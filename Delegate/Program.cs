using System;
using System.Collections.Generic;


namespace Delegate;


delegate bool IsPromotable(Employee emp);

class Employee
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>();

        employeeList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
        employeeList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
        employeeList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
        employeeList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

        // IsPromotable isPromotable = new IsPromotable(Promote);

        // Employee.PromoteEmployee(employeeList, isPromotable);

        Employee.PromoteEmployee(employeeList, emp => emp.Experience >= 5);
    }

}