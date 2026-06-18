using System.Diagnostics;

namespace TR
{
    internal class Program
    {
        static double GetValidNumber(string text)
        {
            Console.Write(text);
            double zahl;
            while (!double.TryParse(Console.ReadLine(), out zahl))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ungültige Eingabe! Bitte versuche es mit einer Zahl erneut: ");
                Console.ResetColor();
            }
            return zahl;
        }

        static char GetValidOperator(string text)
        {
            Console.Write(text);
            char eingabe;
            while (!char.TryParse(Console.ReadLine(), out eingabe) || (eingabe != '+' && eingabe != '-' && eingabe != '*' && eingabe != '/'))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ungültige Eingabe! Bitte gib einen gültigen Operator ein (+, -, *, /): ");
                Console.ResetColor();
            }
            return eingabe;
        }




        static void Main(string[] args)
        {
            bool debug_tr = true;
            double eingabezahl1;
            double eingabezahl2;
            double ergebnis = 0;
            char operatorEingabe;

            Console.WriteLine("--- Calculator v0.1 ---");



                     
            


            while (true)
            {
                //----- Zahl 1 abfragen -----
                eingabezahl1 = GetValidNumber("Gib die erste Zahl ein: ");
                //----- Operator abfragen -----
                operatorEingabe = GetValidOperator("Gib einen Operator ein (+, -, *, /): ");
                //----- Zahl 2 abfragen -----
                eingabezahl2 = GetValidNumber("Gib die zweite Zahl ein: ");


                //----- Rechnen -----
                switch (operatorEingabe)
                {
                    case '+':
                        ergebnis = eingabezahl1 + eingabezahl2;
                        break;
                    case '-':
                        ergebnis = eingabezahl1 - eingabezahl2;
                        break;
                    case '*':
                        ergebnis = eingabezahl1 * eingabezahl2;
                        break;
                    case '/':
                        if (eingabezahl2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fehler: Division durch Null nicht nöglich!");
                            Console.ResetColor();
                            continue;
                        }
                        ergebnis = eingabezahl1 / eingabezahl2;
                        break;
                    default:
                        Console.WriteLine("Fehler!");
                        return;

                }
                Console.Write($"Das ergebnis von {eingabezahl1} {operatorEingabe} {eingabezahl2} ist: {ergebnis}");

                //----- Abbrechen bzw Neustarten -----
                while (true)
                {
                    Console.Write("\nNoch eine Berechnung? (j/n)");
                    string wiederholung = Console.ReadLine().ToLower();

                    if (wiederholung == "j")
                    {
                        break;
                    }
                    else if (wiederholung == "n")
                    {
                        Environment.Exit(0);
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe. Bitte gib 'j' oder 'n' ein.");
                    Console.ResetColor();
                }
                
            }
            


            



        }
    }
}





