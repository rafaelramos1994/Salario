using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Vendedor:Colaborador
    {
        private double valorVendas;
        private int comissao;
        public Vendedor(string n, string e, string t) : base(e, t, n)
        {

        }
        public double ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
        }
        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double calcularSalario()
        {
            return base.calcularSalario() + (ValorVendas* ((double)Comissao / 100));
        }
    }
}
