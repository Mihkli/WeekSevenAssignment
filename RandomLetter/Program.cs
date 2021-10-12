using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta enda eesnimi:");
            string name = Console.ReadLine();
           
            Console.WriteLine($"Tere, {name.ToUpper()[0]}");



        }
    }
}
