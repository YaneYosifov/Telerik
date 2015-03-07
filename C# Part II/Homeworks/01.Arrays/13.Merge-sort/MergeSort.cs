/*
 * Write a program that sorts an array of integers using the Merge sort algorithm.
 */

using System;
class MergeSort
{
    void mergeArray(int[] arr, int start, int mid, int end)
    {
        int[] temp = new int[end - start + 1];

        int i = start, j = mid + 1, k = 0;
        while (i <= mid && j <= end)
        {
            if (arr[i] < arr[j])
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            else
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
        }
        while (i <= mid)
        {
            temp[k] = arr[i];
            k++;
            i++;
        }
        while (j <= end)
        {
            temp[k] = arr[j];
            k++;
            j++;
        }

        k = 0;
        i = start;
        while (k < temp.Length && i <= end)
        {
            arr[i] = temp[k];
            i++;
            k++;
        }
    }
    void mergesort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (end + start) / 2;
            mergesort(arr, start, mid);
            mergesort(arr, mid + 1, end);
            mergeArray(arr, start, mid, end);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] arr = Array.ConvertAll(arrStr.Split(','), int.Parse);

        MergeSort merge = new MergeSort();

        merge.mergesort(arr, 0, arr.Length - 1);

        foreach (int a in arr)
        {
            Console.Write(a + " ");
        }

        Console.WriteLine();
    }
}