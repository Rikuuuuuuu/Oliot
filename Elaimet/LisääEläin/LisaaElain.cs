using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            int maara;
            Console.WriteLine("Kuinka monta eläintä lisätään?");
            maara = Convert.ToInt32(Console.ReadLine());

            List<Elain> ElainLista = new List<Elain>();

            for (int i = 0; i < maara; i++)
            {
                
                if ((i % 3) == 0)
                {
                    ElainLista.Add(new Kissa());
                }
                if ((i % 3) == 1)
                {
                    ElainLista.Add(new Koira());
                }
                if ((i % 3) == 2)
                {
                    ElainLista.Add(new Papukaija());
                }
                if ((i % 4) == 2)
                {
                    ElainLista.Add(new Hevonen());
                    i++;
                }
            }


            /*loop++;
            if (loop == 1 || loop == 7 || loop == 10 || loop == 13)
            {
                ElainLista.Add(new Kissa());
            }
            if (loop == 2 || loop == 5 || loop == 11 || loop == 14)
            {
                ElainLista.Add(new Koira());
            }
            if (loop == 3 || loop == 6 || loop == 9 || loop == 15)
            {
                ElainLista.Add(new Papukaija());
            }
            if (loop == 4 || loop == 8 || loop == 12 || loop == 16)
            {
                ElainLista.Add(new Hevonen());
           }*/

            foreach (var Elain in ElainLista) 
            {
                Console.WriteLine(Elain);
                Console.ReadLine();
            }

            List<Kissa> KissaLista = new List<Kissa>();
            List<Koira> KoiraLista = new List<Koira>();
            List<Hevonen> HevosLista = new List<Hevonen>();
            List<Linnut> LintuLista = new List<Linnut>();

            for (int x = 0; x < maara; x++)
            {
                if ((x % 3) == 0)
                {
                    KissaLista.Add(new Kissa());

                }
                if ((x % 3) == 1)
                {
                    KoiraLista.Add(new Koira());

                }
                if ((x % 3) == 2)
                {
                    LintuLista.Add(new Papukaija());

                }
                if ((x % 4) == 2)
                {
                    HevosLista.Add(new Hevonen());
                    x++;
                }
            }
            foreach (Kissa cat in KissaLista)
            {
                cat.nimi = "Karvinen";
                cat.ika = 5;
                cat.liha = "Kyllä";
                Console.WriteLine("Kissan nimi on: " + cat.PalautaElaimenNimi());
                Console.WriteLine("Kissan ikä on: " + cat.AsetaElaimenIka());
                Console.WriteLine("Onko lihansyöjä:" + cat.PalautaOnLihanSyoja());
                Console.WriteLine("Onko turkki: " + cat.PalautaTurkki());
                Console.ReadLine();
            }
            foreach (Koira dog in KoiraLista)
            {
                dog.nimi = "Musti";
                dog.ika = 10;
                dog.liha = "Kyllä";
                Console.WriteLine("Koiran nimi on: " + dog.PalautaElaimenNimi());
                Console.WriteLine("Koiran ikä on: " + dog.AsetaElaimenIka());
                Console.WriteLine("Onko lihansyöjä:" + dog.PalautaOnLihanSyoja());
                Console.WriteLine("Onko turkki: " + dog.PalautaTurkki());
                Console.ReadLine();
            }
            foreach (Papukaija parrot in LintuLista)
            {
                parrot.nimi = "Joonas";
                parrot.ika = 2;
                parrot.liha = "Ei";
                Console.WriteLine("Papukaijan nimi on: " + parrot.PalautaElaimenNimi());
                Console.WriteLine("Papukaijan ikä on: " + parrot.AsetaElaimenIka());
                Console.WriteLine("Onko lihansyöjä:" + parrot.PalautaOnLihanSyoja());
                Console.WriteLine("Onko siivet: " + parrot.PalautaSiivet());
                Console.ReadLine();
            }
            foreach (Hevonen horse in HevosLista)
            {
                horse.nimi = "Seppo";
                horse.ika = 7;
                horse.liha = "Ei";
                Console.WriteLine("Hevosen nimi on: " + horse.PalautaElaimenNimi());
                Console.WriteLine("Hevosen ikä on: " + horse.AsetaElaimenIka());
                Console.WriteLine("Onko lihansyöjä:" + horse.PalautaOnLihanSyoja());
                Console.WriteLine("Onko turkki: " + horse.PalautaTurkki());
                Console.ReadLine();
            }

        }
    }
}
