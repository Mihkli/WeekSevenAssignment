﻿using System;

namespace FirstNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta enda eesnimi:");
            string firstname = Console.ReadLine();

            for (int i = firstname.Length - 1; i >= 0; i--)
            {
                if (firstname.Length > 5)
                {
                    Console.Write(firstname[i]);
                }
                else
                {
                    Console.WriteLine(firstname);
                    break;
                }
            }               
        }
    }
}
