using Exercicio___Franquia_FastFood.Clientes;
using Exercicio___Franquia_FastFood.Enderecos;
using Exercicio___Franquia_FastFood.Pedidos;
using Exercicio___Franquia_FastFood.Produtos;


using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


        //EXERCICIO
//        Lorena é proprietária de uma franquia de fast food e quer disponibilizar para 
//        seus franqueados um sistema de pedidos online.O sistema idealizado por ela deverá
//        trabalhar com informações de pedidos de clientes, como valor total do pedido, cliente,
//        endereço de entrega e os itens selecionados (máximo de 3).

//        Te desafiamos a criar uma composição de classes que poderá ser usada no desenvolvimento do sistema da Lorena.Vamos ao desafio?
        
                                                    //class cliente = nome, tipoPagamento, public Endereco endereço;
                                                    //class endereço = cep, rua, numero, bairro;
                                                    //class produto = codigo, quantidade, tipo, valor;
                                                    //class pedido = public Produto produto1, public Cliente cliente1, numero_pedido, valorTotal;
                                                    //class MenssagemPedido = public Pedido 1 --> com metodo de cw retornando msgs de pedido 1:, pedido 2:  
        
       
Cliente cliente1 = new Cliente();
cliente1.nome = "Fulano da silva";
cliente1.tipoPagamento = "Cartão crédito";
cliente1.endereco = new Endereco();
cliente1.endereco.rua = "Namé";
cliente1.endereco.numero = 761;
cliente1.endereco.bairro = "Matilde";
cliente1.endereco.cep = "0000-00";

Pedido pedido1 = new Pedido();
pedido1.cliente = cliente1;
pedido1.codigoPedido = 89345;
pedido1.produto1 = new Produto();
pedido1.produto1.codigoProduto = 111;
pedido1.produto1.quantidade = 1;
pedido1.produto1.tipo = "acompanhamento";
pedido1.produto1.nome = "Batatas fritas";
pedido1.produto1.valor = 5.00;

pedido1.produto2 = new Produto();
pedido1.produto2.codigoProduto = 444;
pedido1.produto2.quantidade = 1;
pedido1.produto2.tipo = "Bebida";
pedido1.produto2.nome = "Sprite";
pedido1.produto2.valor = 7.00;

pedido1.produto3 = new Produto();
pedido1.produto3.codigoProduto = 777;
pedido1.produto3.quantidade = 1;
pedido1.produto3.tipo = "Lanches";
pedido1.produto3.nome = "XBurger";
pedido1.produto3.valor = 27.00;

pedido1.frete = 3.00 ;
pedido1.valotTotal = pedido1.produto1.valor + pedido1.produto2.valor + pedido1.produto3.valor + pedido1.frete;



Console.WriteLine("Informações do Pedido");
Console.WriteLine($"Código do pedido: {pedido1.codigoPedido}");
Console.WriteLine();
Console.WriteLine($"ITENS");
Console.WriteLine($"{pedido1.produto1.quantidade} - {pedido1.produto1.nome} = {pedido1.produto1.valor}");
Console.WriteLine($"{pedido1.produto2.quantidade} - {pedido1.produto2.nome} = {pedido1.produto2.valor}");
Console.WriteLine($"{pedido1.produto3.quantidade} - {pedido1.produto3.nome} = {pedido1.produto3.valor}");
Console.WriteLine();
Console.WriteLine($"Frete: {pedido1.frete}");
Console.WriteLine($"Total: {pedido1.valotTotal}");
Console.WriteLine();
Console.WriteLine($"Informãções do solicitante: ");
Console.WriteLine($"Nome: {cliente1.nome}");
Console.WriteLine($"Meio de pagamento: {cliente1.tipoPagamento}");












