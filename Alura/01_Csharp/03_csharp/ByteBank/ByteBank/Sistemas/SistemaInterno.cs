﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAtutenticado = funcionario.Autenticar(senha);

            

            if (usuarioAtutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;

            }
        }
    }
}
