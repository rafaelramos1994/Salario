using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Pessoa
    {
        private string endereco;
        private string nome;
        private string telefone;

        public Pessoa(string e, string t, string n)
        {
            this.nome = n;
            this.telefone = t;
            this.endereco = e;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
