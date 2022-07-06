using System;

namespace Animals
{
    public class Program
    {

        static void Main()
        {

            Dogs dog = new Dogs("Dobby", "Black", 5, "Pitbull");

            Console.WriteLine($"{dog.name},{dog.color},{dog.age},{dog.type}");

            Cats cat = new Cats("Knopka", "Black", 4, "Bombay");

            Console.WriteLine($"{cat.name},{cat.color},{cat.age},{cat.type}");


        }

    }
}