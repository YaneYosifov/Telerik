namespace Exam
{
    using System;

    public class Cube3D
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int verticalLineCount = 1;
            int spaceCount = 1;

            char colon = ':';
            char space = ' ';
            char verticalLine = '|';
            char dash = '-';

            /*
                    ::::::     
                    :    ::    
                    :    :|:   
                    :    :||:  
                    :    :|||: 
                    ::::::||||:
                     :----:|||:
                      :----:||:
                       :----:|:
                        :----::
                         ::::::
            */

            /*
                    ::::::     
                    :    ::    
            */
            Console.Write(new string(colon, inputNumber));
            Console.Write("\n" + colon);
            Console.Write(new string(space, inputNumber - 2));
            Console.Write(new string(colon, 2) + "\n");

            /*
                    :    :|:   
                    :    :||:  
                    :    :|||: 
            */
            for (int i = 0; i < inputNumber - 3; i++)
            {
                Console.Write(colon);
                Console.Write(new string(space, inputNumber - 2));
                Console.Write(colon);
                Console.Write(new string(verticalLine, verticalLineCount));
                verticalLineCount++;
                Console.WriteLine(colon);
            }

            /*
                    ::::::||||:
            */
            Console.Write(new string(colon, inputNumber));
            Console.Write(new string(verticalLine, verticalLineCount));
            Console.WriteLine(colon);

            /*
                     :----:|||:
                      :----:||:
                       :----:|:
            */
            for (int i = 0; i < inputNumber - 3; i++)
            {
                Console.Write(new string(space, spaceCount));
                spaceCount++;
                Console.Write(colon);
                Console.Write(new string(dash, inputNumber - 2));
                Console.Write(colon);
                verticalLineCount--;
                Console.Write(new string(verticalLine, verticalLineCount));
                Console.Write(colon + "\n");
            }

            /*
                        :----::
                        ::::::
            */
            Console.Write(new string(space, spaceCount));
            spaceCount++;
            Console.Write(colon);
            Console.Write(new string(dash, inputNumber - 2));
            Console.Write(new string(colon, 2) + "\n");
            Console.Write(new string(space, spaceCount));
            Console.Write(new string(colon, inputNumber) + "\n");
        }
    }
}