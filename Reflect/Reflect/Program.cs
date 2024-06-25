using System;
using System.Reflection;

public class MyClass
{
    public void Method1()
    {
        Console.WriteLine("Method1 called without parameters.");
    }

    public void Method2(int param)
    {
        Console.WriteLine($"Method2 called with parameter: {param}");
    }

    // Add more methods as needed
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        Console.Write("Enter method name to invoke: ");
        string methodName = Console.ReadLine();

        Console.Write("Enter parameter (if any): ");
        string paramInput = Console.ReadLine();

        try
        {
            // Get the method info using reflection
            MethodInfo methodInfo = typeof(MyClass).GetMethod(methodName);

            // Check if methodInfo is null (method not found)
            if (methodInfo == null)
            {
                Console.WriteLine($"Method '{methodName}' not found.");
            }
            else
            {
                // If there are parameters, convert and pass them to Invoke
                object[] parameters = string.IsNullOrWhiteSpace(paramInput) ?
                                      new object[] { } :
                                      new object[] { Convert.ChangeType(paramInput, methodInfo.GetParameters()[0].ParameterType) };

                // Invoke the method
                methodInfo.Invoke(myObject, parameters);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid parameter format.");
        }
        catch (TargetInvocationException ex)
        {
            // Handle any exceptions thrown by the invoked method
            Console.WriteLine($"Exception occurred: {ex.InnerException.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}