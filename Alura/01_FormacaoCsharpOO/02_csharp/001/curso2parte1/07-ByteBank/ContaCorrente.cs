// using _05_ByteBank;

using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //construtor obrigando a inicializar a classe ContaCorrente com os parâmetros agencia e número
        //obrigatoriamente devem ser passados argumentos para estes parâmetros 
        public ContaCorrente(int agencia, int numero) //construtor é um método com o nome da classe
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }
        /*
        private Cliente _titular; // campo
        
        public Cliente Titular // propriedade, cuja função é expor o campo
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        
        //abaixo está uma solução simplificada da solução feita acima
        public Cliente Titular // propriedade, cuja função é expor o campo
        {
            get;
            set;
        }

        */
        //abaixo uma solução melhor ainda
        public Cliente Titular { get; set; }

        //static quer dizer que esta propriedade é desta classe
        //uma propriedade da classe e não dos objetos
        public static int TotalDeContasCriadas { get; private set; }

        //método desnecessário abaixo, pois acima foi privatizado somente o set impedindo modificação por fora desta classe
        /*
        public static int ObterTotalDeContasCriadas()
        {
            return TotalDeContasCriadas;
        }*/

        //campo
        public int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Agencia Invalida");
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return; //finaliza o método
                }
                this._saldo = value; 
            }
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}

