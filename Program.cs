using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("===== Converter Fahrenheit em Celsius =====");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Digite a temperatura em Fahrenheit, para");
            Console.WriteLine("que eu possa converter em Celsius.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Temperatura em Fahrenheit: ");
            Console.ResetColor();
            string Fahrenheit = Console.ReadLine();
            double F = Convert.ToDouble(Fahrenheit);
            double C = (F - 32) / 1.8;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Conversão ===");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{F:N1}°F equivalem a {C:N1}°C.");
            Console.WriteLine();
        }
    }
}
