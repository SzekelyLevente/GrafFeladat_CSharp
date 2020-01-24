using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine("szélességi bejárás 0 kezdőpontból:");
            graf.szelessegiBejar(0);
            Console.WriteLine("mélységi bejárás 0 kezdőpontból:");
            graf.melysegiBejar(0);
            Console.WriteLine("gráf összefüggősége: "+graf.Osszefuggo());
            Console.WriteLine("gráf feszítőfája:");
            Console.WriteLine(graf.feszitofa().ToString());
            Console.WriteLine("a mohó algoritmus csúcs színezései:");
            foreach (int i in graf.MohoSzinezes().Keys)
            {
                Console.WriteLine("csúcs: " + i + ", szín:" + graf.MohoSzinezes()[i]);
            }
            Console.ReadLine();
        }
    }
}
