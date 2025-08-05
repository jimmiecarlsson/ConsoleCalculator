using ConsoleCalulator;

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

            Addera addValue = new Addera();
            double summa = addValue.getAddition();
            Console.WriteLine($"Summan är {summa} \n");

            PausForKey();
            break;
            
        case '2':
            Console.Clear();
            Console.WriteLine("Du valde Subtraktion.");
            Console.WriteLine("Skriv in två tal som du vill subtrahera.\n");

            Substrahera subValue = new Substrahera();
            double differens = subValue.getSubstraktion();
            Console.WriteLine($"Differensen är {differens} \n");

            PausForKey();
            break;

        case '3':
            Console.Clear();
            Console.WriteLine("Du valde Multiplikation.");
            Console.WriteLine("Skriv in två tal som du vill multiplicera.\n");

            Multiplicera multValue = new Multiplicera();
            double produkt = multValue.getMultiplikation();
            Console.WriteLine($"Produkten är {produkt} \n");

            PausForKey();
            break;

        case '4':
            Console.Clear();
            Console.WriteLine("Du valde Division.");
            Console.WriteLine("Skriv in två tal som du vill dividera.\n");

            Dividera divValue = new Dividera();
            double kvot = divValue.getDivision();
            Console.WriteLine($"Kvoten är {kvot} \n");

            PausForKey();
            break;

        case '5':
            Console.Clear();
            Console.WriteLine("\n\nAvslutar programmet.");
            appRullar = false;
            break;

        default:
            Console.WriteLine("\nOgiltigt val, försök igen.");
            
            PausForKey();
            break;

    }

    static void PausForKey()
    {
        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
        Console.ReadKey();
    }

}