using System;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ06_4550
{
    public enum BTTip
    {
        FRIZIDER,
        KLIMA
    }

    public class BelaTehnika : Proizvod
    {
        public BTTip Tip { get; set; }
        public int GodisnjaPotrosnja { get; set; }

        public BelaTehnika(string proizvodjac, string naziv, int cena, int potrosnja, BTTip tip) 
                          : base (proizvodjac, naziv, cena)
        {
            GodisnjaPotrosnja = potrosnja;
            Tip = tip;
        }

        public override void PrikazProizvoda()
        {
            string str = Cena.ToString();
            str = str.Insert(str.Length - 3, ".");

            Console.WriteLine(Proizvodjac + " " + Naziv + "\n" + "Cena: " + str + " RSD\nGodisnja Potrosnja: " + GodisnjaPotrosnja + "kWh");
            Console.WriteLine("-========================-");
        }

        public override string VratiTip()
        {
            if (Tip == BTTip.KLIMA)
                return "klima";
            else
                return "frizider";
        }
    }
}
