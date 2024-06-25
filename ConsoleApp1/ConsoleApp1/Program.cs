using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Program
    {
      

public class CustomStack
    {
        private readonly int[] _stack;
        private int _top;
        private readonly int _capacity;

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
                Console.WriteLine("Stack overflow. Cannot push more elements.");
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
                Console.WriteLine("Stack is empty. Cannot pop elements.");
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

    }
}
