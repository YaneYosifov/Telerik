using System;
class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int vertLine = 1;
        int space = 1;

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

        for (int i = 0; i < n; i++)
        {
            Console.Write(":");
        }
        Console.WriteLine();
        Console.Write(":");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("::");

/*
        :    :|:   
        :    :||:  
        :    :|||: 
*/

        for (int i = 0; i < n - 3; i++)
        {
            Console.Write(":");
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(" ");
            }
            Console.Write(":");
            for (int j = vertLine; j > 0; j--)
            {
                Console.Write("|");
            }
            vertLine++;
            Console.WriteLine(":");
        }

/*
        ::::::||||:
*/

        for (int i = 0; i < n; i++)
        {
            Console.Write(":");
        }
        for (int i = 0; i < vertLine; i++)
        {
            Console.Write("|");
        }
        Console.WriteLine(":");

/*
         :----:|||:
          :----:||:
           :----:|:
*/

        for (int i = 0; i < n - 3; i++)
        {
            for (int j = space; j > 0; j--)
            {
                Console.Write(" ");
            }
            space++;
            Console.Write(":");
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");
            }
            Console.Write(":");
            vertLine--;
            for (int j = vertLine; j > 0; j--)
            {
                Console.Write("|");
            }
            Console.Write(":");
            Console.WriteLine();
        }

/*
            :----::
            ::::::
*/

        for (int j = space; j > 0; j--)
        {
            Console.Write(" ");
        }
        space++;
        Console.Write(":");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("::");
        for (int j = space; j > 0; j--)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(":");
        }
        Console.WriteLine();
    }
}