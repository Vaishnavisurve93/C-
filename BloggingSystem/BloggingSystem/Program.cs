using System;
using System.Data.Entity;
using BloggingSystem.Data;

namespace BloggingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the initializer here to either one you want to use
            Database.SetInitializer(new BloggingContextInitializer());

            using (var context = new BloggingContext())
            {
                context.Database.Initialize(force: true);
            }

            Console.WriteLine("Database has been initialized and seeded.");
            Console.ReadLine();
        }
    }
}
