using System.Globalization;
class Conta
{

    protected int N_conta { get; private set; }
    string Titular { get; set; }
    protected double Saldo { get; private set; }

    public Conta(int n_conta, string titular)
    {
        N_conta = n_conta;
        Titular = titular;
        Saldo = 0.0;
    }

    public Conta(int n_conta, string titular, double deposito) : this(n_conta, titular)
    {
        Deposito(deposito);
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        if (quantia <= Saldo)
            Saldo -= quantia + 5.0;
        else
            Console.WriteLine("Saldo insuficiente!");
    }

    public override string ToString()
    {
        return "Conta "
            + N_conta
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}