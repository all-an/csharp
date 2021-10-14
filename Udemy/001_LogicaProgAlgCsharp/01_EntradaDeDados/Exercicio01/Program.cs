using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa lê base e altura e mostra area, perimetro e diagonal com 4 casas decimais
            // a = altura , b = base
            double a, b, area, perimetro, diagonal;

            Console.Write("Digite a base do retângulo: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));
            Console.Write("Digite a altura do retângulo: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4"));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));

            Console.ReadLine();
        }
    }
}
