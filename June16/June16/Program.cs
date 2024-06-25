using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the assembly.");
            return;
        }

        string assemblyPath = args[0];

        try
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Type: {type.FullName}");
                Console.WriteLine($"Base Type: {type.BaseType?.FullName}");

                var interfaces = type.GetInterfaces();
                if (interfaces.Length > 0)
                {
                    Console.WriteLine("Implements Interfaces:");
                    foreach (var iface in interfaces)
                    {
                        Console.WriteLine($"- {iface.FullName}");
                    }
                }
                else
                {
                    Console.WriteLine("Implements Interfaces: None");
                }

                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.ReadLine();
    }
}