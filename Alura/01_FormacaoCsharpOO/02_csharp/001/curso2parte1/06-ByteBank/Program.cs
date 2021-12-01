using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "12345678910";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente; //atribuindo os dados do cliente a conta do titular
            //o value faz o trabalho de atribuição de cada dado do objeto _titular do tipo Cliente

            conta.Agencia = 1234;

            Console.WriteLine(conta.Saldo);

            conta.Saldo = 2000; // atribuindo o value
            //conta.Saldo = -2000;  //teste

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(conta.Titular.Nome);
        }
    }
}
