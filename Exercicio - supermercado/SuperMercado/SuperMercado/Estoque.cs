using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    public class Estoque
    {
        public string nome;
        public string tipo;
        public string fabricante;
        public string Codigo;
        public double valor;
        public double quantidade;
    }

    public class Aluno
    {
        public string nome;
        public string RA;
        private int idade { get; set; }

        public Aluno(string nome, string RA, int idade)
        {
            this.nome = nome;
            this.RA = RA;
            this.idade = idade;   
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        //metodo
        //public int VerificarAnoNascimento()
        //{
        //    int anoNascimento = idade - 2023;
        //    return anoNascimento;
        //}

        //public void mesagemAnoNascimento()
        //{
        //    Console.WriteLine($"O {nome}, nasceu em {VerificarAnoNascimento()}");
        //}
    }

}
