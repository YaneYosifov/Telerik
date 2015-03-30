/* Problem 3. Animal hierarchy
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful 
   constructors and methods. Dogs, frogs and cats are Animals. 
   All animals can produce sound (specified by the ISound interface). 
   Kittens and tomcats are cats. All animals are described by age, 
   name and sex. Kittens can be only female and tomcats can be only male. 
   Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age 
   of each kind of animal using a static method (you may use LINQ).
 */

namespace Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class MainProgram
    {
        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }

        static void Main()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog(14, "Rex", Sex.Male),
                new Dog(12, "Lucky", Sex.Male),
                new Dog(6, "Lisa", Sex.Female)
            };

            List<Frog> frogs = new List<Frog>
            {
                new Frog(2, "Kermit", Sex.Male),
                new Frog(1, "Mochka", Sex.Female)
            };

            List<Cats.Cat> cats = new List<Cats.Cat>
            {
                new Cats.Cat(4, "Suki", Sex.Female),
                new Cats.Cat(6, "Poncho", Sex.Male),
                new Cats.Cat(1, "Marti", Sex.Female)
            };

            List<Cats.Kitten> kittens = new List<Cats.Kitten>
            {
                new Cats.Kitten(3, "Mushi"),
                new Cats.Kitten(7, "Milka"),
                new Cats.Kitten(4, "Kostadinka")
            };

            List<Cats.Tomcat> tomcats = new List<Cats.Tomcat>
            {
                new Cats.Tomcat(2, "Puppy"),
                new Cats.Tomcat(5, "Murdjo"),
                new Cats.Tomcat(1, "Jorko")
            };

            Console.WriteLine("{0}", new string('-', 40));
            Console.WriteLine("DOGS");
            Console.WriteLine("{0}\n", new string('-', 40));
            foreach (var dog in dogs)
            {
                Console.WriteLine("Name: {0}", dog.Name);
                Console.WriteLine("Age: {0}", dog.Age);
                Console.WriteLine("Gender: {0}", dog.Sex);
                Console.WriteLine();
            }
            Console.WriteLine("Average age of the dogs: {0:F2}", AverageAge(dogs));

            Console.WriteLine("\n{0}", new string('-', 40));
            Console.WriteLine("FROGS");
            Console.WriteLine("{0}\n", new string('-', 40));
            foreach (var frog in frogs)
            {
                Console.WriteLine("Name: {0}", frog.Name);
                Console.WriteLine("Age: {0}", frog.Age);
                Console.WriteLine("Gender: {0}", frog.Sex);
                Console.WriteLine();
            }
            Console.WriteLine("Average age of the frogs: {0:F2}", AverageAge(frogs));

            Console.WriteLine("\n{0}", new string('-', 40));
            Console.WriteLine("CATS");
            Console.WriteLine("{0}\n", new string('-', 40));
            foreach (var cat in cats)
            {
                Console.WriteLine("Name: {0}", cat.Name);
                Console.WriteLine("Age: {0}", cat.Age);
                Console.WriteLine("Gender: {0}", cat.Sex);
                Console.WriteLine();
            }
            Console.WriteLine("Average age of the dogs: {0:F2}", AverageAge(cats));

            Console.WriteLine("\n{0}", new string('-', 40));
            Console.WriteLine("KITTENS");
            Console.WriteLine("{0}\n", new string('-', 40));
            foreach (var kitten in kittens)
            {
                Console.WriteLine("Name: {0}", kitten.Name);
                Console.WriteLine("Age: {0}", kitten.Age);
                Console.WriteLine("Gender: {0}", kitten.Sex);
                Console.WriteLine();
            }
            Console.WriteLine("Average age of the dogs: {0:F2}", AverageAge(kittens));

            Console.WriteLine("\n{0}", new string('-', 40));
            Console.WriteLine("TOMCATS");
            Console.WriteLine("{0}\n", new string('-', 40));
            foreach (var tomcat in tomcats)
            {
                Console.WriteLine("Name: {0}", tomcat.Name);
                Console.WriteLine("Age: {0}", tomcat.Age);
                Console.WriteLine("Gender: {0}", tomcat.Sex);
                Console.WriteLine();
            }
            Console.WriteLine("Average age of the dogs: {0:F2}", AverageAge(tomcats));
            Console.WriteLine("{0}\n", new string('-', 40));
        }
    }
}
