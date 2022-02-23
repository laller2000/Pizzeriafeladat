using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pizzeria
{
    class Pizzak
    {
        private string nev;
        private int kicsi;
        private int nagy;

        public string Nev { get => nev; set => nev = value; }
        public int Kicsi { get => kicsi; set => kicsi = value; }
        public int Nagy { get => nagy; set => nagy = value; }

        public Pizzak(string nev, int kicsi, int nagy)
        {
            Nev = nev;
            Kicsi = kicsi;
            Nagy = nagy;
        }
        public Pizzak(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Kicsi = Convert.ToInt32(adatok[1]);
            Nagy = Convert.ToInt32(adatok[2]);
        }

    }
}
