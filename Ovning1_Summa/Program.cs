using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in första talet: ");
        int tal1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Skriv in andra talet: ");
        int tal2 = Convert.ToInt32(Console.ReadLine());

        int summa = tal1 + tal2;
        Console.WriteLine("Summan av talen är: " + summa);
    }
}
