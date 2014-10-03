using System;
using System.Text.RegularExpressions;
namespace DefiningClasses
{

    class Persons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            if (name == string.Empty)
            {
                throw new ArgumentException("Invalid name: The name must not be empy field!");
            }
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            if (age < 1 || age > 100)
            {
                throw new ArgumentException("Invalid age: The age must be in range 1-100");
            }
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            string pat = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex reg = new Regex(pat);
            Match match = reg.Match(email);
            if (email != string.Empty && match.Success == false)
            {
                throw new ArgumentException("Invalid Argument: The email must be null or non-empty string containing @");
            }
            Person man = new Person(name, age, email);
            Console.WriteLine(man.ToString());
        }
    }
}
