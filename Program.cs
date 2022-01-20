using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com os Km percorridos: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Entre com os litros gastos por Km: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = x / y;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
