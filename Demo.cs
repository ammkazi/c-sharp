using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example of a simple method call
            GreetUser("GitHub Copilot");

            // Create a Person object
            Person person = new Person("John Doe", "john.doe@example.com", "123-456-7890");
            Console.WriteLine($"Person created: {person.Name}, {person.Email}, {person.PhoneNo}");
        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }
    }
}