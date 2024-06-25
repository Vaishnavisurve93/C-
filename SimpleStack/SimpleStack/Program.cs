using System;

// Define the IStack<T> interface
public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Peek();
    bool IsEmpty { get; }
}

// Implement the SimpleStack<T> class that adheres to the IStack<T> interface using an array
public class SimplyStack<T> : IStack<T>
{
    private T[] _elements;
    private int _count;

    public SimplyStack()
    {
        _elements = new T[4]; // Initial capacity
        _count = 0;
    }

    // Method to push an element onto the stack
    public void Push(T item)
    {
        if (_count == _elements.Length)
        {
            // Resize the array if it's full
            Array.Resize(ref _elements, _elements.Length * 2);
        }
        _elements[_count++] = item;
    }

    // Method to pop an element from the stack
    // Throws InvalidOperationException if the stack is empty
    public T Pop()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _elements[--_count];
        _elements[_count] = default(T); // Clear the reference
        return item;
    }

    // Method to peek at the top element of the stack without removing it
    // Throws InvalidOperationException if the stack is empty
    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _elements[_count - 1];
    }

    // Property to check if the stack is empty
    public bool IsEmpty
    {
        get { return _count == 0; }
    }
}

public class Program
{
    public static void Main()
    {
        IStack<object> stack = new SimplyStack<object>();

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter an element to push onto the stack: ");
                    string input = Console.ReadLine();
                    PushElement(stack, input);
                    break;

                case "2":
                    try
                    {
                        object poppedElement = stack.Pop();
                        Console.WriteLine($"Popped element: {poppedElement}");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "3":
                    try
                    {
                        object peekedElement = stack.Peek();
                        Console.WriteLine($"Top element: {peekedElement}");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    public static void PushElement(IStack<object> stack, string input)
    {
        // Convert input to appropriate type and push onto the stack
        if (int.TryParse(input, out int intResult))
        {
            stack.Push(intResult);
        }
        else if (double.TryParse(input, out double doubleResult))
        {
            stack.Push(doubleResult);
        }
        else if (bool.TryParse(input, out bool boolResult))
        {
            stack.Push(boolResult);
        }
        else if (DateTime.TryParse(input, out DateTime dateResult))
        {
            stack.Push(dateResult);
        }
        else
        {
            stack.Push(input);
        }

        Console.WriteLine($"Element '{input}' pushed onto the stack.");
    }
}
