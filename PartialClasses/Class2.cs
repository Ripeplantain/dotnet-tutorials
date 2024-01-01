using System;


namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public void Print()
        {
            Console.WriteLine("Print method of PartialCustomer");
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}