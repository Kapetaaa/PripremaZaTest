using System;

namespace PripremaZaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Petar", "Antic", "12345");
            Console.WriteLine(osoba.predstaviSe());
            Console.WriteLine("----------------------------------------");
            Zaposleni zaposleni = new Zaposleni("Ana", "Bogdanovic", "54321", 40);
            Console.Write("Vrednost radnog sata: ");
            zaposleni.VrednostSata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(zaposleni.predstaviSe());
            Console.WriteLine(zaposleni.izracunajPlatu());
            Console.WriteLine("----------------------------------------");
            Direktor direktor = new Direktor("Uros", "Simic", "56789", 40, 5);
            Console.WriteLine(direktor.predstaviSe());
            Console.Write("Vrednost radnog sata: ");
            direktor.VrednostSata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(direktor.izracunajPlatu());
        }
    }
}
