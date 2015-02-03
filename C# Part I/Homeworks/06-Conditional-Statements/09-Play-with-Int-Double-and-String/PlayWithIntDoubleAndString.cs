using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        // * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        //   - If the variable is int or double, the program increases it by one.
        //   - If the variable is a string, the program appends * at the end.
        // * Print the result at the console. Use switch statement.

        Console.WriteLine("Please choose a type:"
                           + "\n1 --> int"
                           + "\n2 --> double"
                           + "\n3 --> string");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int intNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intNum + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(doubleNum + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
        }
    }
}