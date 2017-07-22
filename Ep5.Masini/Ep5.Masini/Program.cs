using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep5.Masini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti cate masini aveti: ");
            int câteMașini = int.Parse(Console.ReadLine());

            for (int i = 0; i < câteMașini; i++)
            {
                Console.WriteLine($"Masina {i + 1}: ");
                Mașină mașină = CiteșteMașină(i);

                double distanța = mașină.DistanțaTotală;
                Console.WriteLine($"\tSe parcurge distanta de {distanța} km.");
            }
        }

        private static Mașină CiteșteMașină(int i)
        {
            Mașină mașină = new Mașină { Nume = $"Mașină { i + 1 }" };

            Console.Write("\tIntroduceti cate parcursuri aveti: ");
            int câteParcursuri = int.Parse(Console.ReadLine());

            List<Parcurs> parcursuri = new List<Parcurs>();

            for (int j = 0; j < câteParcursuri; j++)
            {
                Console.WriteLine($"\tParcursul {j + 1}:");

                Console.Write("\t\tIntroduceti timpul (h): ");
                double timp = double.Parse(Console.ReadLine());

                Console.Write("\t\tIntroduceti viteza (km/h): ");
                double viteza = double.Parse(Console.ReadLine());

                parcursuri.Add(new Parcurs { Timp = timp, Viteză = viteza });
            }
            mașină.Parcursuri = new ReadOnlyCollection<Parcurs>(parcursuri);

            return mașină;
        }
    }
}
