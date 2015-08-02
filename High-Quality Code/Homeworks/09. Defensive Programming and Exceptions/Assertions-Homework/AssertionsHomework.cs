using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        IsArrayNullOrEmpty(arr);

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(arr.OrderBy(a => a).SequenceEqual(arr.Select(a => a)), "Array is not sorted");
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
    where T : IComparable<T>
    {
        IsArrayNullOrEmpty(arr);
        AreStartIndexOrEndIndexOutOfBounds<T>(arr, startIndex, endIndex);

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(minElementIndex == Array.IndexOf(arr, arr.Skip(startIndex).Take(endIndex - startIndex + 1).Min()), "Index of minimum element from startIndex to endIndex is wrong");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        IsArrayNullOrEmpty(arr);
        IsValueNull(value);

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        IsArrayNullOrEmpty(arr);
        IsValueNull(value);
        AreStartIndexOrEndIndexOutOfBounds(arr, startIndex, endIndex);

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert(arr.Contains(value), "The value found is wrong");
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        Debug.Assert(!arr.Contains(value), "Searched value exist in the array, but is not found");

        // Searched value not found
        return -1;
    }

    private static void IsArrayNullOrEmpty<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is not initialized");
        Debug.Assert(arr.Length > 0, "Array must contain at least one element");
    }

    private static void IsValueNull<T>(T value) where T : IComparable<T>
    {
        Debug.Assert(value != null, "Value is not initialized");
    }

    private static void AreStartIndexOrEndIndexOutOfBounds<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0 || startIndex <= arr.Length - 1, "startIndex is outside of bounds");
        Debug.Assert(endIndex >= 0 || endIndex <= arr.Length - 1, "endIndex is outside of bounds");
        Debug.Assert(startIndex <= endIndex, "startIndex must be less than or equal to endIndex");
    }

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
