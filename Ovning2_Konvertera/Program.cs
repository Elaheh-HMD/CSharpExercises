using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv ett decimaltal: ");
        double decimaltal = Convert.ToDouble(Console.ReadLine());

        int heltal = Convert.ToInt32(decimaltal);
        Console.WriteLine("Närmaste heltal är: " + heltal);
    }
}
