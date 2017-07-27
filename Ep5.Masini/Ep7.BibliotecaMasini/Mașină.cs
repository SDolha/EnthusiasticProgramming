using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep7.BibliotecaMasini
{
    public class Mașină
    {
        public string Nume { get; set; }
        public IReadOnlyCollection<Parcurs> Parcursuri { get; set; }

        public double DistanțaTotală => Parcursuri.Sum(p => p.Distanță);
    }

    public class Parcurs
    {
        public double Timp { get; set; }
        public double Viteză { get; set; }

        public double Distanță => Timp * Viteză;
    }
}
