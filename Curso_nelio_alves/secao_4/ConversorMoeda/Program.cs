using System.Globalization;

public class Program
{

    public static void Main(string[] args)
    {

        Console.Write("Qual a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.ConverterMoeda(cotacao, valorCompra).ToString("F2", CultureInfo.InvariantCulture));
    }
}
