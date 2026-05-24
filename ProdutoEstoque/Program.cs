class Program
{
    public static void Main()
    {
        Produto produto1 = new Produto("Feijão", 5.99m, 0);
        Produto produto2 = new Produto("Arroz", 4.50m, 0);

        //Testes = True
        bool adicionar1 = produto1.AdicionarEstoque(5);

        if ( adicionar1 )
        {
            Console.WriteLine("Você adicionou produtos ao estoque.");
        }
        else
        {
            Console.WriteLine("Não foi possível adicionar ao estoque (valor inválido)");
        }
        
        bool remover1 = produto1.RemoverEstoque(2);

        if ( remover1 )
        {
            Console.WriteLine("Você removeu produtos do estoque.");
        }
        else
        {
            Console.WriteLine("Não foi possível remover estoque (valor inválido)");
        }

        bool alterar1 = produto1.AlterarPreco(4.50m);

        if( alterar1 )
        {
            Console.WriteLine($"Você alterou o preço do {produto1.Nome}");
        }
        else
        {
            Console.WriteLine("Não foi possível alterar valor do produto (valor inválido).");
        }

        bool adicionar2 = produto2.AdicionarEstoque(7);

        if ( adicionar2 )
        {
            Console.WriteLine("Você adicionou produtos ao estoque.");
        }
        else
        {
            Console.WriteLine("Não foi possível adicionar ao estoque (valor inválido)");
        }

        bool alterar2 = produto2.AlterarPreco(3.50m);

        if( alterar2 )
        {
            Console.WriteLine($"Você alterou o preço do {produto2.Nome}");
        }
        else
        {
            Console.WriteLine("Não foi possível alterar valor do produto (valor inválido).");
        }

        Console.WriteLine($"Produto 1: {produto1.Nome}, Preço: {produto1.Preco}, Quantidade em estoque: {produto1.QuantidadeEmEstoque}");
        Console.WriteLine($"Produto 2: {produto2.Nome}, Preço: {produto2.Preco}, Quantidade em estoque: {produto2.QuantidadeEmEstoque}");

        // Testes = False

        bool adicionar3 = produto1.AdicionarEstoque(0);

        if ( adicionar3 )
        {
            Console.WriteLine("Você adicionou produtos ao estoque.");
        }
        else
        {
            Console.WriteLine("Não foi possível adicionar ao estoque (valor inválido)");
        }
        
        bool remover3 = produto1.RemoverEstoque(10);

        if ( remover3 )
        {
            Console.WriteLine("Você removeu produtos do estoque.");
        }
        else
        {
            Console.WriteLine("Não foi possível remover estoque (valor inválido)");
        }

        bool alterar3 = produto1.AlterarPreco(-2.00m);

        if( alterar3 )
        {
            Console.WriteLine($"Você alterou o preço do {produto1.Nome}");
        }
        else
        {
            Console.WriteLine("Não foi possível alterar valor do produto (valor inválido).");
        }

        bool alterar4 = produto2.AlterarPreco(0.00m);

        if( alterar4 )
        {
            Console.WriteLine($"Você alterou o preço do {produto2.Nome}");
        }
        else
        {
            Console.WriteLine("Não foi possível alterar valor do produto (valor inválido).");
        }
    }
}