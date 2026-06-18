using System.Diagnostics;

namespace TR
{
    internal class Program
    {
        static void Check_Input_Number()
        {

        }

         

        static void Main(string[] args)
        {
            bool debug_tr = true;
            double eingabezahl1;
            double eingabezahl2;
            double ergebnis = 0;
            char operatorEingabe;

            Console.WriteLine("--- Calculator v0.1 ---");


            //----- Zahl 1 abfragen -----
            Console.Write("Gib die erste Zahl ein: ");

            //while Schleife zum Prüfen ob TryParse False ist
            //TryParse https://learn.microsoft.com/de-de/dotnet/api/system.int32.tryparse?view=net-10.0
            //
            while (!double.TryParse(Console.ReadLine(), out eingabezahl1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ungültige Eingabe! Bitte versuche es mit einer Zahl erneut: ");
                Console.ResetColor();
            }
            //Debug ausgabe der Zahl
            //
            if (debug_tr)
            {
                Console.WriteLine($"Zahl 1 ist: {eingabezahl1}");
            }


            //----- Operator abfragen -----
            Console.Write("Gib einen Operator ein (+, -, *, /): ");
            //Die Schleife bis eingabe gültig ist
            //
            while (!char.TryParse(Console.ReadLine(), out operatorEingabe) || (operatorEingabe != '+' && operatorEingabe != '-' && operatorEingabe != '*' && operatorEingabe != '/'))
            {
                Console.Write("Ungültige EIngabe! Bitte gib einen gültigen Operator ein (+, -, *, /): ");
            }



            //----- Zahl 2 abfragen -----
            Console.Write("Gib die zweite Zahl ein: ");
            //while schleife zum prüfen wie oben
            while (!double.TryParse(Console.ReadLine(), out eingabezahl2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ungültige Eingabe! Bitte versuche es mit einer Zahl erneut: ");
                Console.ResetColor();
            }
            //Debug ausgabe der Zahl
            if (debug_tr)
            {
                Console.WriteLine($"Zahl 2 ist: {eingabezahl2}");
            }


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
                        return;
                    }
                    ergebnis = eingabezahl1 / eingabezahl2;
                    break;
                default:
                    Console.WriteLine("Fehler!");
                    return;

            }


            Console.Write($"Das ergebnis von {eingabezahl1} {operatorEingabe} {eingabezahl2} ist: {ergebnis}");


            Console.ReadKey();
        }
    }
}





