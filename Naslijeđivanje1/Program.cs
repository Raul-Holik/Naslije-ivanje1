using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslijeđivanje1
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi, brzinaOkoSunca;

        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Brzina planeta oko osi je: " + BrzinaOkoOsi + " kmh, a brzina oko sunca mu je: " + BrzinaOkoSunca + " kmh.";
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Brzina satelita oko osi je: " + BrzinaOkoOsi + " kmh, a brzina oko sunca mu je: " + BrzinaOkoSunca + " kmh.";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Planet Zemlja = new Planet(1000, 10000);
                Satelit Mjesec = new Satelit(100, 1000);
                Console.WriteLine(Zemlja.ToString());
                Console.WriteLine(Mjesec.ToString());

                Console.ReadKey();
            }
        }
    }
}
