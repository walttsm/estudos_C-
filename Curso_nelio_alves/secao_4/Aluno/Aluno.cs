using System.Globalization;

class Aluno
{

    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaFinal()
    {

        return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado()
    {
        return NotaFinal() >= 60.0;
    }

    public double NotaRestante()
    {
        return 60.0 - NotaFinal();
    }
}