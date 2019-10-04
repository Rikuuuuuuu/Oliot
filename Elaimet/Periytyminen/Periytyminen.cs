using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat
{
    class A : Elain
    {
        public override void Aantele()
        {
            Console.WriteLine("Hau!");
        }
    }
    class B : Elain
    {
        public override void Aantele()
        {
            Console.WriteLine("Miau!");
        }
    }
    class Periytyminen
        {
            static void Main(string[] args)
            {
                Kissa cat = new Kissa();
                Koira dog = new Koira();
                Nisakkaat nisakas = new Nisakkaat();

                cat.nimi = "Karvinen";
                Console.WriteLine("Kissan nimi on: " + cat.AsetaElaimenNimi());
                cat.ika = 5;
                Console.WriteLine("Kissa on " + cat.AsetaElaimenIka() + " vuotta vanha");
                Console.WriteLine("Onko lihansyöjä?");
                cat.liha = "Kyllä";
                Console.WriteLine(cat.PalautaOnLihanSyoja());
                Console.ReadLine();
                Elain kissanaani = new B();
                kissanaani.Aantele();
                Console.ReadLine();
                cat.Kehrää();

                dog.nimi = "Musti";
                Console.WriteLine("Koiran nimi on: " + dog.AsetaElaimenNimi());
                dog.ika = 7;
                Console.WriteLine("Koira on " + dog.AsetaElaimenIka() + " vuotta vanha");
                Console.WriteLine("Onko lihansyöjä?");
                dog.liha = "Kyllä";
                Console.WriteLine(dog.PalautaOnLihanSyoja());
                Console.ReadLine();
                Elain koiranääni = new A();
                koiranääni.Aantele();
                Console.ReadLine();

                Console.WriteLine("Nisäkäs ääni:");
                nisakas.Aantele();
                Console.ReadLine();

            }
        }
}