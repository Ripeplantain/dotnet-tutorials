using System;

namespace Enums 
{

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class User
    {
        public string? Name {get; set;}
        public Gender Gender { get; set; }

        public static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            
            users[0] = new User 
            {
                Name = "Emmanuel",
                Gender = Gender.Unknown
            };

            users[1] = new User
            {
                Name = "Jessica",
                Gender = Gender.Male
            };

            users[2] = new User
            {
                Name = "Some random guy",
                Gender = Gender.Female
            };

            foreach(User user in users)
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Gender: {User.getGender(user.Gender)}");
                Console.WriteLine();
            }
        }
    }
}