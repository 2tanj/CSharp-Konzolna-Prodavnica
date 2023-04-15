using System;
using System.Collections.Generic;
using System.IO;

namespace CS322_DZ06_4550
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string str = "asds;asd";

            //    string cena = str[(str.IndexOf(";") + 1)..];
            //    Console.WriteLine(cena);
            //    Console.ReadLine();

            Prodavnica p1 = new Prodavnica("WinWin");
            Korisnik k1 = new Korisnik(Prijavljivanje());

            p1.Pocetak(k1);
        }

        static public string Prijavljivanje()
        {
            Prodavnica.Space(30);
            Console.Write("Unesite svoje ime: ");
            return Console.ReadLine();
        }
    }
}
