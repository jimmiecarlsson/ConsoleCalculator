// See https://aka.ms/new-console-template for more information

bool appRullar = true;


while (appRullar)
{
    Console.Clear();
    Console.WriteLine("Välkommen till min konsol-kalkylator!\n");
    Console.WriteLine("Meny:\n");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraktion");
    Console.WriteLine("3. Multiplikation");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Avsluta\n");
    Console.WriteLine("Gör ditt val:");

    ConsoleKeyInfo menyVal = Console.ReadKey();

    char menyValChar = menyVal.KeyChar;

    switch (menyValChar)
    {
        case '1':
            Console.Clear();
            Console.WriteLine("Du valde Addition.");
            Console.WriteLine("Skriv in två tal som du vill addera.\n");

            double summa = getAddition();
            Console.WriteLine($"Summan är {summa}");

            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;

        case '2':
            Console.Clear();
            Console.WriteLine("\n\nDu valde Subtraktion.");
            Console.WriteLine("Skriv in två tal som du vill subtrahera.\n");

            double differens = getSubstraktion();
            Console.WriteLine($"Differensen är {differens}");

            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;

        case '3':
            Console.Clear();
            Console.WriteLine("\nDu valde Multiplikation.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case '4':
            Console.Clear();
            Console.WriteLine("\n\nDu valde Division.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case '5':
            Console.Clear();
            Console.WriteLine("\n\nAvslutar programmet.");
            appRullar = false;
            break;
        default:
            Console.WriteLine("Ogiltigt val, försök igen.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;

    }


    // Metod för att hämta och addera två tal

    double getAddition()
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

    double getSubstraktion()
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
        double calcSumma = (tal1 - tal2);
        calcSumma = Math.Round(calcSumma, 2);

        return (calcSumma);
    }


}