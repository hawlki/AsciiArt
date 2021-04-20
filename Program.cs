using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("----------------------------");
            Console.WriteLine("          Asciiart          ");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("  ||  || ");
            Console.WriteLine("  \\\\()// ");
            Console.WriteLine(" //(__)\\\\ ");
            Console.WriteLine(" ||    ||");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Clique em uma tecla para limpar a tela");
            Console.ReadKey();
            
            Console.ResetColor();
            Console.Clear();
        }
    }
}
