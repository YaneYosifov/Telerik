/*
 * Write a program that enters file name along with its full file path (e.g. 
 * C:\WINDOWS\win.ini), reads its contents and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions 
 * and print user-friendly error messages.
 */

using System;
using System.IO;
using System.Security;
class ReadFileContents
{
    static string CatchExceptions(string file)
    {
        try
        {
            file = File.ReadAllText(file);
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
        return file;
    }
    static void Main()
    {
        Console.Write("Enter file name with full path: ");
        string file = Console.ReadLine();
        Console.WriteLine(CatchExceptions(file));
    }
}