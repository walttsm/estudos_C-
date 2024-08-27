﻿using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Produto p;

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preco: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());
        p = new Produto(nome, preco, quantidade);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);

        Console.WriteLine();
        Console.Write("Digite o numero de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
    }
}
