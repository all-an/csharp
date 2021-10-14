using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.agencia = 1234;

            Console.WriteLine(conta.ObterSaldo());

            conta.DefinirSaldo(2000);
            //conta.DefinirSaldo(-2000);  //teste

            Console.WriteLine(conta.ObterSaldo());
        }
    }
}
