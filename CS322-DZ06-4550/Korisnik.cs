using System;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ06_4550
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public List<Proizvod> Korpa { get;set; }
        //bool vip kartica, ako true ima popust 10% ?

        public Korisnik(string ime)
        {
            Ime = ime;
            Korpa = new List<Proizvod>();
        }        
    }
}
