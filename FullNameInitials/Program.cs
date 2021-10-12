using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestada enda eesnimi:");
            string first = Console.ReadLine();
            Console.WriteLine("palun sisestada enda perekonnanimi;");
            string last = Console.ReadLine();

            Console.WriteLine($"Tere, {first[0]}. {last[0]}.!");
        }
    }
}
