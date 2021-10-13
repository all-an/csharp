using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitiou: " + n1);

            Console.Write("Digite uma letra: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitiou: " + ch);

            Console.Write("Digite um número decimal: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //com ponto . separando decimal
            Console.WriteLine("Você digitiou: " + n2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
