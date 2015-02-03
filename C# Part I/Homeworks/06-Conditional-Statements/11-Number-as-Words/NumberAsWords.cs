using System;
class NumberAsWords
{
    static void Main()
    {
        // * Write a program that converts a number in the range [0…999] 
        //   to words, corresponding to the English pronunciation.

        while (true)
        {
            Console.Write("number [0...999]: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 999 && number >= 100)
            {
                switch (number / 100)
                {
                    case 1: Console.Write("One hundred"); break;
                    case 2: Console.Write("Two hundred"); break;
                    case 3: Console.Write("Three hundred"); break;
                    case 4: Console.Write("Four hundred"); break;
                    case 5: Console.Write("Five hundred"); break;
                    case 6: Console.Write("Six hundred"); break;
                    case 7: Console.Write("Seven hundred"); break;
                    case 8: Console.Write("Eight hundred"); break;
                    case 9: Console.Write("Nine hundred"); break;
                }

                if (number % 100 == 0)
                {
                }
                else
                {
                    if (number / 10 % 10 == 0)
                    {
                        switch (number % 10)
                        {
                            case 1: Console.Write(" and one"); break;
                            case 2: Console.Write(" and two"); break;
                            case 3: Console.Write(" and three"); break;
                            case 4: Console.Write(" and four"); break;
                            case 5: Console.Write(" and five"); break;
                            case 6: Console.Write(" and six"); break;
                            case 7: Console.Write(" and seven"); break;
                            case 8: Console.Write(" and eight"); break;
                            case 9: Console.Write(" and nine"); break;
                        }
                    }
                    else if (number % 100 >= 10 && number % 100 <= 19)
                    {
                        switch (number % 100)
                        {
                            case 10: Console.Write(" and ten"); break;
                            case 11: Console.Write(" and eleven"); break;
                            case 12: Console.Write(" and twelve"); break;
                            case 13: Console.Write(" and thirteen"); break;
                            case 14: Console.Write(" and fourteen"); break;
                            case 15: Console.Write(" and fifteen"); break;
                            case 16: Console.Write(" and sixteen"); break;
                            case 17: Console.Write(" and seventeen"); break;
                            case 18: Console.Write(" and eighteen"); break;
                            case 19: Console.Write(" and nineteen"); break;
                        }
                    }
                    else if (number % 100 >= 20 && number % 100 <= 99)
                    {
                        switch (number / 10 % 10)
                        {
                            case 2: Console.Write(" and twenty"); break;
                            case 3: Console.Write(" and thirty"); break;
                            case 4: Console.Write(" and fourty"); break;
                            case 5: Console.Write(" and fifty"); break;
                            case 6: Console.Write(" and sixty"); break;
                            case 7: Console.Write(" and seventy"); break;
                            case 8: Console.Write(" and eighty"); break;
                            case 9: Console.Write(" and ninety"); break;
                        }

                        switch (number % 10)
                        {
                            case 1: Console.Write(" one"); break;
                            case 2: Console.Write(" two"); break;
                            case 3: Console.Write(" three"); break;
                            case 4: Console.Write(" four"); break;
                            case 5: Console.Write(" five"); break;
                            case 6: Console.Write(" six"); break;
                            case 7: Console.Write(" seven"); break;
                            case 8: Console.Write(" eight"); break;
                            case 9: Console.Write(" nine"); break;
                        }
                    }
                }
            }
            else if (number <= 99 && number >= 20)
            {
                switch (number / 10)
                {
                    case 2: Console.Write("Twenty"); break;
                    case 3: Console.Write("Thirty"); break;
                    case 4: Console.Write("Fourty"); break;
                    case 5: Console.Write("Fifty"); break;
                    case 6: Console.Write("Sixty"); break;
                    case 7: Console.Write("Seventy"); break;
                    case 8: Console.Write("Eighty"); break;
                    case 9: Console.Write("Ninety"); break;
                }

                if (number % 10 == 0)
                {
                }
                else
                {
                    switch (number % 10)
                    {
                        case 1: Console.Write(" one"); break;
                        case 2: Console.Write(" two"); break;
                        case 3: Console.Write(" three"); break;
                        case 4: Console.Write(" four"); break;
                        case 5: Console.Write(" five"); break;
                        case 6: Console.Write(" six"); break;
                        case 7: Console.Write(" seven"); break;
                        case 8: Console.Write(" eight"); break;
                        case 9: Console.Write(" nine"); break;
                    }
                }
            }
            else if (number <= 19 && number >= 0)
            {
                switch (number)
                {
                    case 0: Console.Write("Zero"); break;
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("Eleven"); break;
                    case 12: Console.Write("Twelve"); break;
                    case 13: Console.Write("Thirteen"); break;
                    case 14: Console.Write("Fourteen"); break;
                    case 15: Console.Write("Fifteen"); break;
                    case 16: Console.Write("Sixteen"); break;
                    case 17: Console.Write("Seventeen"); break;
                    case 18: Console.Write("Eighteen"); break;
                    case 19: Console.Write("Nineteen"); break;
                }
            }

            Console.WriteLine();
        }
    }
}