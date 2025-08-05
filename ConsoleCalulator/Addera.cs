using System;

namespace ConsoleCalulator
{
    public class Addera
    {

        public double GetAddition()
        {
            double tal1 = 0, tal2 = 0;

            Console.WriteLine("Skriv in tal 1 + <RETURN>:");
            // Mata in och validera det första numret
            while (!double.TryParse(Console.ReadLine(), out tal1))
            {
                Console.WriteLine("Tänka på att använda komma-tecken för decimaler, försök igen:");
            }

            Console.WriteLine("Skriv in tal 2 + <RETURN>:");
            // Mata in och validera det andra numret
            while (!double.TryParse(Console.ReadLine(), out tal2))
            {
                Console.WriteLine("Tänka på att använda komma-tecken för decimaler, försök igen:");
            }

            // Summera, avrunda och returnera summan
            double calcSumma = (tal1 + tal2);
            calcSumma = Math.Round(calcSumma, 2);

            return (calcSumma);
        }


    }
}
