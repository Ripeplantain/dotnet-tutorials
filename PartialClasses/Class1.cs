using System;


namespace PartialClasses
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
}