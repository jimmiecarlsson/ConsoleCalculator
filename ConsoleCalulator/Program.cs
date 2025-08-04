// See https://aka.ms/new-console-template for more information

bool appRullar = true;
double tal1 = 0, tal2 = 0;

while (appRullar)
{
    Console.Clear();
    Console.WriteLine("Meny:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraktion");
    Console.WriteLine("3. Multiplikation");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Avsluta");
    Console.WriteLine("Gör ditt val: ");

    ConsoleKeyInfo menyVal = Console.ReadKey();

    char menyValChar = menyVal.KeyChar;

    switch (menyValChar)
    {
        case '1':
            Console.Clear();
            Console.WriteLine("\n\nDu valde Addition.");
            Console.WriteLine($"Summan är {getAddition(tal1, tal2)}");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case '2':
            Console.Clear();
            Console.WriteLine("\n\nDu valde Subtraktion.");
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

    double getAddition(double tal1, double tal2){
        Console.WriteLine("Skriv in tal 1:");
        tal1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Skriv in tal 2:");
        tal2 = Convert.ToDouble(Console.ReadLine());
        return (tal1 + tal2);
    }


}