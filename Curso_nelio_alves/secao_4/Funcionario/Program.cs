// See https://aka.ms/new-console-template for more information
using System.Globalization;
class Program
{

    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();

        Console.Write("Salario bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Imposto: ");
        f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(f);

        Console.Write("Porcentagem para aumentar o salario: ");
        double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        f.AumentarSalario(pct);
        Console.WriteLine(f);
    }
}
