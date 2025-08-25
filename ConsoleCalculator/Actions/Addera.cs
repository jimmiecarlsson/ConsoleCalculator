using System;

namespace ConsoleCalulator.Actions
{
    public class Addera
    {
        public double Add(double a, double b)
        {
            return Math.Round(a + b, 2);
        }
        public double GetAddition()
        {
            //Bort refaktorerade kod för att kunna göra enhetstester med xUnit
            //Skapade metoder för att läsa in double

            //Console.WriteLine("Skriv in tal 1 + <RETURN>:");
            //// Mata in och validera det första numret
            //while (!double.TryParse(Console.ReadLine(), out tal1))
            //{
            //    Console.WriteLine("Tänka på att använda komma-tecken för decimaler, försök igen:");
            //}

            //Console.WriteLine("Skriv in tal 2 + <RETURN>:");
            //// Mata in och validera det andra numret
            //while (!double.TryParse(Console.ReadLine(), out tal2))
            //{
            //    Console.WriteLine("Tänka på att använda komma-tecken för decimaler, försök igen:");
            //}

            //// Summera, avrunda och returnera summan
            //double calcSumma = tal1 + tal2;
            //calcSumma = Math.Round(calcSumma, 2);

            double tal1 = ReadDouble("Skriv in tal 1 + <RETURN>:");
            double tal2 = ReadDouble("Skriv in tal 2 + <RETURN>:");

            return Add(tal1, tal2);
        }

        private static double ReadDouble(string prompt)
        {
            Console.WriteLine(prompt);

            double value;

            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Tänka på att använda komma-tecken för decimaler, försök igen:");
            }
            return value;
        }


    }
}
