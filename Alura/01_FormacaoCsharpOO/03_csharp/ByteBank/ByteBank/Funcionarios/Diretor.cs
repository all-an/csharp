using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel //Diretor herda as propriedades e campos da classe Funcionario
    {
        //public string Senha { get; set; } //propriedade senha adicionado ao funcionario

        public Diretor(string cpf) : base(5000, cpf) //construtor do diretor atribuindo o cpf ao cpf base da classe Funcionário
        {
            Console.WriteLine("Funcionário Criado é Diretor");
        }

        public bool Autenticar(string senha)
        {
            return true;
        }
        /*
        public bool Autenticar(string senha) // método autenticar
        {
            return this.Senha == senha;
             // esse código abaixo significa o código acima
            if(this.Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }*/

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        // override sobrepõe o método GetBonificacao da classe Funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.1; //soma o conteúdo do GetBonificação() da base Funcionário
        }

    }
}
