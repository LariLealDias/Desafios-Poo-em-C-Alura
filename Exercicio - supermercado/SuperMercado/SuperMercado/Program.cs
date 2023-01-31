
using SuperMercado;

Estoque produto1 = new Estoque();

produto1.nome = "bolacha chocolate";
produto1.tipo = "alimenticio";
produto1.fabricante = "recreios";
produto1.quantidade = 10;
produto1.Codigo = "193475-000";
produto1.valor = 2.50;

Console.WriteLine($"informações do produto1: nome - {produto1.nome}, tipo - {produto1.tipo}, codigo - {produto1.Codigo}");
Console.WriteLine();


//Aluno
Aluno aluno1 = new Aluno("Fulano S", "12334-xa", 10);
//aluno1.nome = "Fulano Silva";
//aluno1.RA = "12334-xa";
//aluno1.idade = 10;

Console.WriteLine($"{aluno1.nome}");

aluno1.Nome = "Fulano";
//visualizar/get
Console.WriteLine(aluno1.Nome);

//Console.WriteLine($"O {aluno1.nome} nasceu em {aluno1.VerificarAnoNascimento()}");
//aluno1.mesagemAnoNascimento();












