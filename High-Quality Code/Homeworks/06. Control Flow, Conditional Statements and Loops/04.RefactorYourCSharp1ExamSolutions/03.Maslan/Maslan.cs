namespace Exam
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Maslan
    {
        public static void Main()
        {
            StringBuilder inputNumber = new StringBuilder(Console.ReadLine());

            BigInteger productOfSums = 1;
            BigInteger oddDigitsSum = 0;
            int transformationsCount = 0;
            const int MAX_TRANSFORMATIONS = 10;

            while (transformationsCount < MAX_TRANSFORMATIONS)
            {
                inputNumber.Length--;
                oddDigitsSum = SumOddDigits(inputNumber);

                if (oddDigitsSum > 0)
                {
                    productOfSums *= oddDigitsSum;
                }

                if (inputNumber.Length == 0)
                {
                    transformationsCount++;
                    inputNumber.Append(productOfSums.ToString());
                    productOfSums = 1;
                    if (inputNumber.Length == 1 && int.Parse(inputNumber[0].ToString()) / 10 == 0)
                    {
                        break;
                    }
                }
            }

            if (transformationsCount < MAX_TRANSFORMATIONS)
            {
                Console.WriteLine(transformationsCount);
                Console.WriteLine(inputNumber);
            }
            else
            {
                Console.WriteLine(inputNumber);
            }
        }

        private static int SumOddDigits(StringBuilder number)
        {
            StringBuilder newNumber = new StringBuilder(number.ToString());
            if (newNumber.Length % 2 != 0)
            {
                newNumber.Length--;
            }

            int sum = 0;
            while (newNumber.Length > 1)
            {
                sum += int.Parse(newNumber[newNumber.Length - 1].ToString());
                newNumber.Length -= 2;
            }

            return sum;
        }
    }
}