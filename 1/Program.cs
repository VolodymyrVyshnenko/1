using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress program = new Adress();

            program.Index = "02000";
            Console.WriteLine(program.Index);

            program.Country = "Ukraine";
            Console.WriteLine(program.Country);

            program.City = "Kyiv";
            Console.WriteLine(program.City);

            program.Street = "Lobachevskogo";
            Console.WriteLine(program.Street);

            program.House = "23";
            Console.WriteLine(program.House);

            program.Apartment = "350";
            Console.WriteLine(program.Apartment);

            Console.ReadKey();
        }
    }
}
