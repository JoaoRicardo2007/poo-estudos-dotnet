using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoCompras
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; private set; }

        public Produto(string nome, decimal preco)
        {

            if ( preco <= 0.00m )
            {
                throw new Exception("Preço Inválido");
            }

            this.Preco = preco;
            this.Nome = nome;

        }
    }
}
