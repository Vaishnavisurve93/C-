using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumpsearch
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] sortedArray = { 10, 20, 30, 40, 50, 70, 80, 90 };
            int target = 20;


            int index = JumpSearch(sortedArray, target);

            foreach (var arr in sortedArray) { 
            Console.WriteLine(arr);
            }
            if (index != -1)
            {
                Console.WriteLine($" \n Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found.");
            }
            Console.ReadLine();
        }

        static int JumpSearch(int[] arr, int target)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            // Jumping forward in blocks
            while (arr[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1; // Target not present in the array
            }

            // Linear search in the identified block
            for (int i = prev; i < Math.Min(step, n); i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1; // Target not present in the array
        }
    }

}
