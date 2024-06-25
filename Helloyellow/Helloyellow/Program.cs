using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloyellow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack my_stack = new Stack();

            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(3);   
            my_stack.Push(4);   
            my_stack.Push(5);
            my_stack.Push(6);

            foreach(var ele in my_stack){
                Console.WriteLine(ele);
            }


            Console.WriteLine("Popped elements:");
            
            while (my_stack.Count > 0)
            {
                var poppedElement = my_stack.Pop();
                Console.WriteLine(poppedElement);
            }

            my_stack.Peek();

            Console.WriteLine("Peek elements:");


            Console.ReadLine();
        }
    }
}
