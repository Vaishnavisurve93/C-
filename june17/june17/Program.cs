using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Riya", "Deo", 28),
            new Person("Vaishnavi", "Surve", 35),
            new Person("shourya", "surve", 42),
            new Person("Michael", "jackson", 30),
            new Person("Rohit", "sippy", 31),
            new Person("Sonakshi", "Rastogi", 25)
        };

        // a) Calculate the average age of all persons.
        double averageAge = people.Average(p => p.Age);
        Console.WriteLine($"Average age of all persons: {averageAge:F2}");

        // b) Find and print the oldest and youngest person's full name.
        Person oldestPerson = people.OrderByDescending(p => p.Age).First();
        Person youngestPerson = people.OrderBy(p => p.Age).First();

        Console.WriteLine($"\nOldest person: {oldestPerson.FirstName} {oldestPerson.LastName}, Age: {oldestPerson.Age}");
        Console.WriteLine($"Youngest person: {youngestPerson.FirstName} {youngestPerson.LastName}, Age: {youngestPerson.Age}");
        Console.ReadLine();
    }
}

