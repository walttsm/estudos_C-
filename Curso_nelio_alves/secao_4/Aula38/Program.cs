using System;
using System.Globalization;


namespace Aula38
{
    class Program
    {
        static void Main(string[] args)
        {

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre as medida do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (double)(xA + xB + xC) / 2;
            double areaX = (double)Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            p = (double)(yA + yB + yC) / 2;
            double areaY = (double)Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine("A area do triangulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do triangulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}