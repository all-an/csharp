﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()

        {
            
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            /*
            try
            {
            */
             Console.WriteLine("Tentando dividir 10 por " + divisor);
             int resultado = Dividir(10, divisor);
             Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);   
            /*
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("Mensagem embutida na classe: " + erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível dividir por zero.");
            }
            */
        }

        private static int Dividir(int numero, int divisor)
        {

            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}
