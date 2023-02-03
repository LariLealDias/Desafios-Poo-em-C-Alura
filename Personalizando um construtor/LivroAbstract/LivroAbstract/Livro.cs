using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroAbstract
{
    public abstract class Livro
    {
        public string Titulo { get; protected set; } //Obrigatorio
        public string ISBN { get; protected set; } //Obrigatorio
        public string Autor { get; set; }
        public string AnoDePublicacao { get; set; }
        public string Genero { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDeOrigem { get; set; }

        public Livro(string titulo, string isbn)
        {
            this.Titulo = titulo;
            this.ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Titulo: {this.Titulo}  |  ISBN: {this.ISBN}\n" +
                   $"Autor: {this.Autor}  |  Ano de publicação: {this.AnoDePublicacao}\n " +
                   $"Genero: {this.Genero}  |  Numero de paginas: {this.NumeroDePaginas}\n" +
                   $"Pais de Origem: {this.PaisDeOrigem}";
        }
    }
}
