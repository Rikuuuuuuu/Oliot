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
           

            //Hevonen
            Hevonen heppa = new Hevonen();
            // hevonen.Nimi = "Seppo";
            // hevonen.Paino = 100;
            Console.WriteLine("Hevosen nimi on: " + heppa.PalautaElaimenNimi());
            Console.ReadLine();

            //Kissa
            Kissa emo = new Kissa();
            emo.emo = "Emo1";
            emo.maara = 3;
            emo.Pentu();

            Kissa emo2 = new Kissa();
            emo2.emo = "Emo2";
            emo2.maara = 2;
            emo2.Pentu();

            Kissa katti = new Kissa();
            Console.WriteLine("Kissan nimi on: " + katti.PalautaElaimenNimi());
            katti.nimi = "Joel";
            Console.ReadLine();
            Console.WriteLine("Kissan nimi on: " + katti.PalautaElaimenNimi() + " ja sen ikä on: " + katti.AsetaElaimenIka());
            Console.WriteLine(katti.PalautaElaimenNimi() + " " + katti.PalautaElaimenIka());
            Console.ReadLine();

            Kissa cat = new Kissa();
            Console.WriteLine("Kissan nimi on: " + katti.PalautaElaimenNimi() + " ja sen ikä on: " + cat.AsetaElaimenIka());
            Console.WriteLine(katti.PalautaElaimenNimi() + " " + cat.PalautaElaimenIka());
            Console.ReadLine();
            

            Kissa kisu = new Kissa();
            Console.WriteLine("Kissan nimi on: " + kisu.PalautaElaimenNimi() + " ja sen ikä on: " + kisu.AsetaElaimenIka());
            Console.WriteLine(kisu.PalautaElaimenNimi() + " " + kisu.PalautaElaimenIka());
            Console.ReadLine();
            Console.WriteLine(kisu.PalautaElaimenNimi());
            Console.ReadLine();
            kisu.nimi = "Hilda";
            Console.WriteLine(kisu.PalautaElaimenNimi());
            Console.WriteLine(kisu.PalautaElaimenNimi());
            Console.ReadLine();


            //Koira
            Koira musti = new Koira();
            Koira dog = new Koira();
            dog.nimi = "Max";
            Console.WriteLine("Koiran nimi on: " + dog.PalautaElaimenNimi());
            Console.ReadLine();
            Console.WriteLine("Koiran nimi on: " + musti.PalautaElaimenNimi());
            Console.ReadLine();
            dog.nimi = "musti";
            Console.WriteLine(dog.AsetaElaimenNimi());
            Console.WriteLine(musti.PalautaElaimenNimi());
            Console.ReadLine();


            //Ikä
            Koira snoop = new Koira();
            Kissa mirri = new Kissa();
            for (int i = 0; i < 10; i++)
            {
                if (snoop.KoiranIka() > mirri.Kissaika())
                {
                    Console.WriteLine("Koira on " + snoop.ika + " vuotta");
                    Console.WriteLine("Kissa on " + mirri.ika + " vuotta");
                    Console.WriteLine("Koira on vanhempi");
                    Console.ReadLine();
                }
                if (mirri.Kissaika() > snoop.KoiranIka())
                {
                    Console.WriteLine("Koira on " + snoop.ika + " vuotta");
                    Console.WriteLine("Kissa on " + mirri.ika + " vuotta");
                    Console.WriteLine("Kissa on vanhempi");
                    Console.ReadLine();
                }
                if (mirri.Kissaika() == snoop.KoiranIka())
                {
                    Console.WriteLine("Koira on " + snoop.ika + " vuotta");
                    Console.WriteLine("Kissa on " + mirri.ika + " vuotta");
                    Console.WriteLine("Eläimet ovat saman ikäisiä");
                    Console.ReadLine();
                }
            }


            Koira susi = new Koira();
            Console.WriteLine("Koiran nimi on: " + susi.PalautaElaimenNimi());
            Console.WriteLine("Koiran ika on: " + susi.AsetaElaimenIka());
            Console.WriteLine("Onko turkki: " + susi.PalautaTurkki());
            Console.ReadLine();
            

            Papukaija parrot = new Papukaija();
            Console.WriteLine("Papukaijan nimi on: " + parrot.PalautaElaimenNimi());
            Console.WriteLine("Papukaijan ika on: " + parrot.AsetaElaimenIka());
            Console.WriteLine("Onko siivet: " + parrot.PalautaSiivet());
            Console.ReadLine();

        }
    }
}