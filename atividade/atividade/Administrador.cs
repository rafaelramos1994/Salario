using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Administrador: Colaborador
    {
        private double ajudaDeCusto;

        public double AjudaDeCusto
        {
            get { return ajudaDeCusto; }
            set { ajudaDeCusto = value; }
        }
        public Administrador(string n, string e, string t) : base(e, t, n)
        {

        }
        public override double calcularSalario()
        {
            return base.calcularSalario() + AjudaDeCusto; 
        }
    }
}
