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

            int pokusy = 0;

            Kouzelnik[] kouzelnici = new Kouzelnik[]
            {
                new Kouzelnik("Deepmire", "blue", "stars"),
                new Kouzelnik("Funflame", "red", "swirls"),
                new Kouzelnik("Hypnotum", "red", "stars"),
                new Kouzelnik("Imaginez", "yellow", "moons"),
                new Kouzelnik("Miraculo", "red", "moons"),
                new Kouzelnik("Rimbleby", "blue", "moons"),
                new Kouzelnik("Septimus", "yellow", "stars"),
                new Kouzelnik("Tremenda", "blue", "swirls"),
            };

            bool computing = true;

            while (computing)
            {
                pokusy++;
                Random rnd = new Random();
                for (int i = 0; i < kouzelnici.Length; i++)
                {
                    int j = rnd.Next(i, kouzelnici.Length);
                    Kouzelnik temp = kouzelnici[i];
                    kouzelnici[i] = kouzelnici[j];
                    kouzelnici[j] = temp;
                }

                //foreach (Kouzelnik kouzelnik in kouzelnici)
                //{
                //    Console.WriteLine(kouzelnik);
                //}

                if (kouzelnici[0].Barva != kouzelnici[1].Barva)
                {
                    if (kouzelnici[0].Tvar != kouzelnici[1].Tvar)
                    {
                        if (kouzelnici[2].Barva != kouzelnici[3].Barva)
                        {
                            if (kouzelnici[2].Tvar != kouzelnici[3].Tvar)
                            {
                                if (kouzelnici[4].Barva != kouzelnici[5].Barva)
                                {
                                    if (kouzelnici[4].Tvar != kouzelnici[5].Tvar)
                                    {
                                        if (kouzelnici[6].Barva != kouzelnici[7].Barva)
                                        {
                                            if (kouzelnici[6].Tvar != kouzelnici[7].Tvar)
                                            {
                                                if (kouzelnici[0].Jmeno == "Funflame" | kouzelnici[1].Jmeno == "Funflame" | kouzelnici[4].Jmeno == "Funflame" | kouzelnici[5].Jmeno == "Funflame")
                                                {
                                                    if (kouzelnici[0].Jmeno == "Funflame" && kouzelnici[1].Jmeno == "Imaginez")
                                                    {}
                                                    else if (kouzelnici[1].Jmeno == "Funflame" && kouzelnici[0].Jmeno == "Imaginez")
                                                    {}
                                                    else if (kouzelnici[4].Jmeno == "Funflame" && kouzelnici[5].Jmeno == "Imaginez")
                                                    {}
                                                    else if (kouzelnici[5].Jmeno == "Funflame" && kouzelnici[4].Jmeno == "Imaginez")
                                                    {}
                                                    else if (kouzelnici[0].Jmeno == "Imaginez" | kouzelnici[1].Jmeno == "Imaginez" | kouzelnici[4].Jmeno == "Imaginez" | kouzelnici[5].Jmeno == "Imaginez")
                                                    {
                                                        if (kouzelnici[2].Jmeno == "Miraculo" | kouzelnici[3].Jmeno == "Miraculo" | kouzelnici[4].Jmeno == "Miraculo" | kouzelnici[5].Jmeno == "Miraculo")
                                                        {
                                                            if (kouzelnici[2].Jmeno == "Miraculo" && kouzelnici[3].Jmeno == "Rimbleby")
                                                            {}
                                                            else if (kouzelnici[3].Jmeno == "Miraculo" && kouzelnici[2].Jmeno == "Rimbleby")
                                                            {}
                                                            else if (kouzelnici[4].Jmeno == "Miraculo" && kouzelnici[5].Jmeno == "Rimbleby")
                                                            {}
                                                            else if (kouzelnici[5].Jmeno == "Miraculo" && kouzelnici[4].Jmeno == "Rimbleby")
                                                            {}
                                                            else if (kouzelnici[2].Jmeno == "Rimbleby" | kouzelnici[3].Jmeno == "Rimbleby" | kouzelnici[4].Jmeno == "Rimbleby" | kouzelnici[5].Jmeno == "Rimbleby")
                                                            {
                                                                if (kouzelnici[6].Jmeno != "Septimus" | kouzelnici[7].Jmeno != "Septimus")
                                                                {
                                                                    computing = false;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Gianteye:");
            Console.WriteLine(kouzelnici[0].Jmeno);
            Console.WriteLine(kouzelnici[1].Jmeno);
            Console.WriteLine();

            Console.WriteLine("Meramaid:");
            Console.WriteLine(kouzelnici[2].Jmeno);
            Console.WriteLine(kouzelnici[3].Jmeno);
            Console.WriteLine();

            Console.WriteLine("Longmous:");
            Console.WriteLine(kouzelnici[4].Jmeno);
            Console.WriteLine(kouzelnici[5].Jmeno);
            Console.WriteLine();

            Console.WriteLine("Vidopnir:");
            Console.WriteLine(kouzelnici[6].Jmeno);
            Console.WriteLine(kouzelnici[7].Jmeno);
            Console.WriteLine();

            Console.WriteLine($"Využitý počet pokusů: {pokusy}");
            Console.WriteLine();

            Console.WriteLine("Press enter to exit...");
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
