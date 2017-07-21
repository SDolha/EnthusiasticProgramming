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

            timpi = new double[câte];
            viteze = new double[câte];

            for (int i = 0; i < câte; i++)
            {
                Console.WriteLine($"Perechea {i + 1}:");

                Console.Write("\tIntroduceti timpul (h):");
                timpi[i] = double.Parse(Console.ReadLine());

                Console.Write("\tIntroduceti viteza (km/h): ");
                viteze[i] = double.Parse(Console.ReadLine());
            }

            double distanță = 0;
            for (int i = 0; i < câte; i++)
            {
                double distanțăI = timpi[i] * viteze[i];
                distanță += distanțăI;
            }

            Console.WriteLine($"Se parcurge distanta de {distanță} km.");
        }
    }
}
