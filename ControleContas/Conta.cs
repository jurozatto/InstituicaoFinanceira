using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleContas
{
    public class Conta
    {
        private static decimal _saldoTotalGeral = 0;
        private static Conta _contaMaiorSaldo = null;




        public Conta(long numero) //construtor default (mesmo nome da classe), a assinatura deste e do segundo é diferente, esse recebe long numero e o outro nada | não tem retorno pois constroi a classe
        {
            this.Numero = numero;
        }

        public Conta()
        {
            _numero = new Random().Next(100000000, 999999999);
        }

        
        private long _numero; //long é um tipo inteiro maior | com private significa que o número da conta pode ser acessado somente dentro da classe (dá erro na classe)
        public long Numero
        {
            get
            {
                return _numero;
            }

            private set
            {
                _numero = value;
            }
        }


            public decimal _saldo;
            public decimal Saldo
            {
                get
                {
                    return _saldo;
                }
                private set
                {
                    _saldo = value;
                }

            }

        public void Depositar(decimal value)
        {
            if (value < 0)
            {
                Console.WriteLine("valor negativo");
                return;
            }
            _saldo += value;
            _saldoTotalGeral += value;

            AtualizarContaMaiorSaldo();
        }

        public static decimal SaldoTotalGeral
        {
            get { return _saldoTotalGeral; }
        }

        public static Conta ContaMaiorSaldo
        {
            get { return _contaMaiorSaldo; }
        }

        private void AtualizarContaMaiorSaldo()
        {
            if (_contaMaiorSaldo == null || this._saldo > _contaMaiorSaldo._saldo)
            {
                _contaMaiorSaldo = this;
            }
        }

        public Cliente Titular { get; private set; }


        // Construtor com cliente
        public Conta(long numero, Cliente titular)
        {
            this.Numero = numero;
            this.Titular = titular ?? throw new ArgumentNullException(nameof(titular), "A conta precisa de um titular.");
        }

        public Conta(Cliente titular)
        {
            _numero = new Random().Next(100000000, 999999999);
            this.Titular = titular ?? throw new ArgumentNullException(nameof(titular), "A conta precisa de um titular.");
        }

    }


}



