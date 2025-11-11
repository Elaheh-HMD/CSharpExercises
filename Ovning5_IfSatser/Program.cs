using System;

class Program
{
    static void Main()
    {
        Console.Write("Är det fint väder? (J/N): ");
        string svar = Console.ReadLine().ToUpper();

        if (svar == "J")
        {
            Console.WriteLine("Gå på picknick!");
        }
        else if (svar == "N")
        {
            Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
        }
        else
        {
            Console.WriteLine("Jag förstår inte riktigt!");
        }
    }
}
