using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Operario: Colaborador
    {
        private double valorProducao;
        private int comissao;
        public Operario(string n, string e, string t) : base(e, t, n)
        {

        }

        public double ValorProducao
        {
            get { return valorProducao; }
            set { valorProducao = value; }
        }
        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double calcularSalario()
        {
            return base.calcularSalario()+(ValorProducao*((double)Comissao/100));
        }
    }
}
