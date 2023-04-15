using System;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ06_4550
{
    public enum ElTip
    {
        TELEVIZOR,
        TELEFON
    }

    public class Elektronika : Proizvod
    {
        public double VelicinaEkrana { get; set; }
        public ElTip Tip { get; set; }

        public Elektronika(string proizvodjac, string naziv, int cena, double velicinaEkrana, ElTip tip) 
                          : base (proizvodjac, naziv, cena)
        {
            VelicinaEkrana = velicinaEkrana;
            Tip = tip;
        }

        public override void PrikazProizvoda()
        {
            string str = Cena.ToString();
            str = str.Insert(str.Length - 3, ".");

            Console.WriteLine(Proizvodjac + " " + Naziv + "\n" + "Cena: " + str + " RSD\nVelicina ekrana: " + Math.Round(VelicinaEkrana, 2) + "\"");
            Console.WriteLine("-========================-");
        }

        public override string VratiTip()
        {
            if (Tip == ElTip.TELEFON)
                return "telefon";
            else
                return "televizor";
        }
    }
}
