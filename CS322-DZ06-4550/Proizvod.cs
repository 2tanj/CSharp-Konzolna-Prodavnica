using System;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ06_4550
{
    public abstract class Proizvod
    {
        public string Proizvodjac { get; set; }
        public string Naziv { get; set; }
        public int Cena{ get; set; }

        public Proizvod(string proizvodjac, string naziv, int cena)
        {
            Proizvodjac = proizvodjac;
            Naziv = naziv;
            Cena = cena;
        }

        public abstract void PrikazProizvoda();
        public abstract string VratiTip();
    }
}
