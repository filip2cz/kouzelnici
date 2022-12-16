using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kouzelnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] kouzelnici = { "funflame", "imaginez", "miraculo", "rimbleby", "septimus", "deepmire", "hypnotum", "tremenda" };

            Kouzelnik[] kouzelnici = new Kouzelnik[]
            {
                new Kouzelnik("funflame", "red", "pruzina"),
                new Kouzelnik("imaginez", "yellow", "mesic"),
                new Kouzelnik("miraculo", "red", "mesic"),
                new Kouzelnik("rimbleby", "blue", "modry mesic"),
                new Kouzelnik("septimus", "yellow", "mesic"),
                new Kouzelnik("deepmire", "blue", "hvezdy"),
                new Kouzelnik("hypnotum", "red", "hvezdy"),
                new Kouzelnik("tremenda", "red", "pruzina"),
            };

            bool computing = true;

            while (computing)
            {
                Random rnd = new Random();
                for (int i = 0; i < kouzelnici.Length; i++)
                {
                    int j = rnd.Next(i, kouzelnici.Length);
                    Kouzelnik temp = kouzelnici[i];
                    kouzelnici[i] = kouzelnici[j];
                    kouzelnici[j] = temp;
                }

                foreach (Kouzelnik kouzelnik in kouzelnici)
                {
                    Console.WriteLine(kouzelnik);
                }

                if (true)
                {
                    if (true)
                    {

                    }
                }
                computing = false;
            }

            Console.ReadLine();
        }
        class Kouzelnik
        {
            public string Jmeno { get; set; }
            public string Barva { get; set; }
            public string Tvar { get; set; }
            public override string ToString()
            {
                return $"{Jmeno}: {Barva}, {Tvar}";
            }
            public Kouzelnik(string jmeno, string barva, string tvar)
            {
                Jmeno = jmeno;
                Barva = barva;
                Tvar = tvar;
            }
        }
    }
}
