using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };
        Console.WriteLine("Original array: " + string.Join(", ", array));

        SelectionSort(array);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));
        Console.ReadLine();
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the unsorted portion of the array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
