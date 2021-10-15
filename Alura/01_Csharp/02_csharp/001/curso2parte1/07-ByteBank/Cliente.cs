using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        //outra forma é digitando prop e TAB duas vezes
        //o template abaixo aparecerá
        //public int MyProperty { get; set; }
        public string Nome { get; set; }

        private string _cpf; //campo , field
        public string Cpf //propriedade, expõe o campo
        {
            get
            {
                return _cpf;
            }
            set
            {
                //lógica de validação do CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
