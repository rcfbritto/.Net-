using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<(int codigo, string nome, int quantidade, double preco)> estoque = new List<(int, string, int, double)>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Consultar Produto por Código");
            Console.WriteLine("3. Atualizar Estoque");
            Console.WriteLine("4. Gerar Relatórios");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarProduto();
                    break;

                case 2:
                    ConsultarProdutoPorCodigo();
                    break;

                case 3:
                    AtualizarEstoque();
                    break;

                case 4:
                    GerarRelatorios();
                    break;

                case 5:
                    Console.WriteLine("Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CadastrarProduto()
    {
        try
        {
            Console.Write("Código do Produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            double preco = double.Parse(Console.ReadLine());

            estoque.Add((codigo, nome, quantidade, preco));
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
        }
    }

    static void ConsultarProdutoPorCodigo()
    {
        try
        {
            Console.Write("Informe o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            var produto = estoque.FirstOrDefault(p => p.codigo == codigo);

            if (produto == default)
            {
                throw new ProdutoNaoEncontradoException();
            }

            Console.WriteLine($"Produto encontrado: Código: {produto.codigo}, Nome: {produto.nome}, Quantidade: {produto.quantidade}, Preço: {produto.preco}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar produto: {ex.Message}");
        }
    }

    static void AtualizarEstoque()
    {
        try
        {
            Console.Write("Informe o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            var produto = estoque.FirstOrDefault(p => p.codigo == codigo);

            if (produto == default)
            {
                throw new ProdutoNaoEncontradoException();
            }

            Console.Write("Informe a quantidade para adicionar (positiva) ou remover (negativa): ");
            int quantidade = int.Parse(Console.ReadLine());

            if (produto.quantidade + quantidade < 0)
            {
                throw new EstoqueInsuficienteException();
            }

            produto.quantidade += quantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao atualizar estoque: {ex.Message}");
        }
    }

    static void GerarRelatorios()
    {
        try
        {
            Console.Write("Informe o limite de quantidade para o relatório 1: ");
            int limiteQuantidade = int.Parse(Console.ReadLine());

            var relatorio1 = estoque.Where(p => p.quantidade < limiteQuantidade);
            Console.WriteLine("Relatório 1: Produtos com quantidade em estoque abaixo do limite");
            foreach (var produto in relatorio1)
            {
                Console.WriteLine($"Código: {produto.codigo}, Nome: {produto.nome}, Quantidade: {produto.quantidade}, Preço: {produto.preco}");
            }

            Console.Write("Informe o valor mínimo para o relatório 2: ");
            double minValor = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor máximo para o relatório 2: ");
            double maxValor = double.Parse(Console.ReadLine());

            var relatorio2 = estoque.Where(p => p.preco >= minValor && p.preco <= maxValor);
            Console.WriteLine("Relatório 2: Produtos com valor entre o mínimo e o máximo");
            foreach (var produto in relatorio2)
            {
                Console.WriteLine($"Código: {produto.codigo}, Nome: {produto.nome}, Quantidade: {produto.quantidade}, Preço: {produto.preco}");
            }

            var relatorio3 = from produto in estoque
                            select new { produto.nome, ValorTotal = produto.quantidade * produto.preco };

            Console.WriteLine("Relatório 3: Valor total do estoque e valor total de cada produto");
            double valorTotalEstoque = relatorio3.Sum(p => p.ValorTotal);
            Console.WriteLine($"Valor total do estoque: {valorTotalEstoque}");

            foreach (var produto in relatorio3)
            {
                Console.WriteLine($"Produto: {produto.nome}, Valor Total: {produto.ValorTotal}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gerar relatórios: {ex.Message}");
        }
    }
}

class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException() : base("Produto não encontrado.")
    {
    }
}

class EstoqueInsuficienteException : Exception
{
    public EstoqueInsuficienteException() : base("Estoque insuficiente para realizar a operação.")
    {
    }
}
