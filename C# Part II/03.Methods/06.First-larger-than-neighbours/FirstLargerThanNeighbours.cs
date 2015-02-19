/*
 * Write a method that returns the index of the first element in array 
 * that is larger than its neighbours, or -1, if there’s no such element.
 * Use the method from the previous exercise.
 */

using System;
using LargerThanNeighbours;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers of array, separated by a space:");
        string[] tmp = Console.ReadLine().Split();
        int[] array = Array.ConvertAll(tmp, int.Parse);

        for (int i = 0; i < array.Length; i++)
        {
            NumbersCollection numbers = new NumbersCollection(array, i);
            // Не е изпълнено условието за отпечатване само на първия елемент, по-голям
            // от съседните, както и за отпечатване на -1 при липсата на такъв. Проблема
            // идва от това, че не знам как да променя типа на метода NumbersCollection
            // без това да доведе до невалиден код. Ще се радвам колегите, проверяващи
            // домашното, да ми обяснят как да си пренапиша кода, за да изпълня с един метод
            // условията и на двете задачи (пета и шеста) едновременно. :)
        }
    }
}
