// See https://aka.ms/new-console-template for more information
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {

        Aluno a = new Aluno();

        Console.Write("Nome: ");
        a.Nome = Console.ReadLine();
        Console.Write("Nota 1: ");
        a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Nota 2: ");
        a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Nota 3: ");
        a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("NOTA FINAL: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (a.Aprovado())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
        }
    }
}
