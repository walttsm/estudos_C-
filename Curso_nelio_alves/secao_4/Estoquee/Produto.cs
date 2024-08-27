using System.Globalization;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return "nome = " + Nome + ", preco = $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", quantidade = " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}