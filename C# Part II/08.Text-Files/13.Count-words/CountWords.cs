/*
 * Write a program that reads a list of words 
 * from the file words.txt and finds how many times 
 * each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words 
 * should be sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Security;
using System.Linq;
class CountWords
{
    static void Result(Dictionary<string, int> dict)
    {
        var sortedDict = from entry in dict orderby entry.Value descending select entry;
        StreamWriter writerResult;
        writerResult = CatchExceptionsWriter("result.txt");
        foreach (var entry in sortedDict)
        {
            writerResult.WriteLine("[{0} {1}]", entry.Key, entry.Value);
        }
        writerResult.Close();
    }

    static StreamWriter CatchExceptionsWriter(string file)
    {
        StreamWriter content;
        try
        {
            content = new StreamWriter(file);
        }
        catch (ArgumentNullException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (ArgumentException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (PathTooLongException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (UnauthorizedAccessException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (NotSupportedException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (SecurityException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        return content;
    }
    static StreamReader CatchExceptionsReader(string file)
    {
        StreamReader content;
        try
        {
            content = new StreamReader(file);
        }
        catch (ArgumentNullException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (ArgumentException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (PathTooLongException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (DirectoryNotFoundException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (UnauthorizedAccessException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (NotSupportedException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (SecurityException e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Error: " + e.Message);
            throw;
        }
        return content;
    }
    static void Main()
    {
        StreamReader wordsFile;
        wordsFile = CatchExceptionsReader("words.txt");
        StreamReader testFile;
        testFile = CatchExceptionsReader("test.txt");
        string[] words = wordsFile.ReadToEnd().Split();

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            dictionary.Add(words[i], 0);
        }

        string line = string.Empty;
        string[] lineArr;
        while (line != null)
        {
            lineArr = line.Split(new string[] { ".", ",", "!", "?", ":", ";", " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lineArr.Length; i++)
            {
                if (dictionary.ContainsKey(lineArr[i]))
                {
                    dictionary[lineArr[i]]++;
                }
            }
            line = testFile.ReadLine();
        }

        wordsFile.Close();
        testFile.Close();

        Result(dictionary);
    }
}