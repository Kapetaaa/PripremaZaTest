using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaTest
{
    class Zaposleni : Osoba
    {
        public int brRadnihSati;
        private double vrednostSata, baznaPlata;

        public double VrednostSata
        {
            get { return vrednostSata; }
            set { vrednostSata = value; }
        }

        public double BaznaPlata
        {
            get { return baznaPlata; }
            set { baznaPlata = value; }
        }

        public Zaposleni(string ime, string prezime, string jmbg, int brRadnihSati) : base(ime, prezime, jmbg)
        {
            this.brRadnihSati = brRadnihSati;
        }

        public override string predstaviSe()
        {
            return base.predstaviSe() + " | Broj radnih sati: " + brRadnihSati;
        }

        public virtual double izracunajPlatu()
        {
            Console.Write("Plata je ");
            return baznaPlata = brRadnihSati * vrednostSata;
        }
    }
}
