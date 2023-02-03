
#region
//Agora imagine ter que modelar uma classe de livros com título, autor, ISBN, ano de
//publicação, estilo literário, número de páginas e país de publicação. Como
//podemos tornar o ISBN e o título informações obrigatórias, ou seja, algo que
//a pessoa que cria os objetos da classe precisa passar? Sua missão,
//é criar este construtor personalizado para a classe Livro.
#endregion

using LivroAbstract;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarLivro admin = new AdicionarLivro("titulo", "x02384-sdc");

            admin.AnoDePublicacao = "2013";

            Console.WriteLine(admin);
        }
    }
}




