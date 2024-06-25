using System;
using System.Collections.Generic;

public class CustomStack
{
    private List<int> _stack;

    public CustomStack()
    {
        _stack = new List<int>();
    }

    // Push operation to add an element to the stack
    public void Push(int item)
    {
        _stack.Add(item);
        Console.WriteLine($"Pushed {item} onto the stack.");
    }

    // Pop operation to remove and return the top element of the stack
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop elements.");
            return -1; // Return -1 to indicate the stack is empty
        }

        int lastIndex = _stack.Count - 1;
        int poppedElement = _stack[lastIndex];
        _stack.RemoveAt(lastIndex);
        Console.WriteLine($"Popped element: {poppedElement}");
        return poppedElement;
    }

    // Peek operation to return the top element without removing it
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return -1; // Return -1 to indicate the stack is empty
        }

        int lastIndex = _stack.Count - 1;
        int topElement = _stack[lastIndex];
        Console.WriteLine($"Top element: {topElement}");
        return topElement;
    }

    // IsEmpty operation to check if the stack is empty
    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CustomStack stack = new CustomStack();

        // Initial stack elements
        int[] initialElements = { 10, 2, 3, 4, 5, 8 };
        foreach (int element in initialElements)
        {
            stack.Push(element);
        }

        // Perform pop and peek operations
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Peek();
        Console.ReadLine();
    }
}
