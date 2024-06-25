using System;

public class CustomStack
{
    private int[] _stack;
    private int _top;
    private int _capacity;

    public CustomStack(int capacity)
    {
        _capacity = capacity;
        _stack = new int[_capacity];
        _top = -1;
    }

    // Push operation to add an element to the stack
    public void Push(int item)
    {
        if (_top == _capacity - 1)
        {
            Console.WriteLine("Stack overflow.");
            return;
        }
        _stack[++_top] = item;
        Console.WriteLine($"Pushed {item} onto the stack.");
    }

    // Pop operation to remove and return the top element of the stack
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return -1; // Return -1 to indicate the stack is empty
        }
        return _stack[_top--];
    }

    // Peek operation to return the top element without removing it
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return -1; // Return -1 to indicate the stack is empty
        }
        return _stack[_top];
    }

    // IsEmpty operation to check if the stack is empty
    public bool IsEmpty()
    {
        return _top == -1;
    }

    // IsFull operation to check if the stack is full
    public bool IsFull()
    {
        return _top == _capacity - 1;
    }

    // Display operation to show the current stack elements
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Stack elements:");
        for (int i = _top; i >= 0; i--)
        {
            Console.WriteLine(_stack[i]);
        }
    }
}

// Demonstration of interactive stack operations
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the capacity of the stack: ");
        int capacity = int.Parse(Console.ReadLine());

        CustomStack stack = new CustomStack(capacity);

        while (true)
        {
            while (!stack.IsFull())
            {
                Console.Write("Enter the element to push: ");
                int element = int.Parse(Console.ReadLine());
                stack.Push(element);

                if (stack.IsFull())
                {
                    Console.WriteLine("Stack is full.");
                    break;
                }
            }

            Console.WriteLine("Do you want to start popping elements? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                while (!stack.IsEmpty())
                {
                    int poppedElement = stack.Pop();
                    if (poppedElement == -1)
                    {
                        Console.WriteLine($"Popped element: {poppedElement}");
                    }
                }
                Console.WriteLine("All elements have been popped from the stack.");
            }

            Console.WriteLine("Do you want to pop elements or exit? (push/exit)");
            response = Console.ReadLine().ToLower();
            if (response == "exit")
            {
                break;
            }
        }
    }
}
