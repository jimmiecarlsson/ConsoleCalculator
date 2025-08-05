using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalulator
{
    public class Dividera
    {

        public double getDivision()
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

            while (tal1 == 0 || tal2 == 0 )
            {
                Console.WriteLine("Division med noll är inte tillåten. Försök igen.");
                return 0;
            }

            double calcKvot = (tal1 / tal2);
            calcKvot = Math.Round(calcKvot, 2);

            return (calcKvot);
        }

    }
}
