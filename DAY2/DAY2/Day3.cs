public static class ArrayUtils
{
    public static T[] SliceArray<T>(T[] originalArray, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= originalArray.Length || endIndex > originalArray.Length || endIndex <= startIndex)
        {
            throw new ArgumentOutOfRangeException("startIndex or endIndex is invalid");
        }

        int sliceLength = endIndex - startIndex;
        T[] slicedArray = new T[sliceLength];

        // Option 1: Manual Looping (works for all C# versions)
        for (int i = 0; i < sliceLength; i++)
        {
            slicedArray[i] = originalArray[startIndex + i];
        }

        // Option 2: Using Array.Copy (C# pre-8.0)
        // Array.Copy(originalArray, startIndex, slicedArray, 0, sliceLength);

        // Option 3: Using Index and Range (C# 8.0 and later)
        Array.Copy(originalArray, startIndex, slicedArray, 0, sliceLength);  // Option 2 for demonstration

        return slicedArray;
    }

    public static T[] InsertElement<T>(T[] array, T element, int index)
    {
        if (index < 0 || index > array.Length)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        // Create a new array with one extra element
        T[] newArray = new T[array.Length + 1];

        // Copy elements before the insertion point
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        // Insert the new element
        newArray[index] = element;

        // Copy elements after the insertion point
        for (int i = index + 1; i < newArray.Length; i++)
        {
            newArray[i] = array[i - 1];
        }

        return newArray;
    }

    public static T[] UpdateElement<T>(T[] array, T element, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        // Create a copy of the original array to avoid modifying it directly
        T[] newArray = array.ToArray();  // Alternatively: T[] newArray = new T[array.Length]; Array.Copy(array, newArray, array.Length);

        // Update the element at the specified index
        newArray[index] = element;

        return newArray;
    }

    public static T[] ReverseArray<T>(T[] array)
    {
        // Create a copy of the original array to avoid modifying it directly
        T[] newArray = array.ToArray();  // Alternatively: T[] newArray = new T[array.Length]; Array.Copy(array, newArray, array.Length);

        // Swap elements from both ends until the middle
        for (int i = 0; i < newArray.Length / 2; i++)
        {
            T temp = newArray[i];
            newArray[i] = newArray[newArray.Length - 1 - i];
            newArray[newArray.Length - 1 - i] = temp;
        }

        return newArray;
    }

    public static int[] GetIntArrayFromUser(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException("Array size must be positive");
        }

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write(< span class="math-inline">"Enter element \{i \+ 1\}\: "\);
string input \= Console\.ReadLine\(\);
// Validate user input
if \(\!int\.TryParse\(input, out int number\)\)
\{
Console\.WriteLine\("Invalid input\. Please enter an integer\."\);
i\-\-; // Decrement i to repeat input for the same index
\}
else
\{
    array\[i\] \= number;
    Console\.WriteLine\(</ span > "Element {number} entered successfully at index {i}");
}
    }

    return array;
  }
}

// Example Usage
static void Main(string[] args)
{
    // Get array from user
    int[] numbers = ArrayUtils.GetIntArrayFromUser(5);

  // Slice array
