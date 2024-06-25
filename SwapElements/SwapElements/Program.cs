using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BitwiseOperations
{
    public class NumberSwapper
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }

        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine($"Before swapping: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After swapping: x = {x}, y = {y}");
            Console.ReadLine();
        }
    }
}
