using System;

class Program
{
    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine($"Before swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}, b = {b}");

        string x = "Hello", y = "World";
        Console.WriteLine($"Before swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");
        Console.ReadLine();

    }

    static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }
}
