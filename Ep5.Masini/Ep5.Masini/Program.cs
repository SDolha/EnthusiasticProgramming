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
            double timp, viteză;

            Console.Write("Introduceti timpul (h): ");
            timp = double.Parse(Console.ReadLine());

            Console.Write("Introduceti viteza (km/h): ");
            viteză = double.Parse(Console.ReadLine());

            double distanță = timp * viteză;
            Console.WriteLine($"Se parcurge distanta de {distanță} km.");
        }
    }
}
