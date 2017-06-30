using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep1.Salut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cum va numiti?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine($"Salut, {numeUtilizator}!");
        }
    }
}
