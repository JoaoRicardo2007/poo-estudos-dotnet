class Produto
{
    public string Nome { get; set; }

    public decimal Preco { get; private set;}

    public int QuantidadeEmEstoque { get; set; }

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        QuantidadeEmEstoque = quantidade;

        if ( preco <= 0.00m )
        {
            return;
        }
        else
        {
            Preco = preco;
        }
    }

    public bool AdicionarEstoque(int quantidade)
    {
       if ( quantidade <= 0 )
        {
            return false;
        }
        else
        {
            QuantidadeEmEstoque += quantidade;
            return true;
        }
        
    }

    public bool RemoverEstoque(int quantidade)
    {
       if ( quantidade <= 0 || quantidade > QuantidadeEmEstoque )
        {
            return false;
        }
        else
        {
            QuantidadeEmEstoque -= quantidade; 
            return true;
        }
    }

    public bool AlterarPreco(decimal preco)
    {
        if ( preco <= 0.00m)
        {
            return false;
        }
        else
        {
            Preco = preco;
            return true;
        }
    }
}