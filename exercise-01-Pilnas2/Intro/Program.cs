using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_intro
{
    class Adresa
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Josef Novák \n Jindrišská 16\n 111 50, Praha 1\n");
        }
    }
    class Abeceda
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (char letter in alphabet)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
        }
    }
    class RodneCislo
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Zadejte rodné číslo:");
                string? idNumber = Console.ReadLine();

                int genderNumber = int.Parse(idNumber.Substring(2, 2));

                if (genderNumber % 100 > 50)
                {
                    Console.WriteLine("Žena");
                }
                else
                {
                    Console.WriteLine("Muž");
                }

            }
        }
    }
    class HadaniCisla
    {
        static void Main(String[] args)
        {
            Random rnd = new Random();
            int randomNuber = rnd.Next(1, 101);

            int hadaneCislo = 0;

            while (randomNuber != hadaneCislo)
            {
                Console.WriteLine("Zadejte hádané číslo:");
                string? hadej = Console.ReadLine();
                int.TryParse(hadej, out hadaneCislo);

                if (hadaneCislo > randomNuber)
                {
                    Console.WriteLine("Hádané číslo je menší");
                }
                else if (hadaneCislo < randomNuber)
                {
                    Console.WriteLine("Hádané číslo je větší");
                }
                if (randomNuber == hadaneCislo)
                {
                    Console.WriteLine("Uhádl si číslo");
                }
            }
        }
    }
}