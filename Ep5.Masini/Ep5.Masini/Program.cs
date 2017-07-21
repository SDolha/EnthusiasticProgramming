using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep5.Masini
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] timpi, viteze;

            Console.Write("Introduceti cate perechi de timp-viteza aveti: ");
            int câte = int.Parse(Console.ReadLine());
            CiteșteTimpiȘiViteze(câte, out timpi, out viteze);

            double distanță = CalculareDistanță(câte, timpi, viteze);
            Console.WriteLine($"Se parcurge distanta de {distanță} km.");
        }

        private static void CiteșteTimpiȘiViteze(int câte, out double[] timpi, out double[] viteze)
        {
            timpi = new double[câte];
            viteze = new double[câte];

            for (int i = 0; i < câte; i++)
            {
                Console.WriteLine($"Perechea {i + 1}:");

                Console.Write("\tIntroduceti timpul (h): ");
                timpi[i] = double.Parse(Console.ReadLine());

                Console.Write("\tIntroduceti viteza (km/h): ");
                viteze[i] = double.Parse(Console.ReadLine());
            }
        }

        private static double CalculareDistanță(int câte, double[] timpi, double[] viteze)
        {
            double distanțăTotală = 0;
            for (int i = 0; i < câte; i++)
            {
                double distanțăI = timpi[i] * viteze[i];
                distanțăTotală += distanțăI;
            }

            return distanțăTotală;
        }
    }
}
