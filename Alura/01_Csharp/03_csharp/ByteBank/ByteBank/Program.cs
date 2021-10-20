using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)  //método estático 
        {
            CalcularBonificacao(); //agora método estático mas se fosse não estático (ou de instância) não poderia ser chamado assim
                                   //somente poderia ser chamado da forma abaixo
            // método statico não depende de um objeto para ser chamado
            /*
            Program programa = new Program();
            programa.CalcularBonificacao();
            */
            
            Console.WriteLine(".......................................................");
            Console.WriteLine(".......................................................");
            Console.WriteLine("..........CÓDIGO ABAIXO APENAS PARA ESTUDO.............");
            Console.WriteLine("...................NÃO COMENTAR........................");
            Console.WriteLine(".......................................................");
            Console.WriteLine(".......................................................");
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            /*
            //Funcionario carlos = new Funcionario(2000, "4893094893847");

            //carlos.Nome = "\nCarlos";
            //carlos.Cpf = "4893094893847"; //não compila mais devido ao cpf ser privado e obrigatório no construtor

            Console.WriteLine("Salário do carlos antes do aumento: " + carlos.Salario);

            carlos.AumentarSalario();

            Console.WriteLine("Novo salário carlos: " + carlos.Salario);
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine("\nBonificação do Funcionário: " + carlos.GetBonificacao());
            */
            Diretor charles = new Diretor("123234222");

            charles.Nome = "\nCharles";
            //charles.Cpf = "65848494893847";

            Console.WriteLine("Salário Charles: " + charles.Salario);

            charles.AumentarSalario();

            Console.WriteLine("Novo salário Charles aumentado: " + charles.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //gerenciador.Registrar(charles);

            Console.WriteLine(">>>>> CPF do Diretor: " + charles.Cpf);
            Console.WriteLine(charles.Nome);
            Console.WriteLine("\nBonificação do Diretor:  " + charles.GetBonificacao());

            Console.WriteLine("\nTotal de Bonificações: " + gerenciador.GetTotalBonificacao());

            //testando bonificações

            Funcionario charlesTeste = charles;

            Console.WriteLine("\nBonificação de uma referência de Diretor Charles: " + charles.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário charlesTeste: " + charlesTeste.GetBonificacao());

            //funcionário abaixo Pedro declarado como funcionário referenciando para Diretor

            Funcionario pedro = new Diretor("996969696996");

            Console.WriteLine("\nBonificação de uma referência de Diretor declarado Funcionário: " + pedro.GetBonificacao());
            Console.WriteLine(".......................................................");
            Console.WriteLine(".......................................................");
            Console.WriteLine("..........CÓDIGO ACIMA APENAS PARA FINS DE ESTUDO......");
            Console.WriteLine("...................NÃO COMENTAR........................");
            Console.WriteLine(".......................................................");
            Console.WriteLine(".......................................................");
            

            

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //Funcionario chaves = new Funcionario(2000, "4893094893847"); // abstrata não pode ser criada //carlos no curso
            //chaves.GetBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
