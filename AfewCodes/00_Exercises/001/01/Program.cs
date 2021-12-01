using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {   
            var retry = true;
            while (retry)
            {
                int input;
                Console.Write("Por favor entre sua idade: ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input % 2 == 0)
                    {
                        Console.WriteLine("Par");
                    }
                    else
                    {
                        Console.WriteLine("Impar");
                    }
                    retry = false;
                }
                else
                {
                    Console.WriteLine("Você quer ser engraçado, e essa é uma mensagem engraçada então.\n");
                }
            }
        }
    }
}
