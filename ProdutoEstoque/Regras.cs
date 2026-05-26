/*

Exercício — Sistema de Produto/Estoque

Crie uma classe:

Produto

Ela deve ter:

- Nome
- Preco
- QuantidadeEmEstoque

Regras:

1. Produto deve nascer com:
- nome obrigatório
- preço obrigatório

2. Preço:
- não pode ser negativo
- não pode ser alterado livremente fora da classe

3. Quantidade em estoque:
- começa em 0
- não pode ficar negativa

Métodos:

AdicionarEstoque:
- recebe quantidade
- adiciona no estoque
- não aceita 0 ou negativo

RemoverEstoque:
- recebe quantidade
- remove do estoque
- não pode remover mais do que existe
- não aceita 0 ou negativo

AlterarPreco:
- recebe novo preço
- valida
- altera preço

Na Main:
- criar produto
- adicionar estoque
- remover estoque
- testar casos inválidos
- mostrar informações finais

IMPORTANTE:
- não usar Console dentro da classe Produto
- não misturar lógica da interface com a entidade
- pensar em responsabilidade da classe
- pensar em encapsulamento
- pensar em estado válido do objeto

*/