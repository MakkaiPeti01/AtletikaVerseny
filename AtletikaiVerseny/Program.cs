using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> lista = new List<Atleta>();
        static Dictionary<string, int> csapatok = new Dictionary<string, int>();
        static void Beolvas()
        {
            StreamReader olvas = new StreamReader("tavol.cs");
            while (!olvas.EndOfStream)
            {
                lista.Add(new Atleta(olvas.ReadLine()));
            }
            olvas.Close();
            foreach (var i in lista)
            {
                Console.WriteLine(i.Egyesulet);
            }
        }
        static void Masodik()
        {
            foreach (var i in lista)
            {
                Console.WriteLine("2. feladat: Nevek és ugrások\n" +
                    "{0} {1} {2}", i.VezNev + " " + i.KerNev, i.Ugras);
            }
        }
        static void Harmadik()
        {
            foreach (var i in lista)
            {
                if (!csapatok.ContainsKey(i.Egyesulet))
                {
                    csapatok.Add(i.Egyesulet, 0);
                }
            }
            foreach (var i in csapatok)
            {
                Console.WriteLine("3. feladat: Egyesületek:\n" +
                    "{0}", i.Key);
            }
        }
        static void Negyedik()
        {
            int max = 0;
            string neve = "";
            foreach (var i in lista)
            {
                if (i.Ugras > max)
                {
                    max = i.Ugras;
                    neve = i.VezNev + " " + i.KerNev;
                }
            }
            Console.WriteLine("4. feladat: Legnagyobb ugrás: \n" +
                "{0}: {1} cm", neve, max);
        }
        static void Otodik()
        {
            double atlag;
            int sum = 0;
            int db = 0;
            foreach (var i in lista)
            {
                sum = sum + i.Ugras;
            }
            atlag = sum / lista.Count;
            foreach (var i in lista)
            {
                if (i.Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine("5. feladat: Átlag alatt lévő ugrások száma: {0}", db);
        }
        static void Hatodik()
        {
            StreamWriter iro = new StreamWriter("versenyzok.txt");
            foreach (var i in lista)
            {
                iro.WriteLine("{0} {1}",i.Rajtszam);
            }
            iro.Close();
        }
        static void Main(string[] args)
        {
            var h = new Atleta("623;Ug Imre;Kalocsai Rozmarok;640");
            Beolvas();
            Masodik();
            Harmadik();
            Negyedik();
            Otodik();
            Hatodik();
            Console.ReadKey();
        }
    }
}
