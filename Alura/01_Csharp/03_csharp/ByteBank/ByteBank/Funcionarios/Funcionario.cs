using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Funcionarios //entendo o namespace como uma designação, um direcionamento dentro do código c#
{
    public abstract class Funcionario //abstract torna a classe Funcionario abstrata impedindo sua criação como objeto ou referência
    {
        //0 - funcionario , 1 - diretor, 2 - designer
        //private int _tipo; //campo, field

        //propriedade abaixo
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; } //propriedades
        public string Cpf { get; private set; } //cpf protegido não pode ser setado / acessado sem método interno do Funcionário
        public double Salario { get; protected set; } //protected pode ser acessado somente neste classe e nas derivadas

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            Cpf = cpf;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        /* Abstraido o método ele se torna obrigatório ser sobrescrito e sobreposto
        {
            //Salario += (Salario * 0.10);
            //Salario *= 1.1; // Salario = Salario + (Salario * 0.10);  // 0.10 = 10% // Salario * 0.10 = 10 % do Salario
        }*/

        public abstract double GetBonificacao() //virtual pode ser usado por outra classe
        /* Abstraido o método ele se torna obrigatório ser sobrescrito e sobreposto
        {
            return Salario * 0.10;
        }*/

    }
}
