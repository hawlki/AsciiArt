using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");
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
