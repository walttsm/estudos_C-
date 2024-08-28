using System.Globalization;
class Program
{

    static void Main(string[] args)
    {
        Conta conta;

        Console.Write("Entre o numero da conta: ");
        int numConta = int.Parse(Console.ReadLine());

        Console.Write("Entre o nome do cliente: ");
        string nome = Console.ReadLine();

        Console.Write("Havera deposito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre o valor de deposito inicial: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numConta, nome, deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
        else
        {
            conta = new Conta(numConta, nome);
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }

        Console.WriteLine();
        Console.Write("Entre o valor do deposito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre o valor do saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);
    }
}