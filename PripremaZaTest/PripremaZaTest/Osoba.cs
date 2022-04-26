using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaTest
{
    class Osoba
    {

        public string ime, prezime, jmbg;

        public Osoba(string ime, string prezime, string jmbg)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
        }

        public virtual string predstaviSe()
        {
            return "Ime: " + ime + " | Prezime: " + prezime + " | JMBG: " + jmbg;
        }
    }
}

