using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CS322_DZ06_4550
{
    public class Prodavnica
    {
        public string NazivProdavnice { get; set; }
        public List<Proizvod> Proizvodi{ get; set; }
        public Korisnik Kupac { get; set; }
        
        public Prodavnica(string naziv)
        {
            NazivProdavnice = naziv;
            Proizvodi = new List<Proizvod>();

            CitanjeFajla("frizideri");
            CitanjeFajla("klime");
            CitanjeFajla("telefoni");
            CitanjeFajla("televizori");
        }

        public void Pocetak(Korisnik k)
        {
            Kupac = k;
            MainMeni();
        }

        private void MainMeni()
        {
            Space(20);            

            Console.WriteLine(Kupac.Ime + ", Dobrodosli u " + NazivProdavnice + "!!\n");
            Console.WriteLine("1. Proizvodi");
            Console.WriteLine("2. Pretraga");
            Console.WriteLine("3. Moja korpa");
            Console.WriteLine("4. Izlaz\n");

            Console.Write(" > ");
            string ulaz = Console.ReadLine();

            switch (ulaz)
            {
                case "1":
                    Kupovina();
                    break;

                case "2":
                    Pretraga();
                    break;

                case "3":
                    Korpa();
                    break;

                case "4":
                    Console.WriteLine("Hvala vam na poseti!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Greska");
                    MainMeni();
                    break;
            }            
        }

        private void Kupovina()
        {
            //List<Proizvod> lista = new List<Proizvod>();

            Space(30);
            Console.WriteLine("-=====PREGLED PROZIVODA=====-");
            Console.WriteLine("1. Svi proizvodi");
            Console.WriteLine("2. Bela Tehnika");
            Console.WriteLine("3. Elektronika");
            Console.WriteLine("4. Nazad na MainMeni\n");

            Console.Write(" > ");
            string izbor = Console.ReadLine();

            switch (izbor)
            {
                case "1":
                    int z = 1;
                    foreach (var r in Proizvodi)
                    {
                        Console.WriteLine("[" + z++ + ".]");
                        r.PrikazProizvoda();
                    }

                    Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                    int ulaz = int.Parse(Console.ReadLine());
                    if (ulaz == -1)
                        MainMeni();

                    IzabranProizvod(Proizvodi[ulaz - 1]);                
                    break;

                case "2":
                    List<Proizvod> lista = new List<Proizvod>();

                    Space(30);
                    Console.WriteLine("-=====BELA TEHNIKA=====-");
                    Console.WriteLine("1. Svi proizvodi");
                    Console.WriteLine("2. Klime");
                    Console.WriteLine("3. Frizideri");

                    Console.Write(" > ");
                    string unos = Console.ReadLine();

                    if (unos == "1")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is BelaTehnika)
                            {
                                lista.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;
                        }

                        Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                        int izbor2 = int.Parse(Console.ReadLine());
                        if (izbor2 == -1)
                            MainMeni();

                        IzabranProizvod(lista[izbor2 - 1]);
                    } 
                    else if (unos == "2")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is BelaTehnika && r.VratiTip() == "klima")
                            {
                                lista.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;

                        }
                            Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                            int izbor2 = int.Parse(Console.ReadLine());
                            if (izbor2 == -1)
                                MainMeni();

                            IzabranProizvod(lista[izbor2 - 1]);
                    } 
                    else if(unos == "3")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is BelaTehnika && r.VratiTip() == "frizider")
                            {
                                lista.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;

                        }
                            Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                            int izbor2 = int.Parse(Console.ReadLine());
                            if (izbor2 == -1)
                                MainMeni();

                            IzabranProizvod(lista[izbor2 - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos!");
                        MainMeni();
                    }

                    break;

                case "3":
                    List<Proizvod> lista2 = new List<Proizvod>();

                    Space(30);
                    Console.WriteLine("-=====ELEKTRONIKA=====-");
                    Console.WriteLine("1. Svi proizvodi");
                    Console.WriteLine("2. Telefoni");
                    Console.WriteLine("3. Televizori");

                    Console.Write(" > ");
                    string unos2 = Console.ReadLine();

                    if (unos2 == "1")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is Elektronika)
                            {
                                lista2.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;
                        }

                        Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                        int izbor2 = int.Parse(Console.ReadLine());
                        if (izbor2 == -1)
                            MainMeni();

                        IzabranProizvod(lista2[izbor2 - 1]);
                    }
                    else if (unos2 == "2")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is Elektronika && r.VratiTip() == "telefon")
                            {
                                lista2.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;

                        }
                        Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                        int izbor2 = int.Parse(Console.ReadLine());
                        if (izbor2 == -1)
                            MainMeni();

                        IzabranProizvod(lista2[izbor2 - 1]);
                    }
                    else if (unos2 == "3")
                    {
                        int br = 1;
                        foreach (var r in Proizvodi)
                        {
                            if (r is Elektronika && r.VratiTip() == "televizor")
                            {
                                lista2.Add(r);
                                Console.WriteLine("[" + br++ + ".]");
                                r.PrikazProizvoda();
                            }
                            else
                                continue;

                        }
                        Console.Write("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
                        int izbor2 = int.Parse(Console.ReadLine());
                        if (izbor2 == -1)
                            MainMeni();

                        IzabranProizvod(lista2[izbor2 - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos!");
                        MainMeni();
                    }
                    break;

                case "4":
                    MainMeni();
                    break;

                default:
                    Console.WriteLine("Greska pri unosu!");
                    MainMeni();
                    break;
            }
        }

        private void IzabranProizvod(Proizvod p)
        {
            Space(5);
            Console.WriteLine("-=====IZABRAN PROZIVOD=====-");
            p.PrikazProizvoda();
            Console.WriteLine("\n 1. Dodaj u korpu");
            Console.WriteLine(" 2. Nazad na biranje");
            Console.WriteLine(" 3. Nazad na MainMeni\n");

            Console.Write(" > ");
            int izbor = int.Parse(Console.ReadLine());

            switch (izbor)
            {
                case 1:
                    Kupac.Korpa.Add(p);
                    Console.WriteLine("Proizvod uspesno dodat u korpu!");
                    MainMeni();
                    break;

                case 2:
                    Pretraga();
                    break;

                case 3:
                    MainMeni();
                    break;

                default:
                    Console.WriteLine("Greska u unosu!");
                    MainMeni();
                    break;
            }
        }

        private void Korpa()
        {
            Space(30);

            if(Kupac.Korpa.Count == 0)
            {
                Console.WriteLine("Vasa korpa je prazna!!");
                MainMeni();
            }

            Console.WriteLine("-=====MOJA KORPA=====-");
            foreach (var r in Kupac.Korpa)             
                r.PrikazProizvoda();
            

            Console.WriteLine("\n1. Plati");
            Console.WriteLine("2. Ocisti korpu");
            Console.WriteLine("3. Nazad na MainMeni\n");

            Console.Write(" > ");

            string izbor = Console.ReadLine();

            switch (izbor)
            {
                case "1":
                    int cena = 0;

                    foreach (var r in Kupac.Korpa)                    
                        cena += r.Cena;

                    string str = cena.ToString();
                    str = str.Insert(str.Length - 3, ".");

                    Space(5);
                    Console.WriteLine("Iznos vaseg racuna je: " + str + " RSD");
                    Console.Write("Vasa uplata: ");
                    int uplata = int.Parse(Console.ReadLine());

                    if(uplata > cena)
                    {
                        Console.WriteLine("\nVas kusur iznosi: " + (cena - uplata) + " RSD");
                        Console.WriteLine("Hvala vam na poseti!");
                        Environment.Exit(0);
                    } else if (uplata == cena)
                    {
                        Console.WriteLine("Proizvodi uspesno kupljeni!");
                        Console.WriteLine("Hvala vam na poseti!");
                        Environment.Exit(0);
                    } else
                    {
                        Console.WriteLine("Nemate dovoljno novca!");
                        Console.WriteLine("Hvala vam na poseti!");
                        Environment.Exit(0);
                    }
                    break;

                case "2":
                    Kupac.Korpa.Clear();
                    Console.WriteLine("Korpa uspesno ispreznjena!");

                    MainMeni();
                    break;

                case "3":
                    MainMeni();
                    break;

                default:
                    Console.WriteLine("Greska u unosu!");
                    MainMeni();
                    break;
            }
        }

        private void Pretraga()
        {
            Space(30);
            List<Proizvod> lista = new List<Proizvod>();

            Console.WriteLine("-=====PRETRAGA=====-");
            Console.Write("Unesite naziv zeljenog proizvoda: ");
            string ulaz = Console.ReadLine();

            Console.WriteLine();
            int z = 1;
            foreach(var r in Proizvodi)
            {   //TODO: ako ne sadrzi !!!!!!!!!!!!!!
                if (r.Naziv.Contains(ulaz, StringComparison.OrdinalIgnoreCase) || r.Proizvodjac.Contains(ulaz, StringComparison.OrdinalIgnoreCase))
                {
                    lista.Add(r);
                    Console.WriteLine("[" + z++ + ".]");
                    r.PrikazProizvoda();
                }                
            }

            Console.WriteLine("\n\nUnesite broj zeljenog proizvoda(-1 za izlaz): ");
            int izbor = int.Parse(Console.ReadLine());
            if (izbor == -1)
                MainMeni();          

            IzabranProizvod(lista[izbor - 1]);            
        }

        private void CitanjeFajla(string nazivFajla)
        {
            Random rnd = new Random();
            using (StreamReader sr = File.OpenText(nazivFajla + ".txt"))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    string pro = str.Substring(0, str.IndexOf(" "));
                    string naziv = str.Substring(str.IndexOf(" ") + 1, (str.IndexOf(";") - (str.IndexOf(" ") + 1)));
                    string cena = str.Substring(str.IndexOf(";") + 1, str.Length - (str.IndexOf(";") + 1));

                    if (nazivFajla == "televizori")
                        Proizvodi.Add(new Elektronika(pro, naziv, int.Parse(cena), RandBroj(rnd, "televizor"), ElTip.TELEVIZOR));
                    else if (nazivFajla == "telefoni")
                        Proizvodi.Add(new Elektronika(pro, naziv, int.Parse(cena), RandBroj(rnd, "telefon"), ElTip.TELEFON));
                    else if (nazivFajla == "klime")
                        Proizvodi.Add(new BelaTehnika(pro, naziv, int.Parse(cena), (int)RandBroj(rnd, "bela"), BTTip.KLIMA));
                    else if (nazivFajla == "frizideri")
                        Proizvodi.Add(new BelaTehnika(pro, naziv, int.Parse(cena), (int)RandBroj(rnd, "bela"), BTTip.FRIZIDER));
                    else
                    {
                        Console.WriteLine("POGRESAN UNOS IMENA FAJLA!!!!");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine("Uspesno citanje fajla!");
        }

        static double RandBroj(Random rand, string izbor)
        {
            if (izbor == "bela")
                return rand.Next(100, 1000);
            else if (izbor == "telefon")
                return rand.Next(5, 9) + rand.NextDouble();
            else if (izbor == "televizor")
                return rand.Next(40, 80) + rand.NextDouble();
            else
                return 9999999999; //greska pri unosu
        }

        public static void Space(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
