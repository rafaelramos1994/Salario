using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Fornecedor : Pessoa
    {
        private double valorCredito;
        private double valorDivida;

        public Fornecedor(string n,string e,string t): base(e,t,n)
        {

        }
        public double ValorCredito
        {
            get { return valorCredito; }
            set { valorCredito = value; }
        }
        public double ValorDivida
        {
            get { return valorDivida; }
            set { valorDivida = value; }
        }
        public double obterSaldo()
        {
            if(ValorCredito - ValorDivida >= 0)
            {
                Console.WriteLine("O fornecedor nao está em divida.");
                return ValorCredito - ValorDivida;
            }
            if(valorCredito-ValorDivida < 0)
            {
                Console.WriteLine("O fornecedor  está em divida.");
                return ValorCredito - ValorDivida;
            }

            return 0;
        }
    }
}


