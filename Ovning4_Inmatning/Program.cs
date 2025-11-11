using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv ditt namn: ");
        string namn = Console.ReadLine();
        Console.WriteLine("Välkommen, " + namn + "!");

        Console.Write("Skriv din ålder: ");
        int alder = Convert.ToInt32(Console.ReadLine());

        int dagar = alder * 365;
        Console.WriteLine("Du har levt ungefär " + dagar + " dagar.");
    }
}
