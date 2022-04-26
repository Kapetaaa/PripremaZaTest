using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaTest
{
    class Direktor : Zaposleni
    {
        private double dodatak, direktorskaPlata;

        public Direktor(string ime, string prezime, string jmbg, int brRadnihSati, double dodatak) : base(ime, prezime, jmbg, brRadnihSati)
        {
            this.dodatak = dodatak;
        }

        public override string predstaviSe()
        {
            return base.predstaviSe() + " | Ja sam direktor!";
        }

        public override double izracunajPlatu()
        {
            return (1 + dodatak / 100) * base.izracunajPlatu();
        }
    }
}
