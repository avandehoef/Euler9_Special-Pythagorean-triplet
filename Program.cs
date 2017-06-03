using System;

namespace Euler9
{
    class Program
    {
        /* Pythagorean triplet is a set of three natural numbers, a < b < c for which, a2 + b2 = c2
           For example, 32 + 42 = 9 + 16 = 25 = 52.
           There exists exactly one Pythagorean triplet for which a + b + c = 1000.
           Find the product abc.         
        */
        static void Main(string[] args)
        {
            int c = 500; // het totaal moet zijn 1000 en a + b + c = 1000 , terwijl a2 + b2 = c2. ik vermoedde dat daarom c nooit groter kan zijn dan max 1/2 van a + b + c
            int i = 1; 
            int b = c - i; 
            int a = 2;

            double startTime = Environment.TickCount;
            for (c = c; a < b; a = a+1)
            {
                if (Math.Pow(b, 2) + Math.Pow(a, 2) != Math.Pow(c, 2))
                {
                    if (b <3) // als b kleiner is dan 3 dan is a kleiner dan 2 (dus 1) en dat kan alleen als a =1 en b =499 en c= 500 en dat is niet het correcte antwoord
                    {
                        c = c - 1;
                        i = 1;
                        b = c - i;
                        a = 2;
                    }
                    else if (a == b - 1) // a moet kleiner zijn dan b
                    {
                        i = 1;
                        b = b - i;
                        a = 0;
                    }
                }
                else if (a + b + c == 1000)
                {
                    double endTime = Environment.TickCount; // antwoord in ong 1,6 seconden
                    Console.WriteLine("A = " + a + " B = " + b + " C = " + c);
                    Console.WriteLine("The product of abc is: " + (a * b * c));
                    Console.WriteLine("time to compute in ms: " + (endTime - startTime));
                    Console.ReadKey();                    
                }
            }
        }
    }
}