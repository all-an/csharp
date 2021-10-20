using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario //Diretor herda as propriedades e campos da classe Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf) //construtor do diretor atribuindo o cpf ao cpf base da classe Funcionário
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        // override sobrepõe o método GetBonificacao da classe Funcionario
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao(); //soma o conteúdo do GetBonificação() da base Funcionário
        }

    }
}
