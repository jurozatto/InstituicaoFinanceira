using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleContas
{
    public class Conta
    {
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
      
        
    }
}
