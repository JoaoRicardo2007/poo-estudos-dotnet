using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoCompras
{
    class Program
    {
        public static void Main()
        {

            Produto agua = new Produto("Água", 2.50m);
            Produto feijao = new Produto("Feijão", 4.75m);
            Produto arroz = new Produto("Água", 3.95m);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(agua);
            carrinho.AdicionarProduto(feijao);
            carrinho.AdicionarProduto(arroz);

            decimal total = carrinho.ObterTotal();
            Console.WriteLine(total);
            int quantidade = carrinho.QuantidadeProdutos();
            Console.WriteLine(quantidade);
        }
    }
}
