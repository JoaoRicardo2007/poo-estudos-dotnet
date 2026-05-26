using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoCompras
{
    class Carrinho
    {
        List<Produto> produtos = [];

        public bool AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            return true;
        }
        public bool RemoverProduto(Produto produto)
        {
            produtos.Remove(produto);
            return true;
        }
        public decimal ObterTotal()
        {
            decimal total = 0.00m;

            foreach (Produto produto in produtos)
            {
                total += produto.Preco;
            }
            return total;
        }
        public int QuantidadeProdutos()
        {
            int total = 0;

            total = produtos.Count;
            return total;
        }
    }
}
