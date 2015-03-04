/*
 * Write a program that removes from a text file 
 * all words listed in given another text file.
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Security;
class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader target = new StreamReader("target.txt");
            StreamWriter replaced = new StreamWriter("target_tmp.txt");

            StreamReader sampleTxt = new StreamReader("sample.txt");
            string[] sample = sampleTxt.ReadToEnd().Split();

            string text = target.ReadToEnd();
            for (int i = 0; i < sample.Length; i++)
            {
                text = text.Replace(sample[i], "");
            }
            replaced.Write(text);

            target.Close();
            replaced.Close();

            File.Delete("target.txt");
            File.Move("target_tmp.txt", "target.txt");
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
    }
}