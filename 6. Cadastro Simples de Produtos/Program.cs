using System;
using System.Collections.Generic;
using System.Globalization;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        Console.WriteLine("🛒 Cadastro de Produtos");
        Console.WriteLine("------------------------");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"\nProduto {i}:");

            Produto p = new Produto();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: R$ ");
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double preco))
            {
                Console.Write("⚠️ Valor inválido. Digite um número para o preço: ");
            }
            p.Preco = preco;

            Console.Write("Quantidade: ");
            while (!int.TryParse(Console.ReadLine(), out int qtd))
            {
                Console.Write("⚠️ Valor inválido. Digite um número inteiro para a quantidade: ");
            }
            p.Quantidade = qtd;

            produtos.Add(p);
        }

        Console.Clear();
        Console.WriteLine("📦 Produtos Cadastrados:");
        Console.WriteLine("------------------------");

        foreach (var prod in produtos)
        {
            Console.WriteLine($"🔹 {prod.Nome} | Preço: R$ {prod.Preco:F2} | Quantidade: {prod.Quantidade} | Total em Estoque: R$ {prod.ValorTotalEstoque():F2}");
        }
    }
}
