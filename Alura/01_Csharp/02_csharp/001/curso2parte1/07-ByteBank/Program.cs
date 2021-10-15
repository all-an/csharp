using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antes das contas criadas, o total de contas criadas é: " + ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 8484932);


            ContaCorrente contaDaGabriela = new ContaCorrente(867, 8484940);

            Console.WriteLine("Depois das contas criadas, o total de contas criadas é: " + ContaCorrente.TotalDeContasCriadas);

            conta.Numero = 8484932;
            //conta.Agencia = 0;
            
            Console.WriteLine(conta.Agencia);

            if (conta.Agencia <= 0)
                Console.WriteLine("Agencia Invalida");

            Console.WriteLine(conta.Numero);
        }
    }
}
