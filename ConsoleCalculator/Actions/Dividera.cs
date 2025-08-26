using System;

namespace ConsoleCalulator.Actions
{
    public class Dividera
    {
        public double Divi(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();

            return Math.Round(a / b, 2);
        }


        public double GetDivision()
        {

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

            //while (tal1 == 0 || tal2 == 0 )
            //{
            //    Console.WriteLine("Division med noll är inte tillåten. Försök igen.");
            //    return 0;
            //}

            //double calcKvot = tal1 / tal2;
            //calcKvot = Math.Round(calcKvot, 2);

            //return calcKvot;

            double tal1 = ReadDouble("Skriv in tal 1 + <RETURN>:");
            double tal2 = ReadDouble("Skriv in tal 2 + <RETURN>:");

            if (tal2 == 0)
                throw new DivideByZeroException("Division med noll är inte tillåten.");

            return Divi(tal1, tal2);
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
