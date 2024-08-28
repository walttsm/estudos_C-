class ConversorDeMoeda
{

    public static double iof = 6.0;
    public static double ConverterMoeda(double cotacao, double qtde)
    {
        return (1 + (iof / 100)) * (qtde * cotacao);
    }
}