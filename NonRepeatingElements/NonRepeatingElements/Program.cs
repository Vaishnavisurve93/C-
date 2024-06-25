using System;
using System.Linq;

namespace BitwiseOperations
{
    public class NonRepeatingElementsFinder
    {
        public static void FindTwoNonRepeatingElements(int[] arr)
        {
            int xor = 0;
            foreach (int num in arr)
            {
                xor ^= num;
            }

            // Get the rightmost set bit in xor (which is different for the two unique numbers)
            int setBit = xor & ~(xor - 1);

            int num1 = 0, num2 = 0;
            foreach (int num in arr)
            {
                if ((num & setBit) != 0)
                {
                    num1 ^= num;
                }
                else
                {
                    num2 ^= num;
                }
            }

            Console.WriteLine($"The two non-repeating elements are: {num1} and {num2}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            FindTwoNonRepeatingElements(arr);
            Console.ReadLine();
        }
    }
}
