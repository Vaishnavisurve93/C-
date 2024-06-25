using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, string title, string gender, int age, decimal baseSalary)
        {
            Name = name;
            Title = title;
            Gender = gender;
            Age = age;
            BaseSalary = baseSalary;
        }

        public virtual void CalculateBonus(decimal performance) { }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Base Salary: ${BaseSalary}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, string title, string gender, int age, decimal baseSalary) : base(name, title, gender, age, baseSalary) { }

        public override void CalculateBonus(decimal performance)
        {
            Bonus = BaseSalary * performance * 0.1m;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${Bonus}");
        }

        private decimal Bonus { get; set; }
    }

    class DeliveryPartner : Employee
    {
        public DeliveryPartner(string name, string title, string gender, int age, decimal baseSalary) : base(name, title, gender, age, baseSalary) { }

        public override void CalculateBonus(decimal performance)
        {
            Bonus = BaseSalary * performance * 0.2m;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${Bonus}");
        }

        private decimal Bonus { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Vaishnavi", "Software Engineer Manager", "F", 30, 100000m);
            manager.CalculateBonus(0.8m);  // Assuming a performance rating of 80%
            manager.DisplayDetails();

            Console.WriteLine("\n"); // Adding a new line for better readability

            DeliveryPartner deliveryPartner = new DeliveryPartner("Shourya", "Delivery Partner", "M", 25, 50000m);
            deliveryPartner.CalculateBonus(1.2m);  // Assuming a performance rating of 120%
            deliveryPartner.DisplayDetails();
            Console.ReadLine();
        }
    }
    
}
