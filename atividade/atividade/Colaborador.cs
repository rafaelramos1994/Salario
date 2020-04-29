﻿using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Colaborador:Pessoa
    {
        private int codSetor;
        private double salarioBase;
        private int impostos;

        public Colaborador(string n, string e, string t) : base(e, t, n)
        {

        }
        public int CodSetor
        {
            get { return codSetor; }
            set { codSetor = value; }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public int Impostos
        {
            get { return impostos; }
            set { impostos = value; }
        }
        public virtual double calcularSalario()
        {
            return SalarioBase - (SalarioBase*((double)Impostos/100))  ;
        }
    }
}
