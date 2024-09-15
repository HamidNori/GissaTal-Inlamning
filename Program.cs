using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();
        int slumptal = random.Next(1, 101);
        int antalForsok = 0;
        int gissning = 0;

        while (gissning != slumptal)
        {
            Console.Write("Gissa ett tal mellan 1 och 100: ");
            gissning = int.Parse(Console.ReadLine()); 
            antalForsok++; 

           
            if (gissning < slumptal)
            {
                Console.WriteLine("För lågt");
            }
            else if (gissning > slumptal)
            {
                Console.WriteLine("För högt");
            }
            else
            {
                Console.WriteLine($"Rätt, du gissade rätt på {antalForsok} försök.");
            }
        }
    }
}
