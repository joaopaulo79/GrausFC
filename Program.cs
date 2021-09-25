using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n===== Fahrenheit para Celsius =====\n");
            Console.ResetColor();

            Console.WriteLine("Digite a temperatura em Fahrenheit,\npara converter em Celsius.\n");
            
            Console.Write("Temperatura em Fahrenheit: ");
            f = Convert.ToDouble(Console.ReadLine());

            c = (f - 32) / 1.8;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Conversão ===\n");
            Console.ResetColor();
            
            Console.WriteLine($"{f}°F equivalem a {c:N1}°C.\n");
        }
    }
}
