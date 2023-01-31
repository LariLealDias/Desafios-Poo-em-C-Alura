using Exercicio___Franquia_FastFood.Produtos;
using Exercicio___Franquia_FastFood.Clientes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Franquia_FastFood.Pedidos
{
    public class Pedido
    {
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;
        public Cliente cliente;

        public int codigoPedido;
        public double frete;
        public double valotTotal;
    }


}
